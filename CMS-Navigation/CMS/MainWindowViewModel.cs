using CMS.Interfaces;
using CMS.Main;
using CMS.NewCard;
using CMS.NewClient;
using CMS.Services.Interfaces;
using CMS.Tools;

namespace CMS
{
    public class MainWindowViewModel : BaseViewModel
    {
        private IClientService _clientService;
        private ClientsViewModel _clientsViewModel;

        private NewClientViewModel _newClientViewModel;
        private NewCardViewModel _newCardViewModel;

        public string AuthToken { get; private set; }

        private BaseViewModel _activeView;
        public BaseViewModel ActiveView
        {
            get => _activeView;
            set => SetPropertyValue(ref _activeView, value);
        }

        public MainWindowViewModel()
        {
            _clientService = App.ClientFactory.InstatiateService();
            _clientsViewModel = new ClientsViewModel(_clientService);
            _clientsViewModel.OnAddNewClient += ClientsViewModelOnAddNewClient;
            _newClientViewModel = new NewClientViewModel();

            _newCardViewModel = new NewCardViewModel();
            _clientsViewModel.OnAddNewCard += ClientsViewModelOnAddNewCard;
        }

        private void ClientsViewModelOnAddNewClient(BaseViewModel sender)
        {
            ActiveView = _newClientViewModel;
        }

        private void ClientsViewModelOnAddNewCard(BaseViewModel sender)
        {
            ActiveView = _newCardViewModel;
        }
        


        public async void LoadAuthToken(IClosable owner)
        {
            ActiveView = _clientsViewModel;

            //var service = App.LoginFactory.InstatiateService();
            //var token = await service.Authenticate();
            //if (string.IsNullOrWhiteSpace(token))
            //{
            //    owner.Close();
            //}
            //else
            //{
            //    MessageBox.Show(token);
            //    _clientService.AuthToken = token;
            //    ActiveView = new ClientsViewModel(_clientService);
            //}

        }

    }
}
