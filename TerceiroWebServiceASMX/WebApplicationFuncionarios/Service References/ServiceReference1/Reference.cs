﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationFuncionarios.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Funcionario", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Funcionario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        private double SalarioField;
        
        private System.DateTime DataCadastroField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double Salario {
            get {
                return this.SalarioField;
            }
            set {
                if ((this.SalarioField.Equals(value) != true)) {
                    this.SalarioField = value;
                    this.RaisePropertyChanged("Salario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime DataCadastro {
            get {
                return this.DataCadastroField;
            }
            set {
                if ((this.DataCadastroField.Equals(value) != true)) {
                    this.DataCadastroField = value;
                    this.RaisePropertyChanged("DataCadastro");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ServicoFuncionarioSoap")]
    public interface ServicoFuncionarioSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebApplicationFuncionarios.ServiceReference1.HelloWorldResponse HelloWorld(WebApplicationFuncionarios.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationFuncionarios.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebApplicationFuncionarios.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name nome from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFuncionarios", ReplyAction="*")]
        WebApplicationFuncionarios.ServiceReference1.GetFuncionariosResponse GetFuncionarios(WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFuncionarios", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplicationFuncionarios.ServiceReference1.GetFuncionariosResponse> GetFuncionariosAsync(WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationFuncionarios.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApplicationFuncionarios.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationFuncionarios.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApplicationFuncionarios.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFuncionariosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFuncionarios", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequestBody Body;
        
        public GetFuncionariosRequest() {
        }
        
        public GetFuncionariosRequest(WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFuncionariosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nome;
        
        public GetFuncionariosRequestBody() {
        }
        
        public GetFuncionariosRequestBody(string nome) {
            this.nome = nome;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFuncionariosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFuncionariosResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplicationFuncionarios.ServiceReference1.GetFuncionariosResponseBody Body;
        
        public GetFuncionariosResponse() {
        }
        
        public GetFuncionariosResponse(WebApplicationFuncionarios.ServiceReference1.GetFuncionariosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFuncionariosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplicationFuncionarios.ServiceReference1.Funcionario[] GetFuncionariosResult;
        
        public GetFuncionariosResponseBody() {
        }
        
        public GetFuncionariosResponseBody(WebApplicationFuncionarios.ServiceReference1.Funcionario[] GetFuncionariosResult) {
            this.GetFuncionariosResult = GetFuncionariosResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicoFuncionarioSoapChannel : WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoFuncionarioSoapClient : System.ServiceModel.ClientBase<WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap>, WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap {
        
        public ServicoFuncionarioSoapClient() {
        }
        
        public ServicoFuncionarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoFuncionarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoFuncionarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoFuncionarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationFuncionarios.ServiceReference1.HelloWorldResponse WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap.HelloWorld(WebApplicationFuncionarios.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebApplicationFuncionarios.ServiceReference1.HelloWorldRequest inValue = new WebApplicationFuncionarios.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplicationFuncionarios.ServiceReference1.HelloWorldRequestBody();
            WebApplicationFuncionarios.ServiceReference1.HelloWorldResponse retVal = ((WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationFuncionarios.ServiceReference1.HelloWorldResponse> WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap.HelloWorldAsync(WebApplicationFuncionarios.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationFuncionarios.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebApplicationFuncionarios.ServiceReference1.HelloWorldRequest inValue = new WebApplicationFuncionarios.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplicationFuncionarios.ServiceReference1.HelloWorldRequestBody();
            return ((WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplicationFuncionarios.ServiceReference1.GetFuncionariosResponse WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap.GetFuncionarios(WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequest request) {
            return base.Channel.GetFuncionarios(request);
        }
        
        public WebApplicationFuncionarios.ServiceReference1.Funcionario[] GetFuncionarios(string nome) {
            WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequest inValue = new WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequest();
            inValue.Body = new WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequestBody();
            inValue.Body.nome = nome;
            WebApplicationFuncionarios.ServiceReference1.GetFuncionariosResponse retVal = ((WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap)(this)).GetFuncionarios(inValue);
            return retVal.Body.GetFuncionariosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplicationFuncionarios.ServiceReference1.GetFuncionariosResponse> WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap.GetFuncionariosAsync(WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequest request) {
            return base.Channel.GetFuncionariosAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplicationFuncionarios.ServiceReference1.GetFuncionariosResponse> GetFuncionariosAsync(string nome) {
            WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequest inValue = new WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequest();
            inValue.Body = new WebApplicationFuncionarios.ServiceReference1.GetFuncionariosRequestBody();
            inValue.Body.nome = nome;
            return ((WebApplicationFuncionarios.ServiceReference1.ServicoFuncionarioSoap)(this)).GetFuncionariosAsync(inValue);
        }
    }
}
