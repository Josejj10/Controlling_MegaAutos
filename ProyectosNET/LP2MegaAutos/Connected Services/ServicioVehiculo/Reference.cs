﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2MegaAutos.ServicioVehiculo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.megaautos.com.pe/", ConfigurationName="ServicioVehiculo.VehiculoWS")]
    public interface VehiculoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/VehiculoWS/actualizarVehiculoRequest", ReplyAction="http://services.megaautos.com.pe/VehiculoWS/actualizarVehiculoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioVehiculo.actualizarVehiculoResponse actualizarVehiculo(LP2MegaAutos.ServicioVehiculo.actualizarVehiculoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/VehiculoWS/actualizarVehiculoRequest", ReplyAction="http://services.megaautos.com.pe/VehiculoWS/actualizarVehiculoResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.actualizarVehiculoResponse> actualizarVehiculoAsync(LP2MegaAutos.ServicioVehiculo.actualizarVehiculoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/VehiculoWS/eliminarVehiculoRequest", ReplyAction="http://services.megaautos.com.pe/VehiculoWS/eliminarVehiculoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioVehiculo.eliminarVehiculoResponse eliminarVehiculo(LP2MegaAutos.ServicioVehiculo.eliminarVehiculoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/VehiculoWS/eliminarVehiculoRequest", ReplyAction="http://services.megaautos.com.pe/VehiculoWS/eliminarVehiculoResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.eliminarVehiculoResponse> eliminarVehiculoAsync(LP2MegaAutos.ServicioVehiculo.eliminarVehiculoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/VehiculoWS/listarVehiculosRequest", ReplyAction="http://services.megaautos.com.pe/VehiculoWS/listarVehiculosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioVehiculo.listarVehiculosResponse listarVehiculos(LP2MegaAutos.ServicioVehiculo.listarVehiculosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/VehiculoWS/listarVehiculosRequest", ReplyAction="http://services.megaautos.com.pe/VehiculoWS/listarVehiculosResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.listarVehiculosResponse> listarVehiculosAsync(LP2MegaAutos.ServicioVehiculo.listarVehiculosRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/VehiculoWS/insertarVehiculoRequest", ReplyAction="http://services.megaautos.com.pe/VehiculoWS/insertarVehiculoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioVehiculo.insertarVehiculoResponse insertarVehiculo(LP2MegaAutos.ServicioVehiculo.insertarVehiculoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/VehiculoWS/insertarVehiculoRequest", ReplyAction="http://services.megaautos.com.pe/VehiculoWS/insertarVehiculoResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.insertarVehiculoResponse> insertarVehiculoAsync(LP2MegaAutos.ServicioVehiculo.insertarVehiculoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.megaautos.com.pe/")]
    public partial class vehiculo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string placaField;
        
        private cliente propietarioField;
        
        private string tipoVehiculoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string placa {
            get {
                return this.placaField;
            }
            set {
                this.placaField = value;
                this.RaisePropertyChanged("placa");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public cliente propietario {
            get {
                return this.propietarioField;
            }
            set {
                this.propietarioField = value;
                this.RaisePropertyChanged("propietario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string tipoVehiculo {
            get {
                return this.tipoVehiculoField;
            }
            set {
                this.tipoVehiculoField = value;
                this.RaisePropertyChanged("tipoVehiculo");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarVehiculo", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarVehiculoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioVehiculo.vehiculo objVehiculo;
        
        public actualizarVehiculoRequest() {
        }
        
        public actualizarVehiculoRequest(LP2MegaAutos.ServicioVehiculo.vehiculo objVehiculo) {
            this.objVehiculo = objVehiculo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarVehiculoResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarVehiculoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarVehiculoResponse() {
        }
        
        public actualizarVehiculoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarVehiculo", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarVehiculoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idVehiculo;
        
        public eliminarVehiculoRequest() {
        }
        
        public eliminarVehiculoRequest(int idVehiculo) {
            this.idVehiculo = idVehiculo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarVehiculoResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarVehiculoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarVehiculoResponse() {
        }
        
        public eliminarVehiculoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarVehiculos", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarVehiculosRequest {
        
        public listarVehiculosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarVehiculosResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarVehiculosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioVehiculo.vehiculo[] @return;
        
        public listarVehiculosResponse() {
        }
        
        public listarVehiculosResponse(LP2MegaAutos.ServicioVehiculo.vehiculo[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarVehiculo", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarVehiculoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioVehiculo.vehiculo objVehiculo;
        
        public insertarVehiculoRequest() {
        }
        
        public insertarVehiculoRequest(LP2MegaAutos.ServicioVehiculo.vehiculo objVehiculo) {
            this.objVehiculo = objVehiculo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarVehiculoResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarVehiculoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarVehiculoResponse() {
        }
        
        public insertarVehiculoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface VehiculoWSChannel : LP2MegaAutos.ServicioVehiculo.VehiculoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VehiculoWSClient : System.ServiceModel.ClientBase<LP2MegaAutos.ServicioVehiculo.VehiculoWS>, LP2MegaAutos.ServicioVehiculo.VehiculoWS {
        
        public VehiculoWSClient() {
        }
        
        public VehiculoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VehiculoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehiculoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VehiculoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioVehiculo.actualizarVehiculoResponse LP2MegaAutos.ServicioVehiculo.VehiculoWS.actualizarVehiculo(LP2MegaAutos.ServicioVehiculo.actualizarVehiculoRequest request) {
            return base.Channel.actualizarVehiculo(request);
        }
        
        public int actualizarVehiculo(LP2MegaAutos.ServicioVehiculo.vehiculo objVehiculo) {
            LP2MegaAutos.ServicioVehiculo.actualizarVehiculoRequest inValue = new LP2MegaAutos.ServicioVehiculo.actualizarVehiculoRequest();
            inValue.objVehiculo = objVehiculo;
            LP2MegaAutos.ServicioVehiculo.actualizarVehiculoResponse retVal = ((LP2MegaAutos.ServicioVehiculo.VehiculoWS)(this)).actualizarVehiculo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.actualizarVehiculoResponse> LP2MegaAutos.ServicioVehiculo.VehiculoWS.actualizarVehiculoAsync(LP2MegaAutos.ServicioVehiculo.actualizarVehiculoRequest request) {
            return base.Channel.actualizarVehiculoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.actualizarVehiculoResponse> actualizarVehiculoAsync(LP2MegaAutos.ServicioVehiculo.vehiculo objVehiculo) {
            LP2MegaAutos.ServicioVehiculo.actualizarVehiculoRequest inValue = new LP2MegaAutos.ServicioVehiculo.actualizarVehiculoRequest();
            inValue.objVehiculo = objVehiculo;
            return ((LP2MegaAutos.ServicioVehiculo.VehiculoWS)(this)).actualizarVehiculoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioVehiculo.eliminarVehiculoResponse LP2MegaAutos.ServicioVehiculo.VehiculoWS.eliminarVehiculo(LP2MegaAutos.ServicioVehiculo.eliminarVehiculoRequest request) {
            return base.Channel.eliminarVehiculo(request);
        }
        
        public int eliminarVehiculo(int idVehiculo) {
            LP2MegaAutos.ServicioVehiculo.eliminarVehiculoRequest inValue = new LP2MegaAutos.ServicioVehiculo.eliminarVehiculoRequest();
            inValue.idVehiculo = idVehiculo;
            LP2MegaAutos.ServicioVehiculo.eliminarVehiculoResponse retVal = ((LP2MegaAutos.ServicioVehiculo.VehiculoWS)(this)).eliminarVehiculo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.eliminarVehiculoResponse> LP2MegaAutos.ServicioVehiculo.VehiculoWS.eliminarVehiculoAsync(LP2MegaAutos.ServicioVehiculo.eliminarVehiculoRequest request) {
            return base.Channel.eliminarVehiculoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.eliminarVehiculoResponse> eliminarVehiculoAsync(int idVehiculo) {
            LP2MegaAutos.ServicioVehiculo.eliminarVehiculoRequest inValue = new LP2MegaAutos.ServicioVehiculo.eliminarVehiculoRequest();
            inValue.idVehiculo = idVehiculo;
            return ((LP2MegaAutos.ServicioVehiculo.VehiculoWS)(this)).eliminarVehiculoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioVehiculo.listarVehiculosResponse LP2MegaAutos.ServicioVehiculo.VehiculoWS.listarVehiculos(LP2MegaAutos.ServicioVehiculo.listarVehiculosRequest request) {
            return base.Channel.listarVehiculos(request);
        }
        
        public LP2MegaAutos.ServicioVehiculo.vehiculo[] listarVehiculos() {
            LP2MegaAutos.ServicioVehiculo.listarVehiculosRequest inValue = new LP2MegaAutos.ServicioVehiculo.listarVehiculosRequest();
            LP2MegaAutos.ServicioVehiculo.listarVehiculosResponse retVal = ((LP2MegaAutos.ServicioVehiculo.VehiculoWS)(this)).listarVehiculos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.listarVehiculosResponse> LP2MegaAutos.ServicioVehiculo.VehiculoWS.listarVehiculosAsync(LP2MegaAutos.ServicioVehiculo.listarVehiculosRequest request) {
            return base.Channel.listarVehiculosAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.listarVehiculosResponse> listarVehiculosAsync() {
            LP2MegaAutos.ServicioVehiculo.listarVehiculosRequest inValue = new LP2MegaAutos.ServicioVehiculo.listarVehiculosRequest();
            return ((LP2MegaAutos.ServicioVehiculo.VehiculoWS)(this)).listarVehiculosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioVehiculo.insertarVehiculoResponse LP2MegaAutos.ServicioVehiculo.VehiculoWS.insertarVehiculo(LP2MegaAutos.ServicioVehiculo.insertarVehiculoRequest request) {
            return base.Channel.insertarVehiculo(request);
        }
        
        public int insertarVehiculo(LP2MegaAutos.ServicioVehiculo.vehiculo objVehiculo) {
            LP2MegaAutos.ServicioVehiculo.insertarVehiculoRequest inValue = new LP2MegaAutos.ServicioVehiculo.insertarVehiculoRequest();
            inValue.objVehiculo = objVehiculo;
            LP2MegaAutos.ServicioVehiculo.insertarVehiculoResponse retVal = ((LP2MegaAutos.ServicioVehiculo.VehiculoWS)(this)).insertarVehiculo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.insertarVehiculoResponse> LP2MegaAutos.ServicioVehiculo.VehiculoWS.insertarVehiculoAsync(LP2MegaAutos.ServicioVehiculo.insertarVehiculoRequest request) {
            return base.Channel.insertarVehiculoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioVehiculo.insertarVehiculoResponse> insertarVehiculoAsync(LP2MegaAutos.ServicioVehiculo.vehiculo objVehiculo) {
            LP2MegaAutos.ServicioVehiculo.insertarVehiculoRequest inValue = new LP2MegaAutos.ServicioVehiculo.insertarVehiculoRequest();
            inValue.objVehiculo = objVehiculo;
            return ((LP2MegaAutos.ServicioVehiculo.VehiculoWS)(this)).insertarVehiculoAsync(inValue);
        }
    }
}
