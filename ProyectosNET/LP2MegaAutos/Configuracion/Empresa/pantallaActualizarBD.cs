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
using System.Threading;

namespace LP2MegaAutos
{
    public partial class pantallaActualizarBD : Pantalla
    {
        ServicioExcel.ExcelWSClient daoExcel;
        private static frmLoading loading = null;
        private string archivoSeleccionado1;
        private string archivoSeleccionado2;
        private ServicioExcel.excel _excelEnviado;
        private ServicioExcel.excel _excelRecibido;


        public pantallaActualizarBD()
        {
            InitializeComponent();
            daoExcel = new ServicioExcel.ExcelWSClient();
            _excelEnviado = new ServicioExcel.excel();
            _excelRecibido = new ServicioExcel.excel();
            ServicioSede.SedeWSClient daoSede = new ServicioSede.SedeWSClient();
            cboSede.DisplayMember = "distrito";
            cboSede.DataSource = daoSede.listarSedes();
            btn_guardar.Enabled =btnDescargar.Enabled= false;
            rpBtnGuardar.ColorBorde = rpBtnGuardar.ColorPanel =
            rpBtnDescargar.ColorBorde = rpBtnDescargar.ColorPanel =
                Colores.Disabled;
        }


        private void btnExaminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Llamar a pantalla de carga
            Thread thrdLoading = new Thread(new ThreadStart(showLoadingScreen)); ;
            thrdLoading.Start();

            frmMessageBox frm;
            bool inserto = daoExcel.insertarArchivoEntrada(_excelEnviado) ==  0;
            thrdLoading.Abort();
            if (inserto)
            {
                frm = new frmMessageBox("No se pudo insertar el archivo.", MessageBoxButtons.OK);
            }
            else
            {
                // Inserto bien{
                frm = new frmMessageBox("Se inserto correctamente el archivo excel.", MessageBoxButtons.OK);
                this.btnObtener.Enabled = true;
            }
            frm.ShowDialog();

        }

        private void showLoadingScreen()
        {
            try
            {
                if (loading == null) loading = new frmLoading();
                loading.Enabled = true;
                loading.ShowDialog();
            }
            finally
            {
                loading.stopTick();
                loading.Dispose();
                loading = null;
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            
            if (sfdArchivoReporte.ShowDialog() == DialogResult.OK)
            {
                // Poner las rutas por default
                frmMessageBox f;
                String archivoEntrada = sfdArchivoReporte.FileName + ".xlsx";
                Thread thrdLoading = new Thread(new ThreadStart(showLoadingScreen)); ;
                thrdLoading.Start();
                _excelRecibido = daoExcel.leerArchivoSalida();
                thrdLoading.Abort();
                if(_excelRecibido.archivo == null)
                {
                    f = new frmMessageBox("No se recibió ningún dato. .El archivo insertado probablemente sea incorrecto", MessageBoxButtons.OK, "ERROR", true);
                    f.ShowDialog();
                    return;
                }
                File.WriteAllBytes(archivoEntrada, _excelRecibido.archivo);
                frmMessageBox frm = new frmMessageBox("Se ha guardado el Archivo", MessageBoxButtons.OK, "Mensaje de Confirmación");
                frm.ShowDialog();
            }
        }

        private void btnDescargar1_Click(object sender, EventArgs e)
        {
            if(sfdArchivoEntrada.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoEntrada = sfdArchivoEntrada.FileName + ".xlsx";
                    Thread thrdLoading = new Thread(new ThreadStart(showLoadingScreen)); ;
                    thrdLoading.Start();
                    _excelRecibido = daoExcel.leerArchivoEntrada();
                    thrdLoading.Abort();

                    File.WriteAllBytes(archivoEntrada, _excelRecibido.archivo);
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
