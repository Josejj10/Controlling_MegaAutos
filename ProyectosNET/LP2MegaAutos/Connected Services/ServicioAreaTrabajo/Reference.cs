﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2MegaAutos.ServicioAreaTrabajo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.megaautos.com.pe/", ConfigurationName="ServicioAreaTrabajo.AreaTrabajoWS")]
    public interface AreaTrabajoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/AreaTrabajoWS/eliminarAreaTrabajoRequest", ReplyAction="http://services.megaautos.com.pe/AreaTrabajoWS/eliminarAreaTrabajoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoResponse eliminarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/AreaTrabajoWS/eliminarAreaTrabajoRequest", ReplyAction="http://services.megaautos.com.pe/AreaTrabajoWS/eliminarAreaTrabajoResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoResponse> eliminarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/AreaTrabajoWS/insertarAreaTrabajoRequest", ReplyAction="http://services.megaautos.com.pe/AreaTrabajoWS/insertarAreaTrabajoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoResponse insertarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/AreaTrabajoWS/insertarAreaTrabajoRequest", ReplyAction="http://services.megaautos.com.pe/AreaTrabajoWS/insertarAreaTrabajoResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoResponse> insertarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/AreaTrabajoWS/listarAreaTrabajoRequest", ReplyAction="http://services.megaautos.com.pe/AreaTrabajoWS/listarAreaTrabajoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoResponse listarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/AreaTrabajoWS/listarAreaTrabajoRequest", ReplyAction="http://services.megaautos.com.pe/AreaTrabajoWS/listarAreaTrabajoResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoResponse> listarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/AreaTrabajoWS/actualizarAreaTrabajoRequest", ReplyAction="http://services.megaautos.com.pe/AreaTrabajoWS/actualizarAreaTrabajoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoResponse actualizarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/AreaTrabajoWS/actualizarAreaTrabajoRequest", ReplyAction="http://services.megaautos.com.pe/AreaTrabajoWS/actualizarAreaTrabajoResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoResponse> actualizarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarAreaTrabajo", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarAreaTrabajoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idAreaTrabajo;
        
        public eliminarAreaTrabajoRequest() {
        }
        
        public eliminarAreaTrabajoRequest(int idAreaTrabajo) {
            this.idAreaTrabajo = idAreaTrabajo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarAreaTrabajoResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarAreaTrabajoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarAreaTrabajoResponse() {
        }
        
        public eliminarAreaTrabajoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.megaautos.com.pe/")]
    public partial class areaTrabajo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nombreField;
        
        private double totalEgresosField;
        
        private bool totalEgresosFieldSpecified;
        
        private double totalIngresosField;
        
        private bool totalIngresosFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double totalEgresos {
            get {
                return this.totalEgresosField;
            }
            set {
                this.totalEgresosField = value;
                this.RaisePropertyChanged("totalEgresos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalEgresosSpecified {
            get {
                return this.totalEgresosFieldSpecified;
            }
            set {
                this.totalEgresosFieldSpecified = value;
                this.RaisePropertyChanged("totalEgresosSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double totalIngresos {
            get {
                return this.totalIngresosField;
            }
            set {
                this.totalIngresosField = value;
                this.RaisePropertyChanged("totalIngresos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalIngresosSpecified {
            get {
                return this.totalIngresosFieldSpecified;
            }
            set {
                this.totalIngresosFieldSpecified = value;
                this.RaisePropertyChanged("totalIngresosSpecified");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarAreaTrabajo", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarAreaTrabajoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo objAreaTrabajo;
        
        public insertarAreaTrabajoRequest() {
        }
        
        public insertarAreaTrabajoRequest(LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo objAreaTrabajo) {
            this.objAreaTrabajo = objAreaTrabajo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarAreaTrabajoResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarAreaTrabajoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarAreaTrabajoResponse() {
        }
        
        public insertarAreaTrabajoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarAreaTrabajo", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarAreaTrabajoRequest {
        
        public listarAreaTrabajoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarAreaTrabajoResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarAreaTrabajoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo[] @return;
        
        public listarAreaTrabajoResponse() {
        }
        
        public listarAreaTrabajoResponse(LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarAreaTrabajo", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarAreaTrabajoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo objAreaTrabajo;
        
        public actualizarAreaTrabajoRequest() {
        }
        
        public actualizarAreaTrabajoRequest(LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo objAreaTrabajo) {
            this.objAreaTrabajo = objAreaTrabajo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarAreaTrabajoResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarAreaTrabajoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarAreaTrabajoResponse() {
        }
        
        public actualizarAreaTrabajoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AreaTrabajoWSChannel : LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AreaTrabajoWSClient : System.ServiceModel.ClientBase<LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS>, LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS {
        
        public AreaTrabajoWSClient() {
        }
        
        public AreaTrabajoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AreaTrabajoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreaTrabajoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AreaTrabajoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoResponse LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS.eliminarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoRequest request) {
            return base.Channel.eliminarAreaTrabajo(request);
        }
        
        public int eliminarAreaTrabajo(int idAreaTrabajo) {
            LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoRequest inValue = new LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoRequest();
            inValue.idAreaTrabajo = idAreaTrabajo;
            LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoResponse retVal = ((LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS)(this)).eliminarAreaTrabajo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoResponse> LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS.eliminarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoRequest request) {
            return base.Channel.eliminarAreaTrabajoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoResponse> eliminarAreaTrabajoAsync(int idAreaTrabajo) {
            LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoRequest inValue = new LP2MegaAutos.ServicioAreaTrabajo.eliminarAreaTrabajoRequest();
            inValue.idAreaTrabajo = idAreaTrabajo;
            return ((LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS)(this)).eliminarAreaTrabajoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoResponse LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS.insertarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoRequest request) {
            return base.Channel.insertarAreaTrabajo(request);
        }
        
        public int insertarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo objAreaTrabajo) {
            LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoRequest inValue = new LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoRequest();
            inValue.objAreaTrabajo = objAreaTrabajo;
            LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoResponse retVal = ((LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS)(this)).insertarAreaTrabajo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoResponse> LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS.insertarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoRequest request) {
            return base.Channel.insertarAreaTrabajoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoResponse> insertarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo objAreaTrabajo) {
            LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoRequest inValue = new LP2MegaAutos.ServicioAreaTrabajo.insertarAreaTrabajoRequest();
            inValue.objAreaTrabajo = objAreaTrabajo;
            return ((LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS)(this)).insertarAreaTrabajoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoResponse LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS.listarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoRequest request) {
            return base.Channel.listarAreaTrabajo(request);
        }
        
        public LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo[] listarAreaTrabajo() {
            LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoRequest inValue = new LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoRequest();
            LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoResponse retVal = ((LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS)(this)).listarAreaTrabajo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoResponse> LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS.listarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoRequest request) {
            return base.Channel.listarAreaTrabajoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoResponse> listarAreaTrabajoAsync() {
            LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoRequest inValue = new LP2MegaAutos.ServicioAreaTrabajo.listarAreaTrabajoRequest();
            return ((LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS)(this)).listarAreaTrabajoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoResponse LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS.actualizarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoRequest request) {
            return base.Channel.actualizarAreaTrabajo(request);
        }
        
        public int actualizarAreaTrabajo(LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo objAreaTrabajo) {
            LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoRequest inValue = new LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoRequest();
            inValue.objAreaTrabajo = objAreaTrabajo;
            LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoResponse retVal = ((LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS)(this)).actualizarAreaTrabajo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoResponse> LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS.actualizarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoRequest request) {
            return base.Channel.actualizarAreaTrabajoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoResponse> actualizarAreaTrabajoAsync(LP2MegaAutos.ServicioAreaTrabajo.areaTrabajo objAreaTrabajo) {
            LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoRequest inValue = new LP2MegaAutos.ServicioAreaTrabajo.actualizarAreaTrabajoRequest();
            inValue.objAreaTrabajo = objAreaTrabajo;
            return ((LP2MegaAutos.ServicioAreaTrabajo.AreaTrabajoWS)(this)).actualizarAreaTrabajoAsync(inValue);
        }
    }
}
