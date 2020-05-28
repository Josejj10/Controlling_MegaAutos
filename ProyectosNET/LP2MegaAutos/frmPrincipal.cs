using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Plasmoid.Extensions;

namespace LP2MegaAutos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            if (DarkMode.is_dark_mode_active())
            {
                DarkMode.iniciarDarkMode(panel_toggle_nocturno, boton_toggle_nocturno, reloj_dark, this);
            }
            Tipografias.crearFonts(this, tags); // Inicializa los fonts de este form
            cambiarColoresBotonesMenu(rpBtnMenuHome);

            // Suscribir a eventos de la pantalla de inicio
            //public event ButtonClickEventHandler DriversGerente;
            //public event ButtonClickEventHandler EmpresaGerente;
            //public event ButtonClickEventHandler ClientesGerente;
            //public event ButtonClickEventHandler UsuariosGerente;
            //public event ButtonClickEventHandler SedesGerente;
            //public event ButtonClickEventHandler ActualizarBDGerente;
            //public event ButtonClickEventHandler AjustesGerente;
            //public event ButtonClickEventHandler CerrarSesionGerente;
            pntIniGen.BienvenidoClickGerente += btnMenuAjustes_Click;
            pntIniGen.GenerarReporte += btnGenerarReporte_Click;
            pntIniGen.AreaTrabajoGerente += btnAreasTrabajo_Click;
            pntIniGen.ReportesGerente += btnMenuReportes_Click;
            pntIniGen.ServiciosGerente += btnServicios_Click;
            pntIniGen.DriversGerente += btnDrivers_Click;
            pntIniGen.EmpresaGerente += btnMenuEmpresa_Click;
            pntIniGen.ClientesGerente += btnClientes_Click;
            pntIniGen.UsuariosGerente += btnMenuUsuarios_Click;
            pntIniGen.SedesGerente += btnMenuSedes_Click;
            pntIniGen.ActualizarBDGerente += actualizarBD;
            pntIniGen.AjustesGerente += btnMenuAjustes_Click;
            pntIniGen.CerrarSesionGerente += btnMenuCerrarSesion_Click;
    }

        


        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void boton_minimizar_MouseClick(object sender, EventArgs e)
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


        #region Dark Mode
        // Usa la clase DarkMode para cambiar los colores iterando
        // Y mover el toggle mediante ticks del timer reloj_dark
        private void boton_toggle_nocturno_Click(object sender, EventArgs e)
        {
            DarkMode.cambiarDarkMode(panel_toggle_nocturno, boton_toggle_nocturno, reloj_dark, this);
        }

        private void reloj_dark_Tick(object sender, EventArgs e)
        {
            DarkMode.reloj_dark_Tick(reloj_dark, boton_toggle_nocturno);
        }




        #endregion Dark Mode

        #region panelMenu
        private void cambiarRPMenu(RoundedPanel rp)
        {
            rp.ColorPanel = Color.Transparent;
            foreach(Control btn in rp.Controls)
                btn.BackColor = Color.Transparent;
        }
        private void cambiarColoresBotonesMenu(RoundedPanel rp)
        {
            // Itera por todos los botones del panel del Menu y cambia los colores
            // A menos que sea el rp y btn enviados
            // Cambiar color rounded panels de atras

            foreach (Control c in panelMenu.Controls)
            {
                // Todos los controles que tiene son RoundedPanels, cambiar su color
                if (c == rp) continue;
                if (c is RoundedPanel) cambiarRPMenu((RoundedPanel)c);
                
            }
            if (DarkMode.is_dark_mode_active())
                rp.ColorPanel = Dark_Mode.BackBackground;
            else
                rp.ColorPanel = White_Mode.BackBackground;

        }

        #region botonesClick
        private void btnHome_Click(object sender, EventArgs e)
        {
            pntIniGen.BringToFront();
            // Cambiar los botones y rPanel
            cambiarColoresBotonesMenu(rpBtnMenuHome);
        }
        private void btnServicios_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaActualizarServicios.Instancia))
            {
                rpMain.Controls.Add(pantallaActualizarServicios.Instancia);
                pantallaActualizarServicios.Instancia.Dock = DockStyle.Fill;
                pantallaActualizarServicios.Instancia.BringToFront();
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaActualizarServicios.Instancia.Parent);
            }
            else
                pantallaActualizarServicios.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuServicios);
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaGenerarReporte.Instancia))
            {
                rpMain.Controls.Add(pantallaGenerarReporte.Instancia);
                pantallaGenerarReporte.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaGenerarReporte.Instancia.Parent);
            }
            pantallaGenerarReporte.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuGenerarReporte);
        }
        private void btnAreasTrabajo_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaAreaTrabajo.Instancia))
            {
                rpMain.Controls.Add(pantallaAreaTrabajo.Instancia);
                pantallaAreaTrabajo.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaAreaTrabajo.Instancia.Parent);
            }
            pantallaAreaTrabajo.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuAreasTrabajo);
        }
        private void btnDrivers_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaActualizarDrivers.Instancia))
            {
                rpMain.Controls.Add(pantallaActualizarDrivers.Instancia);
                pantallaActualizarDrivers.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaActualizarDrivers.Instancia.Parent);
            }
            pantallaActualizarDrivers.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuDrivers);
        }
        private void btnMenuEmpresa_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaInformacionEmpresaGerente.Instancia))
            {
                rpMain.Controls.Add(pantallaInformacionEmpresaGerente.Instancia);
                pantallaInformacionEmpresaGerente.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaInformacionEmpresaGerente.Instancia.Parent);
            }
            pantallaInformacionEmpresaGerente.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuEmpresa);
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaActualizarClientes.Instancia))
            {
                rpMain.Controls.Add(pantallaActualizarClientes.Instancia);
                pantallaActualizarClientes.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaActualizarClientes.Instancia.Parent);
            }
            pantallaActualizarClientes.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuClientes);
        }
        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaActualizarUsuarios.Instancia))
            {
                rpMain.Controls.Add(pantallaActualizarUsuarios.Instancia);
                pantallaActualizarUsuarios.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaActualizarUsuarios.Instancia.Parent);
            }
            pantallaActualizarUsuarios.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuUsuarios);
        }

        private void btnMenuSedes_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaActualizarSedes.Instancia))
            {
                rpMain.Controls.Add(pantallaActualizarSedes.Instancia);
                pantallaActualizarSedes.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaActualizarSedes.Instancia.Parent);
            }
            pantallaActualizarSedes.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuSedes);
        }
        private void btnMenuAjustes_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaAjustesGerente.Instancia))
            {
                rpMain.Controls.Add(pantallaAjustesGerente.Instancia);
                pantallaAjustesGerente.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaAjustesGerente.Instancia.Parent);
            }
            pantallaAjustesGerente.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuAjustes);
        }
        private void btnMenuReportes_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaListaReportes.Instancia))
            {
                rpMain.Controls.Add(pantallaListaReportes.Instancia);
                pantallaListaReportes.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaListaReportes.Instancia.Parent);
            }
            pantallaListaReportes.Instancia.BringToFront();

            // Cambiar los botones y rPanel excepto el enviado
            cambiarColoresBotonesMenu(rpBtnMenuReportes);
        }

        private void actualizarBD(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"La base de datos de Virus ha sido actualizada.", "Actualizar Base de Datos");
        }

        private void btnMenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        #endregion botonesClick

        #endregion panelMenu
    }
}
