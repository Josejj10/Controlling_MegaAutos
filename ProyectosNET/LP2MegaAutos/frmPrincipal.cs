using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

            
        

        #region title_bar

        #region botones
        private void boton_cerrar_MouseClick(object sender, EventArgs e)
        {
            Close();
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
            if (!rpMain.Controls.Contains(pantallaInicioGerente.Instancia))
            {
                rpMain.Controls.Add(pantallaInicioGerente.Instancia);
                pantallaInicioGerente.Instancia.Dock = DockStyle.Fill;
                pantallaInicioGerente.Instancia.BringToFront();
            }
            else
                pantallaInicioGerente.Instancia.BringToFront();

            // Cambiar los botones y rPanel
            cambiarColoresBotonesMenu(rpBtnMenuHome);
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            if (!rpMain.Controls.Contains(pantallaActualizarDrivers.Instancia))
            {
                rpMain.Controls.Add(pantallaActualizarDrivers.Instancia);
                pantallaActualizarDrivers.Instancia.Dock = DockStyle.Fill;
                pantallaActualizarDrivers.Instancia.BringToFront();
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaActualizarDrivers.Instancia.Parent);
            }
            else
                pantallaActualizarDrivers.Instancia.BringToFront();

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
        #endregion botonesClick
        
        #endregion panelMenu

    }
}
