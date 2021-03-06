﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace LP2MegaAutos.VentanasPrincipales
{
    public partial class ContenedorPantalla : UserControl
    {
        
        private BindingList<Pantalla> _pantallas;    // Lista de pantallas
        private Pantalla pInicio; 
        private int maximo = 15; // Maximo de pantallas en cola
        private int indexActual = -1; // La primera pantalla que se agregue estara en 0

        public ContenedorPantalla()
        {
            InitializeComponent();
            _pantallas = new BindingList<Pantalla>();
        }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Pantalla PInicial
        {
            set
            {
                if (value == null) return;
                pInicio = value;
                // Agregar a la lista de pantallas  
                _pantallas.Add(value);

                

                // Agregar pantalla a los controles del contenedor
                Controls.Add(value);
                indexActual++; 
                ((pantallaInicio)pInicio).crearBotonesSegunPermisos();
                if (DarkMode.is_dark_mode_active()) // Si esta activo
                    DarkMode.iniciarSinTimer(this);
            }
            get
            {
                return (pantallaInicio)pInicio;
            }
        }
        public Pantalla getPantallaActual()
        {
            return Controls.Count > 0 ? (Pantalla)Controls[0] : pInicio;

        }

        public Pantalla PantallaActual
        {
            set
            {
                // Agregar a la lista de pantallas  
                _pantallas.Add(value);

                // Quitar la ultima pantalla 
                if (Controls.Count != 0)
                {
                    Controls.Remove(Controls[0]);
                }

                // Agregar pantalla a los controles del contenedor
                Controls.Add(value);
                if (DarkMode.is_dark_mode_active() && !value.DarkModeActive)
                    DarkMode.iniciarSinTimer(this);

                // Iniicalizar los botones de la pantalla
                MethodInfo inic;
                if((inic = value.GetType()  .GetMethod("inicializarItemsLista"))!=null)
                    inic.Invoke(value,null);

                if (_pantallas.Count >= maximo) // Limite de pantallas
                    _pantallas.RemoveAt(0);
                else
                    indexActual++;
            }
        }

        public Pantalla UltimaPantalla
        {
            get
            {
                if (!puedeVolver())
                    return null;
                
                indexActual--;
                return _pantallas.ElementAt(indexActual);
            }
        }
        
        public Pantalla PantallaAdelante
        {
            get
            {
                if(!puedeAdelante())
                    return null;
                indexActual++;
                return _pantallas.ElementAt(indexActual);
            }
        }

        public bool puedeVolver()
        {
            return Controls.Count != 0 ? indexActual != 0 : false;
        }

        public bool puedeAdelante()
        {
            return Controls.Count !=0 ? !(indexActual + 1 == _pantallas.Count) : false;
        }


        public void irInicio()
        {
            // Si se usa cuando no se ha agregado nada aun
            if (Controls.Count == 0)
                return;
            PantallaActual = pInicio;
            if (DarkMode.is_white_mode_active() && pInicio.DarkModeActive)
                DarkMode.iniciarSinTimer(this);
        }

        public void volverUltimaPantalla()
        {
            // Si se usa cuando no se ha agregado nada aun
            if (Controls.Count == 0)
                return;
            Pantalla ultima = UltimaPantalla;
            if (ultima == null) return;
            Controls.Remove(getPantallaActual());
            Controls.Add(ultima);
            if (DarkMode.is_dark_mode_active() && !ultima.DarkModeActive)
                DarkMode.iniciarSinTimer(this);
            else if (DarkMode.is_white_mode_active() && ultima.DarkModeActive)
                DarkMode.iniciarSinTimer(this);
        }

        public void adelantarPantalla()
        {
            if (Controls.Count == 0)
                return;
            Pantalla adelante = PantallaAdelante;
            if (adelante == null) return;
            Controls.Remove(getPantallaActual());
            Controls.Add(adelante);
            if (DarkMode.is_dark_mode_active() && !adelante.DarkModeActive)
                DarkMode.iniciarSinTimer(this);
            else if (DarkMode.is_white_mode_active() && adelante.DarkModeActive)
                DarkMode.iniciarSinTimer(this);
        }

    }
}
