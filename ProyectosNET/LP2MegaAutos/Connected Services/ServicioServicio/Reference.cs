﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2MegaAutos.ServicioServicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.megaautos.com.pe/", ConfigurationName="ServicioServicio.ServicioWS")]
    public interface ServicioWS {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ServicioWS/eliminarServicioRequest", ReplyAction="http://services.megaautos.com.pe/ServicioWS/eliminarServicioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioServicio.eliminarServicioResponse eliminarServicio(LP2MegaAutos.ServicioServicio.eliminarServicioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ServicioWS/eliminarServicioRequest", ReplyAction="http://services.megaautos.com.pe/ServicioWS/eliminarServicioResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.eliminarServicioResponse> eliminarServicioAsync(LP2MegaAutos.ServicioServicio.eliminarServicioRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ServicioWS/listarServiciosRequest", ReplyAction="http://services.megaautos.com.pe/ServicioWS/listarServiciosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioServicio.listarServiciosResponse listarServicios(LP2MegaAutos.ServicioServicio.listarServiciosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ServicioWS/listarServiciosRequest", ReplyAction="http://services.megaautos.com.pe/ServicioWS/listarServiciosResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.listarServiciosResponse> listarServiciosAsync(LP2MegaAutos.ServicioServicio.listarServiciosRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ServicioWS/insertarServicioRequest", ReplyAction="http://services.megaautos.com.pe/ServicioWS/insertarServicioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioServicio.insertarServicioResponse insertarServicio(LP2MegaAutos.ServicioServicio.insertarServicioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ServicioWS/insertarServicioRequest", ReplyAction="http://services.megaautos.com.pe/ServicioWS/insertarServicioResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.insertarServicioResponse> insertarServicioAsync(LP2MegaAutos.ServicioServicio.insertarServicioRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ServicioWS/actualizarServicioRequest", ReplyAction="http://services.megaautos.com.pe/ServicioWS/actualizarServicioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioServicio.actualizarServicioResponse actualizarServicio(LP2MegaAutos.ServicioServicio.actualizarServicioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/ServicioWS/actualizarServicioRequest", ReplyAction="http://services.megaautos.com.pe/ServicioWS/actualizarServicioResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.actualizarServicioResponse> actualizarServicioAsync(LP2MegaAutos.ServicioServicio.actualizarServicioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarServicio", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarServicioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idServicio;
        
        public eliminarServicioRequest() {
        }
        
        public eliminarServicioRequest(int idServicio) {
            this.idServicio = idServicio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarServicioResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarServicioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarServicioResponse() {
        }
        
        public eliminarServicioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.megaautos.com.pe/")]
    public partial class servicio : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codigoServicioField;
        
        private string descripcionField;
        
        private int idField;
        
        private string nombreField;
        
        private string tipoServicioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigoServicio {
            get {
                return this.codigoServicioField;
            }
            set {
                this.codigoServicioField = value;
                this.RaisePropertyChanged("codigoServicio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
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
        public string tipoServicio {
            get {
                return this.tipoServicioField;
            }
            set {
                this.tipoServicioField = value;
                this.RaisePropertyChanged("tipoServicio");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarServicios", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarServiciosRequest {
        
        public listarServiciosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarServiciosResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarServiciosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioServicio.servicio[] @return;
        
        public listarServiciosResponse() {
        }
        
        public listarServiciosResponse(LP2MegaAutos.ServicioServicio.servicio[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarServicio", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarServicioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioServicio.servicio objServicio;
        
        public insertarServicioRequest() {
        }
        
        public insertarServicioRequest(LP2MegaAutos.ServicioServicio.servicio objServicio) {
            this.objServicio = objServicio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarServicioResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarServicioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarServicioResponse() {
        }
        
        public insertarServicioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarServicio", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarServicioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioServicio.servicio objServicio;
        
        public actualizarServicioRequest() {
        }
        
        public actualizarServicioRequest(LP2MegaAutos.ServicioServicio.servicio objServicio) {
            this.objServicio = objServicio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarServicioResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarServicioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarServicioResponse() {
        }
        
        public actualizarServicioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioWSChannel : LP2MegaAutos.ServicioServicio.ServicioWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioWSClient : System.ServiceModel.ClientBase<LP2MegaAutos.ServicioServicio.ServicioWS>, LP2MegaAutos.ServicioServicio.ServicioWS {
        
        public ServicioWSClient() {
        }
        
        public ServicioWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioServicio.eliminarServicioResponse LP2MegaAutos.ServicioServicio.ServicioWS.eliminarServicio(LP2MegaAutos.ServicioServicio.eliminarServicioRequest request) {
            return base.Channel.eliminarServicio(request);
        }
        
        public int eliminarServicio(int idServicio) {
            LP2MegaAutos.ServicioServicio.eliminarServicioRequest inValue = new LP2MegaAutos.ServicioServicio.eliminarServicioRequest();
            inValue.idServicio = idServicio;
            LP2MegaAutos.ServicioServicio.eliminarServicioResponse retVal = ((LP2MegaAutos.ServicioServicio.ServicioWS)(this)).eliminarServicio(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.eliminarServicioResponse> LP2MegaAutos.ServicioServicio.ServicioWS.eliminarServicioAsync(LP2MegaAutos.ServicioServicio.eliminarServicioRequest request) {
            return base.Channel.eliminarServicioAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.eliminarServicioResponse> eliminarServicioAsync(int idServicio) {
            LP2MegaAutos.ServicioServicio.eliminarServicioRequest inValue = new LP2MegaAutos.ServicioServicio.eliminarServicioRequest();
            inValue.idServicio = idServicio;
            return ((LP2MegaAutos.ServicioServicio.ServicioWS)(this)).eliminarServicioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioServicio.listarServiciosResponse LP2MegaAutos.ServicioServicio.ServicioWS.listarServicios(LP2MegaAutos.ServicioServicio.listarServiciosRequest request) {
            return base.Channel.listarServicios(request);
        }
        
        public LP2MegaAutos.ServicioServicio.servicio[] listarServicios() {
            LP2MegaAutos.ServicioServicio.listarServiciosRequest inValue = new LP2MegaAutos.ServicioServicio.listarServiciosRequest();
            LP2MegaAutos.ServicioServicio.listarServiciosResponse retVal = ((LP2MegaAutos.ServicioServicio.ServicioWS)(this)).listarServicios(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.listarServiciosResponse> LP2MegaAutos.ServicioServicio.ServicioWS.listarServiciosAsync(LP2MegaAutos.ServicioServicio.listarServiciosRequest request) {
            return base.Channel.listarServiciosAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.listarServiciosResponse> listarServiciosAsync() {
            LP2MegaAutos.ServicioServicio.listarServiciosRequest inValue = new LP2MegaAutos.ServicioServicio.listarServiciosRequest();
            return ((LP2MegaAutos.ServicioServicio.ServicioWS)(this)).listarServiciosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioServicio.insertarServicioResponse LP2MegaAutos.ServicioServicio.ServicioWS.insertarServicio(LP2MegaAutos.ServicioServicio.insertarServicioRequest request) {
            return base.Channel.insertarServicio(request);
        }
        
        public int insertarServicio(LP2MegaAutos.ServicioServicio.servicio objServicio) {
            LP2MegaAutos.ServicioServicio.insertarServicioRequest inValue = new LP2MegaAutos.ServicioServicio.insertarServicioRequest();
            inValue.objServicio = objServicio;
            LP2MegaAutos.ServicioServicio.insertarServicioResponse retVal = ((LP2MegaAutos.ServicioServicio.ServicioWS)(this)).insertarServicio(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.insertarServicioResponse> LP2MegaAutos.ServicioServicio.ServicioWS.insertarServicioAsync(LP2MegaAutos.ServicioServicio.insertarServicioRequest request) {
            return base.Channel.insertarServicioAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.insertarServicioResponse> insertarServicioAsync(LP2MegaAutos.ServicioServicio.servicio objServicio) {
            LP2MegaAutos.ServicioServicio.insertarServicioRequest inValue = new LP2MegaAutos.ServicioServicio.insertarServicioRequest();
            inValue.objServicio = objServicio;
            return ((LP2MegaAutos.ServicioServicio.ServicioWS)(this)).insertarServicioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioServicio.actualizarServicioResponse LP2MegaAutos.ServicioServicio.ServicioWS.actualizarServicio(LP2MegaAutos.ServicioServicio.actualizarServicioRequest request) {
            return base.Channel.actualizarServicio(request);
        }
        
        public int actualizarServicio(LP2MegaAutos.ServicioServicio.servicio objServicio) {
            LP2MegaAutos.ServicioServicio.actualizarServicioRequest inValue = new LP2MegaAutos.ServicioServicio.actualizarServicioRequest();
            inValue.objServicio = objServicio;
            LP2MegaAutos.ServicioServicio.actualizarServicioResponse retVal = ((LP2MegaAutos.ServicioServicio.ServicioWS)(this)).actualizarServicio(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.actualizarServicioResponse> LP2MegaAutos.ServicioServicio.ServicioWS.actualizarServicioAsync(LP2MegaAutos.ServicioServicio.actualizarServicioRequest request) {
            return base.Channel.actualizarServicioAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioServicio.actualizarServicioResponse> actualizarServicioAsync(LP2MegaAutos.ServicioServicio.servicio objServicio) {
            LP2MegaAutos.ServicioServicio.actualizarServicioRequest inValue = new LP2MegaAutos.ServicioServicio.actualizarServicioRequest();
            inValue.objServicio = objServicio;
            return ((LP2MegaAutos.ServicioServicio.ServicioWS)(this)).actualizarServicioAsync(inValue);
        }
    }
}
