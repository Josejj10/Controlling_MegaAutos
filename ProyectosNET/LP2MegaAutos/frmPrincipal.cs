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


        public void btnEditarClick(EventArgs e)
        {
            
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


    }
}
