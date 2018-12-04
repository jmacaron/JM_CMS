using CMS.NewClient.PersonalAddress;
using CMS.NewClient.PersonalInfo;
using CMS.Tools;
using System.Windows;

namespace CMS.NewClient
{
    public class NewClientViewModel : BaseViewModel
    {
        private PersonalInfoViewModel _personalInfoViewModel;
        private PersonalAddressViewModel _personalAddressViewModel;

        public NewClientViewModel()
        {
            _personalInfoViewModel = new PersonalInfoViewModel();
            _personalInfoViewModel.ErrorsChanged += _personalInfoViewModel_ErrorsChanged;

            _personalAddressViewModel = new PersonalAddressViewModel();
            _personalAddressViewModel.ErrorsChanged += _personalAddressViewModel_ErrorsChanged;

            ActiveViewModel = _personalInfoViewModel;
            NextStep = new RelayCommand(OnNextStep, CanGoNext);
            PreviousStep = new RelayCommand(OnPreviousStep, CanGoPrevious);
        }

        private void _personalInfoViewModel_ErrorsChanged(object sender, System.ComponentModel.DataErrorsChangedEventArgs e)
        {
            NextStep.OnCanExecuteChanged();
            PreviousStep.OnCanExecuteChanged();
        }

        private void _personalAddressViewModel_ErrorsChanged(object sender, System.ComponentModel.DataErrorsChangedEventArgs e)
        {
            NextStep.OnCanExecuteChanged();
            PreviousStep.OnCanExecuteChanged();
        }

        private BaseViewModel _activeViewModel;
        public BaseViewModel ActiveViewModel
        {
            get => _activeViewModel;
            set => SetPropertyValue(ref _activeViewModel, value);
        }

        public RelayCommand NextStep { get; set; }
        public RelayCommand PreviousStep { get; set; }

        private void OnNextStep(object param)
        {
            //MessageBox.Show(ActiveViewModel.ToString());
            //essageBox.Show("Next step");
            //ActiveViewModel = _personalAddressViewModel;

            if (ActiveViewModel.ToString() == "CMS.NewClient.PersonalInfo.PersonalInfoViewModel")
            {
                ActiveViewModel = _personalAddressViewModel;
            }

            //if (ActiveViewModel.ToString() == "CMS.NewClient.PersonalAddress.PersonalAddressViewModel")
            //    ActiveViewModel = _personalInfoViewModel;

        }

        private bool CanGoNext(object param)
        {
            return !ActiveViewModel.HasErrors;
        }

        private void OnPreviousStep(object param)
        {
            //MessageBox.Show(ActiveViewModel.ToString());
            //essageBox.Show("Next step");
            //ActiveViewModel = _personalAddressViewModel;

            if (ActiveViewModel.ToString() == "CMS.NewClient.PersonalAddress.PersonalAddressViewModel")
            {
                ActiveViewModel = _personalInfoViewModel;
            }

            //if (ActiveViewModel.ToString() == "CMS.NewClient.PersonalAddress.PersonalAddressViewModel")
            //    ActiveViewModel = _personalInfoViewModel;

        }

        private bool CanGoPrevious(object param)
        {
            return !ActiveViewModel.HasErrors;
        }
    }
}
