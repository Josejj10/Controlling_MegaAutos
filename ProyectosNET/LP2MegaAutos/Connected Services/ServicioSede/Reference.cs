﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2MegaAutos.ServicioSede {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.megaautos.com.pe/", ConfigurationName="ServicioSede.SedeWS")]
    public interface SedeWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/SedeWS/eliminarSedeRequest", ReplyAction="http://services.megaautos.com.pe/SedeWS/eliminarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioSede.eliminarSedeResponse eliminarSede(LP2MegaAutos.ServicioSede.eliminarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/SedeWS/eliminarSedeRequest", ReplyAction="http://services.megaautos.com.pe/SedeWS/eliminarSedeResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.eliminarSedeResponse> eliminarSedeAsync(LP2MegaAutos.ServicioSede.eliminarSedeRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/SedeWS/listarSedesRequest", ReplyAction="http://services.megaautos.com.pe/SedeWS/listarSedesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioSede.listarSedesResponse listarSedes(LP2MegaAutos.ServicioSede.listarSedesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/SedeWS/listarSedesRequest", ReplyAction="http://services.megaautos.com.pe/SedeWS/listarSedesResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.listarSedesResponse> listarSedesAsync(LP2MegaAutos.ServicioSede.listarSedesRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/SedeWS/actualizarSedeRequest", ReplyAction="http://services.megaautos.com.pe/SedeWS/actualizarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioSede.actualizarSedeResponse actualizarSede(LP2MegaAutos.ServicioSede.actualizarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/SedeWS/actualizarSedeRequest", ReplyAction="http://services.megaautos.com.pe/SedeWS/actualizarSedeResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.actualizarSedeResponse> actualizarSedeAsync(LP2MegaAutos.ServicioSede.actualizarSedeRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/SedeWS/insertarSedeRequest", ReplyAction="http://services.megaautos.com.pe/SedeWS/insertarSedeResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioSede.insertarSedeResponse insertarSede(LP2MegaAutos.ServicioSede.insertarSedeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/SedeWS/insertarSedeRequest", ReplyAction="http://services.megaautos.com.pe/SedeWS/insertarSedeResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.insertarSedeResponse> insertarSedeAsync(LP2MegaAutos.ServicioSede.insertarSedeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarSede", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarSedeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idSede;
        
        public eliminarSedeRequest() {
        }
        
        public eliminarSedeRequest(int idSede) {
            this.idSede = idSede;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarSedeResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarSedeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarSedeResponse() {
        }
        
        public eliminarSedeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.megaautos.com.pe/")]
    public partial class sede : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string direccionField;
        
        private string distritoField;
        
        private int idField;
        
        private string nombreField;
        
        private string telefonoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string distrito {
            get {
                return this.distritoField;
            }
            set {
                this.distritoField = value;
                this.RaisePropertyChanged("distrito");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarSedes", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarSedesRequest {
        
        public listarSedesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarSedesResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarSedesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioSede.sede[] @return;
        
        public listarSedesResponse() {
        }
        
        public listarSedesResponse(LP2MegaAutos.ServicioSede.sede[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarSede", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarSedeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioSede.sede objSede;
        
        public actualizarSedeRequest() {
        }
        
        public actualizarSedeRequest(LP2MegaAutos.ServicioSede.sede objSede) {
            this.objSede = objSede;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarSedeResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarSedeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarSedeResponse() {
        }
        
        public actualizarSedeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarSede", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarSedeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioSede.sede objSede;
        
        public insertarSedeRequest() {
        }
        
        public insertarSedeRequest(LP2MegaAutos.ServicioSede.sede objSede) {
            this.objSede = objSede;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarSedeResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarSedeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarSedeResponse() {
        }
        
        public insertarSedeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SedeWSChannel : LP2MegaAutos.ServicioSede.SedeWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SedeWSClient : System.ServiceModel.ClientBase<LP2MegaAutos.ServicioSede.SedeWS>, LP2MegaAutos.ServicioSede.SedeWS {
        
        public SedeWSClient() {
        }
        
        public SedeWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SedeWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SedeWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SedeWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioSede.eliminarSedeResponse LP2MegaAutos.ServicioSede.SedeWS.eliminarSede(LP2MegaAutos.ServicioSede.eliminarSedeRequest request) {
            return base.Channel.eliminarSede(request);
        }
        
        public int eliminarSede(int idSede) {
            LP2MegaAutos.ServicioSede.eliminarSedeRequest inValue = new LP2MegaAutos.ServicioSede.eliminarSedeRequest();
            inValue.idSede = idSede;
            LP2MegaAutos.ServicioSede.eliminarSedeResponse retVal = ((LP2MegaAutos.ServicioSede.SedeWS)(this)).eliminarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.eliminarSedeResponse> LP2MegaAutos.ServicioSede.SedeWS.eliminarSedeAsync(LP2MegaAutos.ServicioSede.eliminarSedeRequest request) {
            return base.Channel.eliminarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.eliminarSedeResponse> eliminarSedeAsync(int idSede) {
            LP2MegaAutos.ServicioSede.eliminarSedeRequest inValue = new LP2MegaAutos.ServicioSede.eliminarSedeRequest();
            inValue.idSede = idSede;
            return ((LP2MegaAutos.ServicioSede.SedeWS)(this)).eliminarSedeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioSede.listarSedesResponse LP2MegaAutos.ServicioSede.SedeWS.listarSedes(LP2MegaAutos.ServicioSede.listarSedesRequest request) {
            return base.Channel.listarSedes(request);
        }
        
        public LP2MegaAutos.ServicioSede.sede[] listarSedes() {
            LP2MegaAutos.ServicioSede.listarSedesRequest inValue = new LP2MegaAutos.ServicioSede.listarSedesRequest();
            LP2MegaAutos.ServicioSede.listarSedesResponse retVal = ((LP2MegaAutos.ServicioSede.SedeWS)(this)).listarSedes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.listarSedesResponse> LP2MegaAutos.ServicioSede.SedeWS.listarSedesAsync(LP2MegaAutos.ServicioSede.listarSedesRequest request) {
            return base.Channel.listarSedesAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.listarSedesResponse> listarSedesAsync() {
            LP2MegaAutos.ServicioSede.listarSedesRequest inValue = new LP2MegaAutos.ServicioSede.listarSedesRequest();
            return ((LP2MegaAutos.ServicioSede.SedeWS)(this)).listarSedesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioSede.actualizarSedeResponse LP2MegaAutos.ServicioSede.SedeWS.actualizarSede(LP2MegaAutos.ServicioSede.actualizarSedeRequest request) {
            return base.Channel.actualizarSede(request);
        }
        
        public int actualizarSede(LP2MegaAutos.ServicioSede.sede objSede) {
            LP2MegaAutos.ServicioSede.actualizarSedeRequest inValue = new LP2MegaAutos.ServicioSede.actualizarSedeRequest();
            inValue.objSede = objSede;
            LP2MegaAutos.ServicioSede.actualizarSedeResponse retVal = ((LP2MegaAutos.ServicioSede.SedeWS)(this)).actualizarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.actualizarSedeResponse> LP2MegaAutos.ServicioSede.SedeWS.actualizarSedeAsync(LP2MegaAutos.ServicioSede.actualizarSedeRequest request) {
            return base.Channel.actualizarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.actualizarSedeResponse> actualizarSedeAsync(LP2MegaAutos.ServicioSede.sede objSede) {
            LP2MegaAutos.ServicioSede.actualizarSedeRequest inValue = new LP2MegaAutos.ServicioSede.actualizarSedeRequest();
            inValue.objSede = objSede;
            return ((LP2MegaAutos.ServicioSede.SedeWS)(this)).actualizarSedeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioSede.insertarSedeResponse LP2MegaAutos.ServicioSede.SedeWS.insertarSede(LP2MegaAutos.ServicioSede.insertarSedeRequest request) {
            return base.Channel.insertarSede(request);
        }
        
        public int insertarSede(LP2MegaAutos.ServicioSede.sede objSede) {
            LP2MegaAutos.ServicioSede.insertarSedeRequest inValue = new LP2MegaAutos.ServicioSede.insertarSedeRequest();
            inValue.objSede = objSede;
            LP2MegaAutos.ServicioSede.insertarSedeResponse retVal = ((LP2MegaAutos.ServicioSede.SedeWS)(this)).insertarSede(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.insertarSedeResponse> LP2MegaAutos.ServicioSede.SedeWS.insertarSedeAsync(LP2MegaAutos.ServicioSede.insertarSedeRequest request) {
            return base.Channel.insertarSedeAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioSede.insertarSedeResponse> insertarSedeAsync(LP2MegaAutos.ServicioSede.sede objSede) {
            LP2MegaAutos.ServicioSede.insertarSedeRequest inValue = new LP2MegaAutos.ServicioSede.insertarSedeRequest();
            inValue.objSede = objSede;
            return ((LP2MegaAutos.ServicioSede.SedeWS)(this)).insertarSedeAsync(inValue);
        }
    }
}
