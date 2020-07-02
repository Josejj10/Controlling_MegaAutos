using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using LP2MegaAutos.ServicioUsuario;
using LP2MegaAutos.ServicioDriver;
using LP2MegaAutos.VentanasPrincipales;

namespace LP2MegaAutos
{
    public partial class pantallaAgregarPermisos : MetroForm
    {

        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void boton_minimizar_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }
        #endregion botones

        #region movement
        // Llama a la clase estatica TitleBar
        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Up();
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Down(MousePosition, Bounds);
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            TitleBar.mouse_Move(MousePosition, this);
        }

        #endregion movement

        #endregion title_bar
        
        private usuario _usuario;

        public pantallaAgregarPermisos()
        {
            InitializeComponent();

        }

        public pantallaAgregarPermisos(ServicioUsuario.usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            int i = 0;
            // TODO
            // Agregar item Lista Permisos
            // foreach(permiso p in _usuario.permisos)
            foreach (ePermisos e in Enum.GetValues(typeof(ePermisos)))
            {
                if (e == ePermisos.All) return;
                clbPermisos.Items.Add(e.ToString());
                if (_usuario.permisos != null)
                {
                    clbPermisos.SetItemChecked(i, _usuario.permisos.ToList().Contains(e));
                    i++;
                }
            }
            // if 
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna diferencia en los permisos del usuario 

            // Si no hay diferencia, 
                // this.DialogResult = DialogResult.OK
            
            // Si si hay diferencia
            
            // TODO pensar la logica para cuando se actualiza un usuario quitandole un permiso
            // Y el usuario tiene la aplicacion abierta 
            // Informarle que se cambiaron sus permisos y decirle que reinicie el programa(?

            // Preguntar si desea guardar los cambios
            if (MessageBox.Show("Guardar cambios?", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            // Los permisos del usuario ya estaran actualizados porque la 
            // pantalla agregar permiso lo actualizara
            this.DialogResult = DialogResult.OK;
        }

        public usuario Usuario { get {return _usuario ; } }

        private void btnAgregarPermisos_Click(object sender, EventArgs e)
        {
            // TODO crear Pantalla Agregar Permiso

        }
    }
}
