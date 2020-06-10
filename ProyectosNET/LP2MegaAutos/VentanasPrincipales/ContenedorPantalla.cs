using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos.VentanasPrincipales
{
    public partial class ContenedorPantalla : UserControl
    {
        
        // Lista de pantallas
        private BindingList<Pantalla> _pantallas;
        private Pantalla pInicio = new pantallaInicioGerente();

        public ContenedorPantalla()
        {
            InitializeComponent();
            _pantallas = new BindingList<Pantalla>();
            
            // Problema Scroll: Si funciona cuando se añade estaticamente tanto
            // mediante PantallaActual como directamente a controles
            // PantallaActual = new pantallaListaReportes();
            // Controls.Add(new pantallaListaReportes());
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
            }
        }

        public Pantalla UltimaPantalla
        {
            get
            {
                // TODO agregar limite

                if (!puedeVolver())
                    return null;

                return _pantallas.ElementAt(_pantallas.IndexOf(getPantallaActual()) - 1);
            }
        }
        
        public Pantalla PantallaAdelante
        {
            get
            {
                if(!puedeAdelante())
                    return null;
                return _pantallas.ElementAt(_pantallas.IndexOf(getPantallaActual()) + 1);
            }
        }

        public bool puedeVolver()
        {
            return Controls.Count != 0 ? _pantallas.IndexOf(getPantallaActual()) != 0 : false;
        }

        public bool puedeAdelante()
        {
            return Controls.Count !=0 ? ! (_pantallas.IndexOf(getPantallaActual()) + 1 == _pantallas.Count) : false;
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
        }

        public void adelantarPantalla()
        {
            if (Controls.Count == 0)
                return;
            Pantalla adelante = PantallaAdelante;
            if (adelante == null) return;
            Controls.Remove(getPantallaActual());
            Controls.Add(adelante);
        }

    }
}
