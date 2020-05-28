﻿using System;
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
    public partial class pantallaActualizarSedes : UserControl
    {
        // Singleton instance para poder crearlo en la pantalla menu
        #region instancia
        private static pantallaActualizarSedes _instancia;
        public static pantallaActualizarSedes Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new pantallaActualizarSedes();
                return _instancia;
            }
        }
        #endregion instancia

        public pantallaActualizarSedes()
        {
            InitializeComponent();
            il_Sedes1.EditarClick += btnEditarClick;
            il_Sedes2.EditarClick += btnEditarClick;
        }

        private void btnEditarClick(Object sender, EventArgs e)
        {
            //MessageBox.Show("NO AUN");
            if (!this.Controls.Contains(pantallaEditarSede.Instancia))
            {
                this.Controls.Add(pantallaEditarSede.Instancia);
                pantallaEditarSede.Instancia.Dock = DockStyle.Fill;
                if (DarkMode.is_dark_mode_active())
                    DarkMode.iniciarSinTimer(pantallaEditarSede.Instancia.Parent);
            }
            pantallaEditarSede.Instancia.BringToFront();
        }

        private void btn_AZ_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rnd_AZ.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rnd_ZA.ColorPanel = Color.Transparent;
            this.rnd_Antiguo.ColorPanel = Color.Transparent;
            this.rnd_Reciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_ZA.BackColor = Color.Transparent;
            this.btn_AZ.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_Reciente.BackColor = Color.Transparent;
            this.btn_Antiguo.BackColor = Color.Transparent;
        }

        private void btn_ZA_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rnd_ZA.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rnd_AZ.ColorPanel = Color.Transparent;
            this.rnd_Antiguo.ColorPanel = Color.Transparent;
            this.rnd_Reciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_AZ.BackColor = Color.Transparent;
            this.btn_ZA.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_Reciente.BackColor = Color.Transparent;
            this.btn_Antiguo.BackColor = Color.Transparent;
        }

        private void btn_Antiguo_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rnd_Antiguo.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rnd_ZA.ColorPanel = Color.Transparent;
            this.rnd_AZ.ColorPanel = Color.Transparent;
            this.rnd_Reciente.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_ZA.BackColor = Color.Transparent;
            this.btn_Antiguo.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_Reciente.BackColor = Color.Transparent;
            this.btn_AZ.BackColor = Color.Transparent;
        }

        private void btn_Reciente_Click(object sender, EventArgs e)
        {
            // Cambiar color rounded panels de atras
            this.rnd_Reciente.ColorPanel = Colores.AmarilloInteractivoMenos1;
            this.rnd_ZA.ColorPanel = Color.Transparent;
            this.rnd_Antiguo.ColorPanel = Color.Transparent;
            this.rnd_AZ.ColorPanel = Color.Transparent;

            // Cambiar color botones de al frente
            this.btn_ZA.BackColor = Color.Transparent;
            this.btn_Reciente.BackColor = Colores.AmarilloInteractivoMenos1;
            this.btn_AZ.BackColor = Color.Transparent;
            this.btn_Antiguo.BackColor = Color.Transparent;
        }
    }
}