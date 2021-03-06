﻿using CMS.Services.Clients;
using CMS.Services.Interfaces;
using CMS.Tools;
using Unity;

namespace CMS.Services.Factories
{ 
    public class RepoFactory : BaseFactory<IClientService>
    {
        public override void RegisterInterfaces()
        {
            Container.RegisterType<IClientService, TestClientService>();
        }
    }
}
