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
        List<ePermisos?> prsIni;

        public pantallaAgregarPermisos()
        {
            InitializeComponent();

        }

        #region listaPermisos
        private void crearItemsListaPermisos()
        {
            quitarItemsLista();
            bool tieneAll = _usuario.permisos.Contains(ePermisos.All);
            foreach(ePermisos e in Enum.GetValues(typeof(ePermisos)))
            {
                if (e == ePermisos.All || e == ePermisos.Drivers) continue; 
                itemListaCuadrado il = crearitemListaPermiso(e.ToString(), e);
                il.Seleccionado = false;
                if (tieneAll || _usuario.permisos.Contains(e)) il.Seleccionado = true;
                BotonesDinamicosHelper.agregarImgFondo(e, il);
                flpPermisos.Controls.Add(il);
            }
        }

        private void quitarItemsLista()
        {
            for (int i = 0; i < flpPermisos.Controls.Count;)
                flpPermisos.Controls.RemoveAt(i);
        }

        private int i = 1;
        private itemListaCuadrado crearitemListaPermiso(string nom, ePermisos per)
        {
            itemListaCuadrado il = new itemListaCuadrado();
            il.Name = "ilc" + i++;
            il.TextoPrincipal = nom;
            il.Anchor = AnchorStyles.None;
            il.ItemListaClick += (sender, e) => clickItemListaPermiso(sender, e, per);
            return il;
        }

        private void clickItemListaPermiso(object sender, EventArgs e, ePermisos per)
        {
            bool sel = ((itemListaCuadrado)sender).Seleccionado = !((itemListaCuadrado)sender).Seleccionado;
            // Agregar o quitar el permiso a la lista del usuario:
            List<ePermisos?> p = _usuario.permisos.ToList();
            if (sel)
                p.Add(per);
            else
                p.Remove(per);
            _usuario.permisos = p.ToArray();
        }
        #endregion listaPermisos

        public pantallaAgregarPermisos(ServicioUsuario.usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            crearItemsListaPermisos();
            List<ePermisos?> prs = prsIni = _usuario.permisos.ToList();
            prs.Remove(ePermisos.All);
            _usuario.permisos = prs.ToArray();
            if (DarkMode.is_dark_mode_active()) DarkMode.iniciarSinTimer(this);
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            _usuario.permisos = prsIni.ToArray();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool sel = true;
            for (int i = 0; i < flpPermisos.Controls.Count; i++)
                sel &= ((itemListaCuadrado)flpPermisos.Controls[i]).Seleccionado;

            // Si tiene todos los permisos
            if (sel)
            {
                List<ePermisos?> prs = new List<ePermisos?>();
                prs.Add(ePermisos.All);
                _usuario.permisos = prs.ToArray();
            }

            this.DialogResult = DialogResult.OK;
        }

        public usuario Usuario { get {return _usuario ; } }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flpPermisos.Controls.Count;i++)
                ((itemListaCuadrado)flpPermisos.Controls[i]).Seleccionado = true;
        }

        private void btnNinguno_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flpPermisos.Controls.Count; i++)
                ((itemListaCuadrado)flpPermisos.Controls[i]).Seleccionado = false;
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            _usuario.permisos = prsIni.ToArray();
            crearItemsListaPermisos();
        }
    }
}
