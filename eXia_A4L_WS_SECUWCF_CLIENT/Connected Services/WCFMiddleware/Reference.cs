﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MSG", Namespace="http://schemas.datacontract.org/2004/07/WCFContract")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    public partial struct MSG : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string appVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] dataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string infoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string operationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string operationVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool statusOpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tokenAppField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tokenUserField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string appVersion {
            get {
                return this.appVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.appVersionField, value) != true)) {
                    this.appVersionField = value;
                    this.RaisePropertyChanged("appVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] data {
            get {
                return this.dataField;
            }
            set {
                if ((object.ReferenceEquals(this.dataField, value) != true)) {
                    this.dataField = value;
                    this.RaisePropertyChanged("data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string info {
            get {
                return this.infoField;
            }
            set {
                if ((object.ReferenceEquals(this.infoField, value) != true)) {
                    this.infoField = value;
                    this.RaisePropertyChanged("info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string operationName {
            get {
                return this.operationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.operationNameField, value) != true)) {
                    this.operationNameField = value;
                    this.RaisePropertyChanged("operationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string operationVersion {
            get {
                return this.operationVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.operationVersionField, value) != true)) {
                    this.operationVersionField = value;
                    this.RaisePropertyChanged("operationVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool statusOp {
            get {
                return this.statusOpField;
            }
            set {
                if ((this.statusOpField.Equals(value) != true)) {
                    this.statusOpField = value;
                    this.RaisePropertyChanged("statusOp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tokenApp {
            get {
                return this.tokenAppField;
            }
            set {
                if ((object.ReferenceEquals(this.tokenAppField, value) != true)) {
                    this.tokenAppField = value;
                    this.RaisePropertyChanged("tokenApp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tokenUser {
            get {
                return this.tokenUserField;
            }
            set {
                if ((object.ReferenceEquals(this.tokenUserField, value) != true)) {
                    this.tokenUserField = value;
                    this.RaisePropertyChanged("tokenUser");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFMiddleware.IServerEntryPoint")]
    public interface IServerEntryPoint {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerEntryPoint/m_service", ReplyAction="http://tempuri.org/IServerEntryPoint/m_serviceResponse")]
        eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG m_service(eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG message);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IServerEntryPoint/m_service", ReplyAction="http://tempuri.org/IServerEntryPoint/m_serviceResponse")]
        System.IAsyncResult Beginm_service(eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG message, System.AsyncCallback callback, object asyncState);
        
        eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG Endm_service(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServerEntryPointChannel : eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.IServerEntryPoint, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class m_serviceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public m_serviceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerEntryPointClient : System.ServiceModel.ClientBase<eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.IServerEntryPoint>, eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.IServerEntryPoint {
        
        private BeginOperationDelegate onBeginm_serviceDelegate;
        
        private EndOperationDelegate onEndm_serviceDelegate;
        
        private System.Threading.SendOrPostCallback onm_serviceCompletedDelegate;
        
        public ServerEntryPointClient() {
        }
        
        public ServerEntryPointClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServerEntryPointClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerEntryPointClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerEntryPointClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<m_serviceCompletedEventArgs> m_serviceCompleted;
        
        public eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG m_service(eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG message) {
            return base.Channel.m_service(message);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Beginm_service(eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG message, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginm_service(message, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG Endm_service(System.IAsyncResult result) {
            return base.Channel.Endm_service(result);
        }
        
        private System.IAsyncResult OnBeginm_service(object[] inValues, System.AsyncCallback callback, object asyncState) {
            eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG message = ((eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG)(inValues[0]));
            return this.Beginm_service(message, callback, asyncState);
        }
        
        private object[] OnEndm_service(System.IAsyncResult result) {
            eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG retVal = this.Endm_service(result);
            return new object[] {
                    retVal};
        }
        
        private void Onm_serviceCompleted(object state) {
            if ((this.m_serviceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.m_serviceCompleted(this, new m_serviceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void m_serviceAsync(eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG message) {
            this.m_serviceAsync(message, null);
        }
        
        public void m_serviceAsync(eXia_A4L_WS_SECUWCF_CLIENT.WCFMiddleware.MSG message, object userState) {
            if ((this.onBeginm_serviceDelegate == null)) {
                this.onBeginm_serviceDelegate = new BeginOperationDelegate(this.OnBeginm_service);
            }
            if ((this.onEndm_serviceDelegate == null)) {
                this.onEndm_serviceDelegate = new EndOperationDelegate(this.OnEndm_service);
            }
            if ((this.onm_serviceCompletedDelegate == null)) {
                this.onm_serviceCompletedDelegate = new System.Threading.SendOrPostCallback(this.Onm_serviceCompleted);
            }
            base.InvokeAsync(this.onBeginm_serviceDelegate, new object[] {
                        message}, this.onEndm_serviceDelegate, this.onm_serviceCompletedDelegate, userState);
        }
    }
}