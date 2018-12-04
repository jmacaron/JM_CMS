﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS.Services.ClientServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddClient", ReplyAction="http://tempuri.org/IService1/AddClientResponse")]
        CMS.Models.Client[] AddClient(CMS.Models.Client clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddClient", ReplyAction="http://tempuri.org/IService1/AddClientResponse")]
        System.Threading.Tasks.Task<CMS.Models.Client[]> AddClientAsync(CMS.Models.Client clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClient", ReplyAction="http://tempuri.org/IService1/DeleteClientResponse")]
        CMS.Models.Client[] DeleteClient(string clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteClient", ReplyAction="http://tempuri.org/IService1/DeleteClientResponse")]
        System.Threading.Tasks.Task<CMS.Models.Client[]> DeleteClientAsync(string clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateClient", ReplyAction="http://tempuri.org/IService1/UpdateClientResponse")]
        CMS.Models.Client[] UpdateClient(CMS.Models.Client clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateClient", ReplyAction="http://tempuri.org/IService1/UpdateClientResponse")]
        System.Threading.Tasks.Task<CMS.Models.Client[]> UpdateClientAsync(CMS.Models.Client clientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        CMS.Models.Client[] GetClient();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        System.Threading.Tasks.Task<CMS.Models.Client[]> GetClientAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CMS.Services.ClientServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CMS.Services.ClientServiceReference.IService1>, CMS.Services.ClientServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public CMS.Models.Client[] AddClient(CMS.Models.Client clientId) {
            return base.Channel.AddClient(clientId);
        }
        
        public System.Threading.Tasks.Task<CMS.Models.Client[]> AddClientAsync(CMS.Models.Client clientId) {
            return base.Channel.AddClientAsync(clientId);
        }
        
        public CMS.Models.Client[] DeleteClient(string clientId) {
            return base.Channel.DeleteClient(clientId);
        }
        
        public System.Threading.Tasks.Task<CMS.Models.Client[]> DeleteClientAsync(string clientId) {
            return base.Channel.DeleteClientAsync(clientId);
        }
        
        public CMS.Models.Client[] UpdateClient(CMS.Models.Client clientId) {
            return base.Channel.UpdateClient(clientId);
        }
        
        public System.Threading.Tasks.Task<CMS.Models.Client[]> UpdateClientAsync(CMS.Models.Client clientId) {
            return base.Channel.UpdateClientAsync(clientId);
        }
        
        public CMS.Models.Client[] GetClient() {
            return base.Channel.GetClient();
        }
        
        public System.Threading.Tasks.Task<CMS.Models.Client[]> GetClientAsync() {
            return base.Channel.GetClientAsync();
        }
    }
}