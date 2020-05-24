using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Plasmoid.Extensions;

namespace LP2MegaAutos
{
    public partial class RoundedPanel : Panel
    {
        private Color colorPanel=White_Mode.FrontBackground;
        private Color colorBorde= White_Mode.LowContrast;
        private int arcRadiusColor = 15;
        private int xColor = 0;
        private int yColor = 0;
        private int menosWidthColor = 1;
        private int menosHeightColor = 1;
        private int arcRadiusBorde = 15;
        private int xBorde = 0;
        private int yBorde = 0;
        private int menosWidthBorde = 1;
        private int menosHeightBorde = 1;
        private int porcLuzColorBorde = 0;

        public int ArcRadiusColor { get => arcRadiusColor; set => arcRadiusColor = value; }
        public int XColor { get => xColor; set => xColor = value; }
        public int YColor { get => yColor; set => yColor = value; }
        public int MenosWidthColor { get => menosWidthColor; set => menosWidthColor = value; }
        public int MenosHeightColor { get => menosHeightColor; set => menosHeightColor = value; }
        public int ArcRadiusBorde { get => arcRadiusBorde; set => arcRadiusBorde = value; }
        public int XBorde { get => xBorde; set => xBorde = value; }
        public int YBorde { get => yBorde; set => yBorde = value; }
        public int MenosWidthBorde { get => menosWidthBorde; set => menosWidthBorde = value; }
        public int MenosHeightBorde { get => menosHeightBorde; set => menosHeightBorde = value; }
        public int PorcLuzColorBorde { get => porcLuzColorBorde; set => porcLuzColorBorde = value; }

        public RoundedPanel()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(colorPanel), XColor, YColor, this.Width - MenosWidthColor
                , this.Height - MenosHeightColor, ArcRadiusColor);
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(colorBorde, PorcLuzColorBorde)), XBorde,
                YBorde, this.Width - MenosWidthBorde, this.Height - MenosHeightBorde, ArcRadiusBorde);
        }

        // Cambiar colores
        public void cambiarColorPanel(Color color)
        {
            colorPanel = color;
            this.Invalidate();
        }

        // Cambiar borde
        public void cambiarColorBorde(Color color)
        {
            colorBorde = color;
            this.Invalidate();
        }

        // Recibir colores del panel y borde
        public Color getColorPanel()
        {
            return colorPanel;
        }

        public Color getColorBorde()
        {
            return colorBorde;
        }

    }

}

