﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2MegaAutos.ServicioUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.megaautos.com.pe/", ConfigurationName="ServicioUsuario.UsuarioWS")]
    public interface UsuarioWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/verificarPasswordRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/verificarPasswordResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioUsuario.verificarPasswordResponse verificarPassword(LP2MegaAutos.ServicioUsuario.verificarPasswordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/verificarPasswordRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/verificarPasswordResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.verificarPasswordResponse> verificarPasswordAsync(LP2MegaAutos.ServicioUsuario.verificarPasswordRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/actualizarUsuarioRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/actualizarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioUsuario.actualizarUsuarioResponse actualizarUsuario(LP2MegaAutos.ServicioUsuario.actualizarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/actualizarUsuarioRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/actualizarUsuarioResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.actualizarUsuarioResponse> actualizarUsuarioAsync(LP2MegaAutos.ServicioUsuario.actualizarUsuarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/eliminarUsuarioRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/eliminarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioUsuario.eliminarUsuarioResponse eliminarUsuario(LP2MegaAutos.ServicioUsuario.eliminarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/eliminarUsuarioRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/eliminarUsuarioResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.eliminarUsuarioResponse> eliminarUsuarioAsync(LP2MegaAutos.ServicioUsuario.eliminarUsuarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/buscarPorCorreoRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/buscarPorCorreoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioUsuario.buscarPorCorreoResponse buscarPorCorreo(LP2MegaAutos.ServicioUsuario.buscarPorCorreoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/buscarPorCorreoRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/buscarPorCorreoResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.buscarPorCorreoResponse> buscarPorCorreoAsync(LP2MegaAutos.ServicioUsuario.buscarPorCorreoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/insertarUsuarioRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/insertarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioUsuario.insertarUsuarioResponse insertarUsuario(LP2MegaAutos.ServicioUsuario.insertarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/insertarUsuarioRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/insertarUsuarioResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.insertarUsuarioResponse> insertarUsuarioAsync(LP2MegaAutos.ServicioUsuario.insertarUsuarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/listarUsuariosRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/listarUsuariosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LP2MegaAutos.ServicioUsuario.listarUsuariosResponse listarUsuarios(LP2MegaAutos.ServicioUsuario.listarUsuariosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.megaautos.com.pe/UsuarioWS/listarUsuariosRequest", ReplyAction="http://services.megaautos.com.pe/UsuarioWS/listarUsuariosResponse")]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.listarUsuariosResponse> listarUsuariosAsync(LP2MegaAutos.ServicioUsuario.listarUsuariosRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.megaautos.com.pe/")]
    public partial class usuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private System.DateTime fechaCreadoField;
        
        private bool fechaCreadoFieldSpecified;
        
        private int idField;
        
        private string nombreField;
        
        private string passwordField;
        
        private System.Nullable<ePermisos>[] permisosField;
        
        private string tipoUsuarioField;
        
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
        public System.DateTime fechaCreado {
            get {
                return this.fechaCreadoField;
            }
            set {
                this.fechaCreadoField = value;
                this.RaisePropertyChanged("fechaCreado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaCreadoSpecified {
            get {
                return this.fechaCreadoFieldSpecified;
            }
            set {
                this.fechaCreadoFieldSpecified = value;
                this.RaisePropertyChanged("fechaCreadoSpecified");
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
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("permisos", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=5)]
        public System.Nullable<ePermisos>[] permisos {
            get {
                return this.permisosField;
            }
            set {
                this.permisosField = value;
                this.RaisePropertyChanged("permisos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string tipoUsuario {
            get {
                return this.tipoUsuarioField;
            }
            set {
                this.tipoUsuarioField = value;
                this.RaisePropertyChanged("tipoUsuario");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.megaautos.com.pe/")]
    public enum ePermisos {
        
        /// <remarks/>
        AreasTrabajo,
        
        /// <remarks/>
        Clientes,
        
        /// <remarks/>
        Vehiculos,
        
        /// <remarks/>
        Drivers,
        
        /// <remarks/>
        Usuarios,
        
        /// <remarks/>
        Servicios,
        
        /// <remarks/>
        Sedes,
        
        /// <remarks/>
        Empresa,
        
        /// <remarks/>
        ActualizarBD,
        
        /// <remarks/>
        All,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificarPassword", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class verificarPasswordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string correo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password;
        
        public verificarPasswordRequest() {
        }
        
        public verificarPasswordRequest(string correo, string password) {
            this.correo = correo;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="verificarPasswordResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class verificarPasswordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioUsuario.usuario @return;
        
        public verificarPasswordResponse() {
        }
        
        public verificarPasswordResponse(LP2MegaAutos.ServicioUsuario.usuario @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarUsuario", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioUsuario.usuario objUsuario;
        
        public actualizarUsuarioRequest() {
        }
        
        public actualizarUsuarioRequest(LP2MegaAutos.ServicioUsuario.usuario objUsuario) {
            this.objUsuario = objUsuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="actualizarUsuarioResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class actualizarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public actualizarUsuarioResponse() {
        }
        
        public actualizarUsuarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarUsuario", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idUsuario;
        
        public eliminarUsuarioRequest() {
        }
        
        public eliminarUsuarioRequest(int idUsuario) {
            this.idUsuario = idUsuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarUsuarioResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class eliminarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarUsuarioResponse() {
        }
        
        public eliminarUsuarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarPorCorreo", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class buscarPorCorreoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string correo;
        
        public buscarPorCorreoRequest() {
        }
        
        public buscarPorCorreoRequest(string correo) {
            this.correo = correo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarPorCorreoResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class buscarPorCorreoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioUsuario.usuario @return;
        
        public buscarPorCorreoResponse() {
        }
        
        public buscarPorCorreoResponse(LP2MegaAutos.ServicioUsuario.usuario @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarUsuario", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioUsuario.usuario objUsuario;
        
        public insertarUsuarioRequest() {
        }
        
        public insertarUsuarioRequest(LP2MegaAutos.ServicioUsuario.usuario objUsuario) {
            this.objUsuario = objUsuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarUsuarioResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class insertarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarUsuarioResponse() {
        }
        
        public insertarUsuarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarUsuarios", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarUsuariosRequest {
        
        public listarUsuariosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarUsuariosResponse", WrapperNamespace="http://services.megaautos.com.pe/", IsWrapped=true)]
    public partial class listarUsuariosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.megaautos.com.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LP2MegaAutos.ServicioUsuario.usuario[] @return;
        
        public listarUsuariosResponse() {
        }
        
        public listarUsuariosResponse(LP2MegaAutos.ServicioUsuario.usuario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UsuarioWSChannel : LP2MegaAutos.ServicioUsuario.UsuarioWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioWSClient : System.ServiceModel.ClientBase<LP2MegaAutos.ServicioUsuario.UsuarioWS>, LP2MegaAutos.ServicioUsuario.UsuarioWS {
        
        public UsuarioWSClient() {
        }
        
        public UsuarioWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioUsuario.verificarPasswordResponse LP2MegaAutos.ServicioUsuario.UsuarioWS.verificarPassword(LP2MegaAutos.ServicioUsuario.verificarPasswordRequest request) {
            return base.Channel.verificarPassword(request);
        }
        
        public LP2MegaAutos.ServicioUsuario.usuario verificarPassword(string correo, string password) {
            LP2MegaAutos.ServicioUsuario.verificarPasswordRequest inValue = new LP2MegaAutos.ServicioUsuario.verificarPasswordRequest();
            inValue.correo = correo;
            inValue.password = password;
            LP2MegaAutos.ServicioUsuario.verificarPasswordResponse retVal = ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).verificarPassword(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.verificarPasswordResponse> LP2MegaAutos.ServicioUsuario.UsuarioWS.verificarPasswordAsync(LP2MegaAutos.ServicioUsuario.verificarPasswordRequest request) {
            return base.Channel.verificarPasswordAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.verificarPasswordResponse> verificarPasswordAsync(string correo, string password) {
            LP2MegaAutos.ServicioUsuario.verificarPasswordRequest inValue = new LP2MegaAutos.ServicioUsuario.verificarPasswordRequest();
            inValue.correo = correo;
            inValue.password = password;
            return ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).verificarPasswordAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioUsuario.actualizarUsuarioResponse LP2MegaAutos.ServicioUsuario.UsuarioWS.actualizarUsuario(LP2MegaAutos.ServicioUsuario.actualizarUsuarioRequest request) {
            return base.Channel.actualizarUsuario(request);
        }
        
        public int actualizarUsuario(LP2MegaAutos.ServicioUsuario.usuario objUsuario) {
            LP2MegaAutos.ServicioUsuario.actualizarUsuarioRequest inValue = new LP2MegaAutos.ServicioUsuario.actualizarUsuarioRequest();
            inValue.objUsuario = objUsuario;
            LP2MegaAutos.ServicioUsuario.actualizarUsuarioResponse retVal = ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).actualizarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.actualizarUsuarioResponse> LP2MegaAutos.ServicioUsuario.UsuarioWS.actualizarUsuarioAsync(LP2MegaAutos.ServicioUsuario.actualizarUsuarioRequest request) {
            return base.Channel.actualizarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.actualizarUsuarioResponse> actualizarUsuarioAsync(LP2MegaAutos.ServicioUsuario.usuario objUsuario) {
            LP2MegaAutos.ServicioUsuario.actualizarUsuarioRequest inValue = new LP2MegaAutos.ServicioUsuario.actualizarUsuarioRequest();
            inValue.objUsuario = objUsuario;
            return ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).actualizarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioUsuario.eliminarUsuarioResponse LP2MegaAutos.ServicioUsuario.UsuarioWS.eliminarUsuario(LP2MegaAutos.ServicioUsuario.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuario(request);
        }
        
        public int eliminarUsuario(int idUsuario) {
            LP2MegaAutos.ServicioUsuario.eliminarUsuarioRequest inValue = new LP2MegaAutos.ServicioUsuario.eliminarUsuarioRequest();
            inValue.idUsuario = idUsuario;
            LP2MegaAutos.ServicioUsuario.eliminarUsuarioResponse retVal = ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).eliminarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.eliminarUsuarioResponse> LP2MegaAutos.ServicioUsuario.UsuarioWS.eliminarUsuarioAsync(LP2MegaAutos.ServicioUsuario.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.eliminarUsuarioResponse> eliminarUsuarioAsync(int idUsuario) {
            LP2MegaAutos.ServicioUsuario.eliminarUsuarioRequest inValue = new LP2MegaAutos.ServicioUsuario.eliminarUsuarioRequest();
            inValue.idUsuario = idUsuario;
            return ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).eliminarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioUsuario.buscarPorCorreoResponse LP2MegaAutos.ServicioUsuario.UsuarioWS.buscarPorCorreo(LP2MegaAutos.ServicioUsuario.buscarPorCorreoRequest request) {
            return base.Channel.buscarPorCorreo(request);
        }
        
        public LP2MegaAutos.ServicioUsuario.usuario buscarPorCorreo(string correo) {
            LP2MegaAutos.ServicioUsuario.buscarPorCorreoRequest inValue = new LP2MegaAutos.ServicioUsuario.buscarPorCorreoRequest();
            inValue.correo = correo;
            LP2MegaAutos.ServicioUsuario.buscarPorCorreoResponse retVal = ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).buscarPorCorreo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.buscarPorCorreoResponse> LP2MegaAutos.ServicioUsuario.UsuarioWS.buscarPorCorreoAsync(LP2MegaAutos.ServicioUsuario.buscarPorCorreoRequest request) {
            return base.Channel.buscarPorCorreoAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.buscarPorCorreoResponse> buscarPorCorreoAsync(string correo) {
            LP2MegaAutos.ServicioUsuario.buscarPorCorreoRequest inValue = new LP2MegaAutos.ServicioUsuario.buscarPorCorreoRequest();
            inValue.correo = correo;
            return ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).buscarPorCorreoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioUsuario.insertarUsuarioResponse LP2MegaAutos.ServicioUsuario.UsuarioWS.insertarUsuario(LP2MegaAutos.ServicioUsuario.insertarUsuarioRequest request) {
            return base.Channel.insertarUsuario(request);
        }
        
        public int insertarUsuario(LP2MegaAutos.ServicioUsuario.usuario objUsuario) {
            LP2MegaAutos.ServicioUsuario.insertarUsuarioRequest inValue = new LP2MegaAutos.ServicioUsuario.insertarUsuarioRequest();
            inValue.objUsuario = objUsuario;
            LP2MegaAutos.ServicioUsuario.insertarUsuarioResponse retVal = ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).insertarUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.insertarUsuarioResponse> LP2MegaAutos.ServicioUsuario.UsuarioWS.insertarUsuarioAsync(LP2MegaAutos.ServicioUsuario.insertarUsuarioRequest request) {
            return base.Channel.insertarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.insertarUsuarioResponse> insertarUsuarioAsync(LP2MegaAutos.ServicioUsuario.usuario objUsuario) {
            LP2MegaAutos.ServicioUsuario.insertarUsuarioRequest inValue = new LP2MegaAutos.ServicioUsuario.insertarUsuarioRequest();
            inValue.objUsuario = objUsuario;
            return ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).insertarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2MegaAutos.ServicioUsuario.listarUsuariosResponse LP2MegaAutos.ServicioUsuario.UsuarioWS.listarUsuarios(LP2MegaAutos.ServicioUsuario.listarUsuariosRequest request) {
            return base.Channel.listarUsuarios(request);
        }
        
        public LP2MegaAutos.ServicioUsuario.usuario[] listarUsuarios() {
            LP2MegaAutos.ServicioUsuario.listarUsuariosRequest inValue = new LP2MegaAutos.ServicioUsuario.listarUsuariosRequest();
            LP2MegaAutos.ServicioUsuario.listarUsuariosResponse retVal = ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).listarUsuarios(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.listarUsuariosResponse> LP2MegaAutos.ServicioUsuario.UsuarioWS.listarUsuariosAsync(LP2MegaAutos.ServicioUsuario.listarUsuariosRequest request) {
            return base.Channel.listarUsuariosAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2MegaAutos.ServicioUsuario.listarUsuariosResponse> listarUsuariosAsync() {
            LP2MegaAutos.ServicioUsuario.listarUsuariosRequest inValue = new LP2MegaAutos.ServicioUsuario.listarUsuariosRequest();
            return ((LP2MegaAutos.ServicioUsuario.UsuarioWS)(this)).listarUsuariosAsync(inValue);
        }
    }
}
