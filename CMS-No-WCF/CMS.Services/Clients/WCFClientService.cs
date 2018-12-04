using CMS.Models;
using CMS.Services.Interfaces;
using System.Threading.Tasks;
using System.Windows;

namespace CMS.Services.Clients
{
    public class WCFClientService : IClientService
    {
        public string AuthToken { get; set; }


        public WCFClientService()
        {
        }

        public async Task<Client[]> GetClientsForBranch(string branchId)
        {
            var client = new ClientServiceReference.Service1Client("BasicHttpBinding_IService1");
            //var val = await client.GetDataAsync(13);

            //MessageBox.Show(val);
            return client.GetClient();
        }

        public async Task<Client> AddNewClient(Client newClient)
        {
            var client = new ClientServiceReference.Service1Client("BasicHttpBinding_IService1");

            client.AddClient(newClient);

            return null;
        }

        public async Task<Client> DeleteClient(string Client)
        {
            var client = new ClientServiceReference.Service1Client("BasicHttpBinding_IService1");

            var val = await client.DeleteClientAsync(Client);

            return null;
        }


        public Client UpdateClient(Client newClient)
        {
            var client = new ClientServiceReference.Service1Client("BasicHttpBinding_IService1");

            var val = client.UpdateClientAsync(newClient);

            return null;
        }

        public async Task<Client[]> GetClient()
        {
            var client = new ClientServiceReference.Service1Client("BasicHttpBinding_IService1");

            var val = client.GetClient();
   
            return null;
        }

    }
}
