﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2MegaAutos.ServicioCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.megaautos.com.pe/", ConfigurationName="ServicioCliente.ClienteWS")]
    public interface ClienteWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/actualizarClienteRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/actualizarClienteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioCliente.actualizarClienteResponse actualizarCliente(LP2MegaAutos.ServicioCliente.actualizarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/actualizarClienteRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/actualizarClienteResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.actualizarClienteResponse> actualizarClienteAsync(LP2MegaAutos.ServicioCliente.actualizarClienteRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/buscarPorNombreRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/buscarPorNombreResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioCliente.buscarPorNombreResponse buscarPorNombre(LP2MegaAutos.ServicioCliente.buscarPorNombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/buscarPorNombreRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/buscarPorNombreResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.buscarPorNombreResponse> buscarPorNombreAsync(LP2MegaAutos.ServicioCliente.buscarPorNombreRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/insertarClienteRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/insertarClienteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioCliente.insertarClienteResponse insertarCliente(LP2MegaAutos.ServicioCliente.insertarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/insertarClienteRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/insertarClienteResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.insertarClienteResponse> insertarClienteAsync(LP2MegaAutos.ServicioCliente.insertarClienteRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/listarClientesRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/listarClientesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioCliente.listarClientesResponse listarClientes(LP2MegaAutos.ServicioCliente.listarClientesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/listarClientesRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/listarClientesResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.listarClientesResponse> listarClientesAsync(LP2MegaAutos.ServicioCliente.listarClientesRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/eliminarClienteRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/eliminarClienteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioCliente.eliminarClienteResponse eliminarCliente(LP2MegaAutos.ServicioCliente.eliminarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ClienteWS/eliminarClienteRequest", ReplyAction="http://services.megaautos.com.pe/ClienteWS/eliminarClienteResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.eliminarClienteResponse> eliminarClienteAsync(LP2MegaAutos.ServicioCliente.eliminarClienteRequest request);
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarCliente", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioCliente.cliente objCliente;
        
        public actualizarClienteRequest() {
        }
        
        public actualizarClienteRequest(LP2MegaAutos.ServicioCliente.cliente objCliente) {
            this.objCliente = objCliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarClienteResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarClienteResponse() {
        }
        
        public actualizarClienteResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarPorNombre", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class buscarPorNombreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        public buscarPorNombreRequest() {
        }
        
        public buscarPorNombreRequest(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarPorNombreResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class buscarPorNombreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioCliente.cliente @return;
        
        public buscarPorNombreResponse() {
        }
        
        public buscarPorNombreResponse(LP2MegaAutos.ServicioCliente.cliente @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarCliente", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioCliente.cliente objCliente;
        
        public insertarClienteRequest() {
        }
        
        public insertarClienteRequest(LP2MegaAutos.ServicioCliente.cliente objCliente) {
            this.objCliente = objCliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarClienteResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarClienteResponse() {
        }
        
        public insertarClienteResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarClientes", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarClientesRequest {
        
        public listarClientesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarClientesResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarClientesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioCliente.cliente[] @return;
        
        public listarClientesResponse() {
        }
        
        public listarClientesResponse(LP2MegaAutos.ServicioCliente.cliente[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarCliente", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idCliente;
        
        public eliminarClienteRequest() {
        }
        
        public eliminarClienteRequest(int idCliente) {
            this.idCliente = idCliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarClienteResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarClienteResponse() {
        }
        
        public eliminarClienteResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClienteWSChannel : LP2MegaAutos.ServicioCliente.ClienteWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteWSClient : System.ServiceModel.ClientBase<LP2MegaAutos.ServicioCliente.ClienteWS>, LP2MegaAutos.ServicioCliente.ClienteWS {
        
        public ClienteWSClient() {
        }
        
        public ClienteWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioCliente.actualizarClienteResponse LP2MegaAutos.ServicioCliente.ClienteWS.actualizarCliente(LP2MegaAutos.ServicioCliente.actualizarClienteRequest request) {
            return base.Channel.actualizarCliente(request);
        }
        
        public int actualizarCliente(LP2MegaAutos.ServicioCliente.cliente objCliente) {
            LP2MegaAutos.ServicioCliente.actualizarClienteRequest inValue = new LP2MegaAutos.ServicioCliente.actualizarClienteRequest();
            inValue.objCliente = objCliente;
            LP2MegaAutos.ServicioCliente.actualizarClienteResponse retVal = ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).actualizarCliente(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.actualizarClienteResponse> LP2MegaAutos.ServicioCliente.ClienteWS.actualizarClienteAsync(LP2MegaAutos.ServicioCliente.actualizarClienteRequest request) {
            return base.Channel.actualizarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.actualizarClienteResponse> actualizarClienteAsync(LP2MegaAutos.ServicioCliente.cliente objCliente) {
            LP2MegaAutos.ServicioCliente.actualizarClienteRequest inValue = new LP2MegaAutos.ServicioCliente.actualizarClienteRequest();
            inValue.objCliente = objCliente;
            return ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).actualizarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioCliente.buscarPorNombreResponse LP2MegaAutos.ServicioCliente.ClienteWS.buscarPorNombre(LP2MegaAutos.ServicioCliente.buscarPorNombreRequest request) {
            return base.Channel.buscarPorNombre(request);
        }
        
        public LP2MegaAutos.ServicioCliente.cliente buscarPorNombre(string nombre) {
            LP2MegaAutos.ServicioCliente.buscarPorNombreRequest inValue = new LP2MegaAutos.ServicioCliente.buscarPorNombreRequest();
            inValue.nombre = nombre;
            LP2MegaAutos.ServicioCliente.buscarPorNombreResponse retVal = ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).buscarPorNombre(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.buscarPorNombreResponse> LP2MegaAutos.ServicioCliente.ClienteWS.buscarPorNombreAsync(LP2MegaAutos.ServicioCliente.buscarPorNombreRequest request) {
            return base.Channel.buscarPorNombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.buscarPorNombreResponse> buscarPorNombreAsync(string nombre) {
            LP2MegaAutos.ServicioCliente.buscarPorNombreRequest inValue = new LP2MegaAutos.ServicioCliente.buscarPorNombreRequest();
            inValue.nombre = nombre;
            return ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).buscarPorNombreAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioCliente.insertarClienteResponse LP2MegaAutos.ServicioCliente.ClienteWS.insertarCliente(LP2MegaAutos.ServicioCliente.insertarClienteRequest request) {
            return base.Channel.insertarCliente(request);
        }
        
        public int insertarCliente(LP2MegaAutos.ServicioCliente.cliente objCliente) {
            LP2MegaAutos.ServicioCliente.insertarClienteRequest inValue = new LP2MegaAutos.ServicioCliente.insertarClienteRequest();
            inValue.objCliente = objCliente;
            LP2MegaAutos.ServicioCliente.insertarClienteResponse retVal = ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).insertarCliente(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.insertarClienteResponse> LP2MegaAutos.ServicioCliente.ClienteWS.insertarClienteAsync(LP2MegaAutos.ServicioCliente.insertarClienteRequest request) {
            return base.Channel.insertarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.insertarClienteResponse> insertarClienteAsync(LP2MegaAutos.ServicioCliente.cliente objCliente) {
            LP2MegaAutos.ServicioCliente.insertarClienteRequest inValue = new LP2MegaAutos.ServicioCliente.insertarClienteRequest();
            inValue.objCliente = objCliente;
            return ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).insertarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioCliente.listarClientesResponse LP2MegaAutos.ServicioCliente.ClienteWS.listarClientes(LP2MegaAutos.ServicioCliente.listarClientesRequest request) {
            return base.Channel.listarClientes(request);
        }
        
        public LP2MegaAutos.ServicioCliente.cliente[] listarClientes() {
            LP2MegaAutos.ServicioCliente.listarClientesRequest inValue = new LP2MegaAutos.ServicioCliente.listarClientesRequest();
            LP2MegaAutos.ServicioCliente.listarClientesResponse retVal = ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).listarClientes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.listarClientesResponse> LP2MegaAutos.ServicioCliente.ClienteWS.listarClientesAsync(LP2MegaAutos.ServicioCliente.listarClientesRequest request) {
            return base.Channel.listarClientesAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.listarClientesResponse> listarClientesAsync() {
            LP2MegaAutos.ServicioCliente.listarClientesRequest inValue = new LP2MegaAutos.ServicioCliente.listarClientesRequest();
            return ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).listarClientesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioCliente.eliminarClienteResponse LP2MegaAutos.ServicioCliente.ClienteWS.eliminarCliente(LP2MegaAutos.ServicioCliente.eliminarClienteRequest request) {
            return base.Channel.eliminarCliente(request);
        }
        
        public int eliminarCliente(int idCliente) {
            LP2MegaAutos.ServicioCliente.eliminarClienteRequest inValue = new LP2MegaAutos.ServicioCliente.eliminarClienteRequest();
            inValue.idCliente = idCliente;
            LP2MegaAutos.ServicioCliente.eliminarClienteResponse retVal = ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).eliminarCliente(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.eliminarClienteResponse> LP2MegaAutos.ServicioCliente.ClienteWS.eliminarClienteAsync(LP2MegaAutos.ServicioCliente.eliminarClienteRequest request) {
            return base.Channel.eliminarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioCliente.eliminarClienteResponse> eliminarClienteAsync(int idCliente) {
            LP2MegaAutos.ServicioCliente.eliminarClienteRequest inValue = new LP2MegaAutos.ServicioCliente.eliminarClienteRequest();
            inValue.idCliente = idCliente;
            return ((LP2MegaAutos.ServicioCliente.ClienteWS)(this)).eliminarClienteAsync(inValue);
        }
    }
}
