﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcInterfazUsuario.srvProducto {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srvProducto.IsrvProducto")]
    public interface IsrvProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/recProducto_ENT", ReplyAction="http://tempuri.org/IsrvProducto/recProducto_ENTResponse")]
        System.Collections.Generic.List<Entidades.Producto> recProducto_ENT();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/recProducto_ENT", ReplyAction="http://tempuri.org/IsrvProducto/recProducto_ENTResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Producto>> recProducto_ENTAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/recProductoXId_ENT", ReplyAction="http://tempuri.org/IsrvProducto/recProductoXId_ENTResponse")]
        Entidades.Producto recProductoXId_ENT(int pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/recProductoXId_ENT", ReplyAction="http://tempuri.org/IsrvProducto/recProductoXId_ENTResponse")]
        System.Threading.Tasks.Task<Entidades.Producto> recProductoXId_ENTAsync(int pId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/insProducto_ENT", ReplyAction="http://tempuri.org/IsrvProducto/insProducto_ENTResponse")]
        bool insProducto_ENT(Entidades.Producto pProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/insProducto_ENT", ReplyAction="http://tempuri.org/IsrvProducto/insProducto_ENTResponse")]
        System.Threading.Tasks.Task<bool> insProducto_ENTAsync(Entidades.Producto pProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/modProducto_ENT", ReplyAction="http://tempuri.org/IsrvProducto/modProducto_ENTResponse")]
        bool modProducto_ENT(Entidades.Producto pProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/modProducto_ENT", ReplyAction="http://tempuri.org/IsrvProducto/modProducto_ENTResponse")]
        System.Threading.Tasks.Task<bool> modProducto_ENTAsync(Entidades.Producto pProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/delProducto_ENT", ReplyAction="http://tempuri.org/IsrvProducto/delProducto_ENTResponse")]
        bool delProducto_ENT(Entidades.Producto pProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsrvProducto/delProducto_ENT", ReplyAction="http://tempuri.org/IsrvProducto/delProducto_ENTResponse")]
        System.Threading.Tasks.Task<bool> delProducto_ENTAsync(Entidades.Producto pProducto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IsrvProductoChannel : mvcInterfazUsuario.srvProducto.IsrvProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IsrvProductoClient : System.ServiceModel.ClientBase<mvcInterfazUsuario.srvProducto.IsrvProducto>, mvcInterfazUsuario.srvProducto.IsrvProducto {
        
        public IsrvProductoClient() {
        }
        
        public IsrvProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IsrvProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsrvProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IsrvProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Entidades.Producto> recProducto_ENT() {
            return base.Channel.recProducto_ENT();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Producto>> recProducto_ENTAsync() {
            return base.Channel.recProducto_ENTAsync();
        }
        
        public Entidades.Producto recProductoXId_ENT(int pId) {
            return base.Channel.recProductoXId_ENT(pId);
        }
        
        public System.Threading.Tasks.Task<Entidades.Producto> recProductoXId_ENTAsync(int pId) {
            return base.Channel.recProductoXId_ENTAsync(pId);
        }
        
        public bool insProducto_ENT(Entidades.Producto pProducto) {
            return base.Channel.insProducto_ENT(pProducto);
        }
        
        public System.Threading.Tasks.Task<bool> insProducto_ENTAsync(Entidades.Producto pProducto) {
            return base.Channel.insProducto_ENTAsync(pProducto);
        }
        
        public bool modProducto_ENT(Entidades.Producto pProducto) {
            return base.Channel.modProducto_ENT(pProducto);
        }
        
        public System.Threading.Tasks.Task<bool> modProducto_ENTAsync(Entidades.Producto pProducto) {
            return base.Channel.modProducto_ENTAsync(pProducto);
        }
        
        public bool delProducto_ENT(Entidades.Producto pProducto) {
            return base.Channel.delProducto_ENT(pProducto);
        }
        
        public System.Threading.Tasks.Task<bool> delProducto_ENTAsync(Entidades.Producto pProducto) {
            return base.Channel.delProducto_ENTAsync(pProducto);
        }
    }
}
