using CMS.Models;
using CMS.Repositories.Models;
using CMS.Repositories.Factories;
using CMS.Repositories.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.WCF.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        static ClientFactory RepoFactory = new ClientFactory();
        private IClientRepository myRepoService;

        public Service1()
        {
            RepoFactory.InstatiateService();
            myRepoService = RepoFactory.InstatiateService();
        }
        
        public string GetData(int value)
        {
           myRepoService.GetClients(value);

            return string.Format("You entered: {0}", value);
        }

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        public async Task<Client> AddClient(Client client)
        {

            var clientaddrepo = await myRepoService.AddClient(client.ToRepoModel());

            return clientaddrepo.ToModel();//  Task.FromResult<Client>(client);
        }

        public Task<bool> DeleteClient(string client)
        {
            return Task.FromResult<bool>(true);
        }

        public Client UpdateClient(Client client)
        {
            return client;
        }

        public async Task<Client[]> GetClient()
        {
            var clientsrepo = await myRepoService.GetClients(100);

            var clientslist = clientsrepo.Select(c => c.ToModel());

            return clientslist.ToArray();
        }

    }
}
