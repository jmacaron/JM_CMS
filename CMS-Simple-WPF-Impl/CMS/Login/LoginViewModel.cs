using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
//using System.Windows.Controls;

namespace CMS.Login
{
    class LoginViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public bool CanLogin ()=> true;


        public LoginViewModel()
        {
            this.Email = "johnmac@email.com";
            this.Password = "xxxxxxxxxxxxx";

            Login = new LoginCommand(login, CanLogin);
            //Login = new LoginCommand(login, ()=> true );
            //Login = new LoginCommand(OnTryLogin,CanLogin);
            Cancel = new CancelCommand();
        }

        private string _email;
        private string _password;

        private void  login()
        {
            MessageBox.Show(Email);
        }

        [Required]
        [EmailAddress]
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                ValidateProperty(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }

        #region data validation
        private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();
        #endregion

        public LoginCommand Login { get; private set; }
        public CancelCommand Cancel { get; private set; }

        public IEnumerable<string> Errors => _errors.SelectMany(x => x.Value);

        public IEnumerable GetErrors(string propertyName)
        {
            return _errors.ContainsKey(propertyName)
                ? _errors[propertyName]
                : null;
        }

        //public bool HasErrors => throw new NotImplementedException();
        public bool HasErrors => _errors.Any();

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        private void  ValidateProperty(object value, [CallerMemberName] string propertyName = null)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this)
            {
                MemberName = propertyName
            };
            Validator.TryValidateProperty(value, context, results);
            if (results.Any())
                _errors[propertyName] = results.Select(c => c.ErrorMessage).ToList();
            else
                _errors.Remove(propertyName);

            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));

           // OnPropertyChanged(nameof(Errors));
           // Login.OnCanExecuteChanged();
        }

    }
}