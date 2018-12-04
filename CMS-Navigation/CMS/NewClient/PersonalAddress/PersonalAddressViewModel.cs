using CMS.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace CMS.NewClient.PersonalAddress
{
    public class PersonalAddressViewModel : BaseViewModel, IDataErrorInfo
    {
        private Dictionary<string, string> _errors;

        public PersonalAddressViewModel()
        {
            _errors = new Dictionary<string, string>();
            
        }

        private string _street;
        public string Street
        {
            get => _street;
            set
            {
                SetPropertyValue(ref _street, value);
                Validate(value, new StreetValidator());
            }
        }
         
        private string _streetnumber;
        public string StreetNumber
        {
            get => _streetnumber;
            set
            {
                SetPropertyValue(ref _streetnumber, value);
                Validate(value, new StreetNumberValidator());
            }
        }

        private string _postCode;
        public string PostCode
        {
            get => _postCode;
            set
            {
                SetPropertyValue(ref _postCode, value);
                Validate(value, new PostCodeValidator());
            }
        }

        private string _city;
        public string City
        {
            get => _city;
            set
            {
                SetPropertyValue(ref _city, value);
                Validate(value, new CityValidator());
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (_errors.ContainsKey(columnName))
                    return _errors[columnName];
                return null;
            }
        }

        public string Error => _errors
            .Select(x => x.Value)
            .FirstOrDefault();

        public override bool HasErrors => string.IsNullOrWhiteSpace(Street)
                                            || string.IsNullOrWhiteSpace(StreetNumber)
                                            || string.IsNullOrWhiteSpace(PostCode)
                                          || string.IsNullOrWhiteSpace(City)
                                          || _errors.Any();


        private void Validate(object value, ValidationRule validator, [CallerMemberName]string propertyname = null)
        {
            var error = validator.Validate(value, null);

            //var svalidatorvalue = validator.ToString();
            //var snameofvalue="";


            //switch (svalidatorvalue)
            //{
            //    case "CMS.NewClient.PersonalAddress.StreetValidator":
            //        snameofvalue = "Street";
            //        break;
            //    case "CMS.NewClient.PersonalAddress.StreetNumberValidator":
            //        snameofvalue = "StreetNumber";
            //        break;
            //    case "CMS.NewClient.PersonalAddress.PostCodeValidator":
            //        snameofvalue = "PostCode";
            //        break;
            //    case "CMS.NewClient.PersonalAddress.CityValidator":
            //        snameofvalue = "City";
            //        break;
            //}



            if (!error.IsValid)

                _errors[propertyname] = error.ErrorContent as string;
                //_errors[nameof(Street)] = error.ErrorContent as string;
                //_errors[nameof(snameofvalue)] = error.ErrorContent as string;

            else
            {
                _errors.Remove(propertyname);
                //_errors.Remove(nameof(Street));
                //_errors.Remove(nameof(snameofvalue));

            }
            OnErrorsChanged();
        }

    }
}
