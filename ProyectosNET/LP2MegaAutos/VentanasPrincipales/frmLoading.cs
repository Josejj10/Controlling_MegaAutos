using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }        

        public void stopTick()
        {
            timerLoading.Stop();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            
            panelLoading.Left += 5;
            if(panelLoading.Left >= 575)
            {
                panelLoading.Left = -50;
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            timerLoading.Start();
        }
    }
}
