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

// https://www.codeproject.com/Articles/38436/Extended-Graphics-Rounded-rectangles-Font-metrics
// Agradecido con el de arriba

namespace LP2MegaAutos
{
    public partial class RoundedPanel : Panel
    {
        private Color colorPanel=White_Mode.FrontBackground;
        private Color colorBorde= White_Mode.BackBackground;
        private int arcRadiusPanel = 15;
        private int xPanel = 0;
        private int yPanel = 0;
        private int menosWidthPanel = 1;
        private int menosHeightPanel = 1;
        private int arcRadiusBorde = 15;
        private int xBorde = 0;
        private int yBorde = 0;
        private int menosWidthBorde = 1;
        private int menosHeightBorde = 1;
        private int porcLuzColorBorde = 0;
        private RectangleEdgeFilter cornersRound = RectangleEdgeFilter.All;

        public int ArcRadiusPanel { get => arcRadiusPanel; set => arcRadiusPanel = value; }
        public int XPanel { get => xPanel; set => xPanel = value; }
        public int YPanel { get => yPanel; set => yPanel= value; }
        public int MenosWidthPanel { get => menosWidthPanel; set => menosWidthPanel= value; }
        public int MenosHeightPanel { get => menosHeightPanel; set => menosHeightPanel = value; }
        public int ArcRadiusBorde { get => arcRadiusBorde; set => arcRadiusBorde = value; }
        public int XBorde { get => xBorde; set => xBorde = value; }
        public int YBorde { get => yBorde; set => yBorde = value; }
        public int MenosWidthBorde { get => menosWidthBorde; set => menosWidthBorde = value; }
        public int MenosHeightBorde { get => menosHeightBorde; set => menosHeightBorde = value; }
        public int PorcLuzColorBorde { get => porcLuzColorBorde; set => porcLuzColorBorde = value; }
        public RectangleEdgeFilter CornersRound { get => cornersRound; set => cornersRound = value; }

        public RoundedPanel()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(colorPanel), XPanel, YPanel, this.Width - MenosWidthPanel
                , this.Height - MenosHeightPanel, ArcRadiusPanel, CornersRound);
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(colorBorde, PorcLuzColorBorde)), XBorde,
                YBorde, this.Width - MenosWidthBorde, this.Height - MenosHeightBorde, ArcRadiusBorde,cornersRound);
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

        // Cambiar
        public void cambiarCorner(RectangleEdgeFilter corner)
        {
            this.CornersRound = corner;
            this.Invalidate();
        }

    }

}

