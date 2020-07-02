using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP2MegaAutos.VentanasPrincipales;
using LP2MegaAutos.Configuracion.Empresa;
using LP2MegaAutos.ServicioEmpresa;
using System.IO;

namespace LP2MegaAutos
{
    public partial class pantallaInformacionEmpresa : Pantalla
    {
        ServicioEmpresa.EmpresaWSClient daoEmpresa;
        ServicioExcel.ExcelWSClient daoExcel;

        private string archivoSeleccionado1;
        private string archivoSeleccionado2;
        private ServicioExcel.excel _excel;
        empresa _empresa;
        public pantallaInformacionEmpresa()
        {
            InitializeComponent();
            daoEmpresa = new ServicioEmpresa.EmpresaWSClient();
            daoExcel = new ServicioExcel.ExcelWSClient();
            inicializarEmpresas();
        }

        private void inicializarEmpresas()
        {
            List<empresa> empresas = daoEmpresa.listarEmpresa().ToList();
            if (empresas == null) return;
            _empresa = empresas[0];
            this.lbl_nombreEmpresa.Text = empresas[0].nombre;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarNombEmpresa pas = new frmEditarNombEmpresa(_empresa);
            if (pas.ShowDialog() == DialogResult.OK)
                MessageBox.Show("OK");
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fld = new FolderBrowserDialog();
            //if (fld.ShowDialog() == DialogResult.OK)
            //{
            //    txtArchivo1.Text = fld.SelectedPath;
            //}

            try
            {
                if (ofdArchivo1.ShowDialog() == DialogResult.OK)
                {
                    archivoSeleccionado1 = ofdArchivo1.FileName;
                    txtArchivo1.Text = archivoSeleccionado1;
                    FileStream fs = new FileStream(archivoSeleccionado1, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);

                    // Asignamos el archivo al objeto
                    //this._excel.excel1 = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo valido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnExaminar2_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fld = new FolderBrowserDialog();
            //fld.ShowDialog();
            //if (fld.ShowDialog() == DialogResult.OK)
            //{
            //    txtArchivo2.Text = fld.SelectedPath;                    
            //}

            try
            {
                if (ofdArchivo2.ShowDialog() == DialogResult.OK)
                {
                    archivoSeleccionado2 = ofdArchivo2.FileName;
                    txtArchivo2.Text = archivoSeleccionado1;
                    FileStream fs = new FileStream(archivoSeleccionado2, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);

                    // Asignamos el archivo al objeto
                    //this._excel.excel2 = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo valido", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnEditarRutas_Click(object sender, EventArgs e)
        {
            txtArchivo1.Enabled = txtArchivo2.Enabled =
            btnExaminar.Enabled = btnExaminar2.Enabled = !btnExaminar2.Enabled;
            btnDefault.Visible = btnGuardar.Visible = !btnGuardar.Visible;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Almacenar los string en el back
            // WebService.GuardarArchivo(txtArchivo1.Text);
            // WebService.GuardarArchivo(txtArchivo2.Text);

            

        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            // Poner las rutas por default
        }
    }
}
