﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisOfertas.ServiceReporte {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReporte.reporteSoap")]
    public interface reporteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/archivoPlano", ReplyAction="*")]
        void archivoPlano();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/archivoPlano", ReplyAction="*")]
        System.Threading.Tasks.Task archivoPlanoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface reporteSoapChannel : MisOfertas.ServiceReporte.reporteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class reporteSoapClient : System.ServiceModel.ClientBase<MisOfertas.ServiceReporte.reporteSoap>, MisOfertas.ServiceReporte.reporteSoap {
        
        public reporteSoapClient() {
        }
        
        public reporteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public reporteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public reporteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public reporteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void archivoPlano() {
            base.Channel.archivoPlano();
        }
        
        public System.Threading.Tasks.Task archivoPlanoAsync() {
            return base.Channel.archivoPlanoAsync();
        }
    }
}