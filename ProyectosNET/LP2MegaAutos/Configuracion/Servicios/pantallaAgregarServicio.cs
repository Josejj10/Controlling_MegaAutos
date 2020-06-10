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
    public partial class pantallaAgregarServicio : MetroForm
    {
        public pantallaAgregarServicio()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // this.Parent.Controls.Remove(this);
            // TODO agregar metodos para limpiar la pantalla
            // aka los textBoxs
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pantallaAgregarServicio_Load(object sender, EventArgs e)
        {

        }

        private void txt_NombreServicio_Enter(object sender, EventArgs e)
        {
            txt_NombreServicio.Text = string.Empty;
        }

        private void txt_NombreServicio_Leave(object sender, EventArgs e)
        {
            if (txt_NombreServicio.Text == string.Empty)
                txt_NombreServicio.Text = "Agregar nombre del servicio...";
        }
    }
}