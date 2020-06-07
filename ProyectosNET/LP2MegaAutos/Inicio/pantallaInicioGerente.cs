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
    public partial class pantallaInicioGerente : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaInicioGerente _instancia;
        public static pantallaInicioGerente Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaInicioGerente();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaInicioGerente()
        {
            InitializeComponent();
        }

        #region Event Handlers
        // Crear Event Handlers para que la pantalla Principal 
        // Abra del Menu
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);
        public event ButtonClickEventHandler BienvenidoClickGerente;
        public event ButtonClickEventHandler GenerarReporte;
        public event ButtonClickEventHandler AreaTrabajoGerente;
        public event ButtonClickEventHandler ReportesGerente;
        public event ButtonClickEventHandler ServiciosGerente;
        public event ButtonClickEventHandler DriversGerente;
        public event ButtonClickEventHandler EmpresaGerente;
        public event ButtonClickEventHandler ClientesGerente;
        public event ButtonClickEventHandler UsuariosGerente;
        public event ButtonClickEventHandler SedesGerente;
        public event ButtonClickEventHandler ActualizarBDGerente;
        public event ButtonClickEventHandler AjustesGerente;
        public event ButtonClickEventHandler CerrarSesionGerente;

        private void lblBienvenido_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = BienvenidoClickGerente;
            if (h != null) h(this, e);
        }

        private void btn_GenerarReporteGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = GenerarReporte;
            if (h != null) h(this, e);
        }

        private void btn_AreaTrabajoGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = AreaTrabajoGerente;
            if (h != null) h(this, e);
        }

        private void btn_ReportesGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ReportesGerente;
            if (h != null) h(this, e);
        }

        private void btn_ServiciosGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ServiciosGerente;
            if (h != null) h(this, e);
        }

        private void btn_DriversGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = DriversGerente;
            if (h != null) h(this, e);
        }

        private void btn_EmpresaGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = EmpresaGerente;
            if (h != null) h(this, e);
        }

        private void btn_ClientesGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ClientesGerente;
            if (h != null) h(this, e);
        }

        private void btn_UsuariosGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = UsuariosGerente;
            if (h != null) h(this, e);
        }

        private void btn_SedesGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = SedesGerente;
            if (h != null) h(this, e);
        }

        private void btn_ActualizarBDGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = ActualizarBDGerente;
            if (h != null) h(this, e);
        }

        private void btnAjustesGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = AjustesGerente;
            if (h != null) h(this, e);
        }

        private void btn_CerrarSesionGerente_Click(object sender, EventArgs e)
        {
            ButtonClickEventHandler h = CerrarSesionGerente;
            if (h != null) h(this, e);
        }
        #endregion Event Handlers
    }
}
