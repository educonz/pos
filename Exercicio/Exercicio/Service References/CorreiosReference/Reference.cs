﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exercicio.CorreiosReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CorreiosReference.CalcPrecoPrazoWSSoap")]
    public interface CalcPrecoPrazoWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoPrazo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPrecoPrazo(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoPrazo", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoPrazoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoPrazoData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPrecoPrazoData(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoPrazoData", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoPrazoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoPrazoRestricao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPrecoPrazoRestricao(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoPrazoRestricao", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoPrazoRestricaoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPreco", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPreco(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPreco", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPrecoData(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoData", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrazo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPrazo(string nCdServico, string sCepOrigem, string sCepDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrazo", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrazoAsync(string nCdServico, string sCepOrigem, string sCepDestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrazoData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPrazoData(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrazoData", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrazoDataAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrazoRestricao", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPrazoRestricao(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrazoRestricao", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrazoRestricaoAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoFAC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Exercicio.CorreiosReference.cResultado CalcPrecoFAC(string nCdServico, string nVlPeso, string strDataCalculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcPrecoFAC", ReplyAction="*")]
        System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoFACAsync(string nCdServico, string nVlPeso, string strDataCalculo);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class cResultado : object, System.ComponentModel.INotifyPropertyChanged {
        
        private cServico[] servicosField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public cServico[] Servicos {
            get {
                return this.servicosField;
            }
            set {
                this.servicosField = value;
                this.RaisePropertyChanged("Servicos");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class cServico : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int codigoField;
        
        private string valorField;
        
        private string prazoEntregaField;
        
        private string valorMaoPropriaField;
        
        private string valorAvisoRecebimentoField;
        
        private string valorValorDeclaradoField;
        
        private string entregaDomiciliarField;
        
        private string entregaSabadoField;
        
        private string erroField;
        
        private string msgErroField;
        
        private string valorSemAdicionaisField;
        
        private string obsFimField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("Codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Valor {
            get {
                return this.valorField;
            }
            set {
                this.valorField = value;
                this.RaisePropertyChanged("Valor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string PrazoEntrega {
            get {
                return this.prazoEntregaField;
            }
            set {
                this.prazoEntregaField = value;
                this.RaisePropertyChanged("PrazoEntrega");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ValorMaoPropria {
            get {
                return this.valorMaoPropriaField;
            }
            set {
                this.valorMaoPropriaField = value;
                this.RaisePropertyChanged("ValorMaoPropria");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ValorAvisoRecebimento {
            get {
                return this.valorAvisoRecebimentoField;
            }
            set {
                this.valorAvisoRecebimentoField = value;
                this.RaisePropertyChanged("ValorAvisoRecebimento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ValorValorDeclarado {
            get {
                return this.valorValorDeclaradoField;
            }
            set {
                this.valorValorDeclaradoField = value;
                this.RaisePropertyChanged("ValorValorDeclarado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string EntregaDomiciliar {
            get {
                return this.entregaDomiciliarField;
            }
            set {
                this.entregaDomiciliarField = value;
                this.RaisePropertyChanged("EntregaDomiciliar");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string EntregaSabado {
            get {
                return this.entregaSabadoField;
            }
            set {
                this.entregaSabadoField = value;
                this.RaisePropertyChanged("EntregaSabado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Erro {
            get {
                return this.erroField;
            }
            set {
                this.erroField = value;
                this.RaisePropertyChanged("Erro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string MsgErro {
            get {
                return this.msgErroField;
            }
            set {
                this.msgErroField = value;
                this.RaisePropertyChanged("MsgErro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string ValorSemAdicionais {
            get {
                return this.valorSemAdicionaisField;
            }
            set {
                this.valorSemAdicionaisField = value;
                this.RaisePropertyChanged("ValorSemAdicionais");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string obsFim {
            get {
                return this.obsFimField;
            }
            set {
                this.obsFimField = value;
                this.RaisePropertyChanged("obsFim");
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
    public interface CalcPrecoPrazoWSSoapChannel : Exercicio.CorreiosReference.CalcPrecoPrazoWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcPrecoPrazoWSSoapClient : System.ServiceModel.ClientBase<Exercicio.CorreiosReference.CalcPrecoPrazoWSSoap>, Exercicio.CorreiosReference.CalcPrecoPrazoWSSoap {
        
        public CalcPrecoPrazoWSSoapClient() {
        }
        
        public CalcPrecoPrazoWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcPrecoPrazoWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcPrecoPrazoWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcPrecoPrazoWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPrecoPrazo(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
            return base.Channel.CalcPrecoPrazo(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoPrazoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
            return base.Channel.CalcPrecoPrazoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPrecoPrazoData(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
            return base.Channel.CalcPrecoPrazoData(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoPrazoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
            return base.Channel.CalcPrecoPrazoDataAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPrecoPrazoRestricao(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
            return base.Channel.CalcPrecoPrazoRestricao(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoPrazoRestricaoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
            return base.Channel.CalcPrecoPrazoRestricaoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPreco(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
            return base.Channel.CalcPreco(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
            return base.Channel.CalcPrecoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPrecoData(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
            return base.Channel.CalcPrecoData(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo) {
            return base.Channel.CalcPrecoDataAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPrazo(string nCdServico, string sCepOrigem, string sCepDestino) {
            return base.Channel.CalcPrazo(nCdServico, sCepOrigem, sCepDestino);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrazoAsync(string nCdServico, string sCepOrigem, string sCepDestino) {
            return base.Channel.CalcPrazoAsync(nCdServico, sCepOrigem, sCepDestino);
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPrazoData(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo) {
            return base.Channel.CalcPrazoData(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrazoDataAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo) {
            return base.Channel.CalcPrazoDataAsync(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPrazoRestricao(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo) {
            return base.Channel.CalcPrazoRestricao(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrazoRestricaoAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo) {
            return base.Channel.CalcPrazoRestricaoAsync(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
        }
        
        public Exercicio.CorreiosReference.cResultado CalcPrecoFAC(string nCdServico, string nVlPeso, string strDataCalculo) {
            return base.Channel.CalcPrecoFAC(nCdServico, nVlPeso, strDataCalculo);
        }
        
        public System.Threading.Tasks.Task<Exercicio.CorreiosReference.cResultado> CalcPrecoFACAsync(string nCdServico, string nVlPeso, string strDataCalculo) {
            return base.Channel.CalcPrecoFACAsync(nCdServico, nVlPeso, strDataCalculo);
        }
    }
}
