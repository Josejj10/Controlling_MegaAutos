using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LP2MegaAutos.VentanasPrincipales
{
    public static class LoadingHelper
    {
        private static frmLoading loading = null;
        private static Thread thrdLoading;

        public static void loadingStart()
        {
            thrdLoading = new Thread(new ThreadStart(showLoadingScreen)); ;
            thrdLoading.Start();
        }

        public static void stopLoading()
        {
            thrdLoading.Abort();
        }


        private static void showLoadingScreen()
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

    }
}
