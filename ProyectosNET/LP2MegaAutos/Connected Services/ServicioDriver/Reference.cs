﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2MegaAutos.ServicioDriver {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.megaautos.com.pe/", ConfigurationName="ServicioDriver.DriverWS")]
    public interface DriverWS {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/eliminarDriverRequest", ReplyAction="http://services.megaautos.com.pe/DriverWS/eliminarDriverResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioDriver.eliminarDriverResponse eliminarDriver(LP2MegaAutos.ServicioDriver.eliminarDriverRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/eliminarDriverRequest", ReplyAction="http://services.megaautos.com.pe/DriverWS/eliminarDriverResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.eliminarDriverResponse> eliminarDriverAsync(LP2MegaAutos.ServicioDriver.eliminarDriverRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/insertarDriver2Request", ReplyAction="http://services.megaautos.com.pe/DriverWS/insertarDriver2Response")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioDriver.insertarDriver2Response insertarDriver2(LP2MegaAutos.ServicioDriver.insertarDriver2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/insertarDriver2Request", ReplyAction="http://services.megaautos.com.pe/DriverWS/insertarDriver2Response")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.insertarDriver2Response> insertarDriver2Async(LP2MegaAutos.ServicioDriver.insertarDriver2Request request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/listarDrivers2Request", ReplyAction="http://services.megaautos.com.pe/DriverWS/listarDrivers2Response")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioDriver.listarDrivers2Response listarDrivers2(LP2MegaAutos.ServicioDriver.listarDrivers2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/listarDrivers2Request", ReplyAction="http://services.megaautos.com.pe/DriverWS/listarDrivers2Response")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.listarDrivers2Response> listarDrivers2Async(LP2MegaAutos.ServicioDriver.listarDrivers2Request request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/actualizarDriverRequest", ReplyAction="http://services.megaautos.com.pe/DriverWS/actualizarDriverResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioDriver.actualizarDriverResponse actualizarDriver(LP2MegaAutos.ServicioDriver.actualizarDriverRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/actualizarDriverRequest", ReplyAction="http://services.megaautos.com.pe/DriverWS/actualizarDriverResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.actualizarDriverResponse> actualizarDriverAsync(LP2MegaAutos.ServicioDriver.actualizarDriverRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/listarDriversRequest", ReplyAction="http://services.megaautos.com.pe/DriverWS/listarDriversResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioDriver.listarDriversResponse listarDrivers(LP2MegaAutos.ServicioDriver.listarDriversRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/DriverWS/listarDriversRequest", ReplyAction="http://services.megaautos.com.pe/DriverWS/listarDriversResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.listarDriversResponse> listarDriversAsync(LP2MegaAutos.ServicioDriver.listarDriversRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarDriver", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarDriverRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idDriver;
        
        public eliminarDriverRequest() {
        }
        
        public eliminarDriverRequest(int idDriver) {
            this.idDriver = idDriver;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarDriverResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarDriverResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarDriverResponse() {
        }
        
        public eliminarDriverResponse(int @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.megaautos.com.pe/")]
    public partial class driver : object, System.ComponentModel.INotifyPropertyChanged {
        
        private double formulaField;
        
        private int idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public double formula {
            get {
                return this.formulaField;
            }
            set {
                this.formulaField = value;
                this.RaisePropertyChanged("formula");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.megaautos.com.pe/")]
    public partial class cliente : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private int idField;
        
        private string nombreField;
        
        private string numDocumentoField;
        
        private string telefonoField;
        
        private string tipoClienteField;
        
        private string tipoDocumentoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string numDocumento {
            get {
                return this.numDocumentoField;
            }
            set {
                this.numDocumentoField = value;
                this.RaisePropertyChanged("numDocumento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string tipoCliente {
            get {
                return this.tipoClienteField;
            }
            set {
                this.tipoClienteField = value;
                this.RaisePropertyChanged("tipoCliente");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string tipoDocumento {
            get {
                return this.tipoDocumentoField;
            }
            set {
                this.tipoDocumentoField = value;
                this.RaisePropertyChanged("tipoDocumento");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarDriver2", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarDriver2Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioDriver.driver objDriver;
        
        public insertarDriver2Request() {
        }
        
        public insertarDriver2Request(LP2MegaAutos.ServicioDriver.driver objDriver) {
            this.objDriver = objDriver;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarDriver2Response", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarDriver2Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarDriver2Response() {
        }
        
        public insertarDriver2Response(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarDrivers2", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarDrivers2Request {
        
        public listarDrivers2Request() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarDrivers2Response", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarDrivers2Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioDriver.driver[] @return;
        
        public listarDrivers2Response() {
        }
        
        public listarDrivers2Response(LP2MegaAutos.ServicioDriver.driver[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarDriver", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarDriverRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioDriver.driver objDriver;
        
        public actualizarDriverRequest() {
        }
        
        public actualizarDriverRequest(LP2MegaAutos.ServicioDriver.driver objDriver) {
            this.objDriver = objDriver;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarDriverResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarDriverResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarDriverResponse() {
        }
        
        public actualizarDriverResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarDrivers", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarDriversRequest {
        
        public listarDriversRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarDriversResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarDriversResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioDriver.cliente[] @return;
        
        public listarDriversResponse() {
        }
        
        public listarDriversResponse(LP2MegaAutos.ServicioDriver.cliente[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DriverWSChannel : LP2MegaAutos.ServicioDriver.DriverWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DriverWSClient : System.ServiceModel.ClientBase<LP2MegaAutos.ServicioDriver.DriverWS>, LP2MegaAutos.ServicioDriver.DriverWS {
        
        public DriverWSClient() {
        }
        
        public DriverWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DriverWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DriverWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DriverWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioDriver.eliminarDriverResponse LP2MegaAutos.ServicioDriver.DriverWS.eliminarDriver(LP2MegaAutos.ServicioDriver.eliminarDriverRequest request) {
            return base.Channel.eliminarDriver(request);
        }
        
        public int eliminarDriver(int idDriver) {
            LP2MegaAutos.ServicioDriver.eliminarDriverRequest inValue = new LP2MegaAutos.ServicioDriver.eliminarDriverRequest();
            inValue.idDriver = idDriver;
            LP2MegaAutos.ServicioDriver.eliminarDriverResponse retVal = ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).eliminarDriver(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.eliminarDriverResponse> LP2MegaAutos.ServicioDriver.DriverWS.eliminarDriverAsync(LP2MegaAutos.ServicioDriver.eliminarDriverRequest request) {
            return base.Channel.eliminarDriverAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.eliminarDriverResponse> eliminarDriverAsync(int idDriver) {
            LP2MegaAutos.ServicioDriver.eliminarDriverRequest inValue = new LP2MegaAutos.ServicioDriver.eliminarDriverRequest();
            inValue.idDriver = idDriver;
            return ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).eliminarDriverAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioDriver.insertarDriver2Response LP2MegaAutos.ServicioDriver.DriverWS.insertarDriver2(LP2MegaAutos.ServicioDriver.insertarDriver2Request request) {
            return base.Channel.insertarDriver2(request);
        }
        
        public int insertarDriver2(LP2MegaAutos.ServicioDriver.driver objDriver) {
            LP2MegaAutos.ServicioDriver.insertarDriver2Request inValue = new LP2MegaAutos.ServicioDriver.insertarDriver2Request();
            inValue.objDriver = objDriver;
            LP2MegaAutos.ServicioDriver.insertarDriver2Response retVal = ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).insertarDriver2(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.insertarDriver2Response> LP2MegaAutos.ServicioDriver.DriverWS.insertarDriver2Async(LP2MegaAutos.ServicioDriver.insertarDriver2Request request) {
            return base.Channel.insertarDriver2Async(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.insertarDriver2Response> insertarDriver2Async(LP2MegaAutos.ServicioDriver.driver objDriver) {
            LP2MegaAutos.ServicioDriver.insertarDriver2Request inValue = new LP2MegaAutos.ServicioDriver.insertarDriver2Request();
            inValue.objDriver = objDriver;
            return ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).insertarDriver2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioDriver.listarDrivers2Response LP2MegaAutos.ServicioDriver.DriverWS.listarDrivers2(LP2MegaAutos.ServicioDriver.listarDrivers2Request request) {
            return base.Channel.listarDrivers2(request);
        }
        
        public LP2MegaAutos.ServicioDriver.driver[] listarDrivers2() {
            LP2MegaAutos.ServicioDriver.listarDrivers2Request inValue = new LP2MegaAutos.ServicioDriver.listarDrivers2Request();
            LP2MegaAutos.ServicioDriver.listarDrivers2Response retVal = ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).listarDrivers2(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.listarDrivers2Response> LP2MegaAutos.ServicioDriver.DriverWS.listarDrivers2Async(LP2MegaAutos.ServicioDriver.listarDrivers2Request request) {
            return base.Channel.listarDrivers2Async(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.listarDrivers2Response> listarDrivers2Async() {
            LP2MegaAutos.ServicioDriver.listarDrivers2Request inValue = new LP2MegaAutos.ServicioDriver.listarDrivers2Request();
            return ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).listarDrivers2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioDriver.actualizarDriverResponse LP2MegaAutos.ServicioDriver.DriverWS.actualizarDriver(LP2MegaAutos.ServicioDriver.actualizarDriverRequest request) {
            return base.Channel.actualizarDriver(request);
        }
        
        public int actualizarDriver(LP2MegaAutos.ServicioDriver.driver objDriver) {
            LP2MegaAutos.ServicioDriver.actualizarDriverRequest inValue = new LP2MegaAutos.ServicioDriver.actualizarDriverRequest();
            inValue.objDriver = objDriver;
            LP2MegaAutos.ServicioDriver.actualizarDriverResponse retVal = ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).actualizarDriver(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.actualizarDriverResponse> LP2MegaAutos.ServicioDriver.DriverWS.actualizarDriverAsync(LP2MegaAutos.ServicioDriver.actualizarDriverRequest request) {
            return base.Channel.actualizarDriverAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.actualizarDriverResponse> actualizarDriverAsync(LP2MegaAutos.ServicioDriver.driver objDriver) {
            LP2MegaAutos.ServicioDriver.actualizarDriverRequest inValue = new LP2MegaAutos.ServicioDriver.actualizarDriverRequest();
            inValue.objDriver = objDriver;
            return ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).actualizarDriverAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioDriver.listarDriversResponse LP2MegaAutos.ServicioDriver.DriverWS.listarDrivers(LP2MegaAutos.ServicioDriver.listarDriversRequest request) {
            return base.Channel.listarDrivers(request);
        }
        
        public LP2MegaAutos.ServicioDriver.cliente[] listarDrivers() {
            LP2MegaAutos.ServicioDriver.listarDriversRequest inValue = new LP2MegaAutos.ServicioDriver.listarDriversRequest();
            LP2MegaAutos.ServicioDriver.listarDriversResponse retVal = ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).listarDrivers(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.listarDriversResponse> LP2MegaAutos.ServicioDriver.DriverWS.listarDriversAsync(LP2MegaAutos.ServicioDriver.listarDriversRequest request) {
            return base.Channel.listarDriversAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioDriver.listarDriversResponse> listarDriversAsync() {
            LP2MegaAutos.ServicioDriver.listarDriversRequest inValue = new LP2MegaAutos.ServicioDriver.listarDriversRequest();
            return ((LP2MegaAutos.ServicioDriver.DriverWS)(this)).listarDriversAsync(inValue);
        }
    }
}
