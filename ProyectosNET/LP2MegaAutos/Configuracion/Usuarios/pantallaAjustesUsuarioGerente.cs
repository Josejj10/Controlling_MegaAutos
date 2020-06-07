using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos
{
    public partial class pantallaAjustesUsuarioGerente : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaAjustesUsuarioGerente _instancia;
        public static pantallaAjustesUsuarioGerente Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaAjustesUsuarioGerente();
                return _instancia;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        #endregion instancia
        public pantallaAjustesUsuarioGerente()
        {
            InitializeComponent();
            this.btnEditar.Click += btnEditarUsu_Click;
        }

        private void btnEditarUsu_Click(Object sender, EventArgs e)
        {
            //MessageBox.Show("NO AUN");
            if (!this.Controls.Contains(pantallaEditarInformacionPropia.Instancia))
            {
                this.Controls.Add(pantallaEditarInformacionPropia.Instancia);
                pantallaEditarInformacionPropia.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaEditarInformacionPropia.Instancia.Parent);
            }
            pantallaEditarInformacionPropia.Instancia.BringToFront();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btn_AgregarPermiso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar");
        }

    }
}
