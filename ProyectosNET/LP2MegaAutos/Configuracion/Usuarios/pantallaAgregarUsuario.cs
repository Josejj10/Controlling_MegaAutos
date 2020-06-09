﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace LP2MegaAutos
{
    public partial class pantallaAgregarUsuario : MetroForm
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaAgregarUsuario _instancia;
        public static pantallaAgregarUsuario Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaAgregarUsuario();
                return _instancia;
            }
        }
        #endregion instancia
        public pantallaAgregarUsuario()
        {
            InitializeComponent();
        }

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

        private void btn_AgregarPermiso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar");
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }

        private void pantallaAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txt_Nombre_Enter(object sender, EventArgs e)
        {
            if (txt_AgregarUsuario.Text == "Agregar nombre del usuario...")
                txt_AgregarUsuario.Text = string.Empty;
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (txt_AgregarUsuario.Text == string.Empty)
                txt_AgregarUsuario.Text = "Agregar nombre del usuario...";
        }
    }
}
