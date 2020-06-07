using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2MegaAutos
{
    public static class TitleBar
    {
        private static int mouseX = 0, mouseY = 0, mouseInX, mouseInY;
        private static bool mouseDown;

        public static void mouse_Up()
        {
            mouseDown = false;
        }


        public static void mouse_Down(Point mousePosition, Rectangle bounds)
        {
            mouseInX = mousePosition.X - bounds.X;
            mouseInY = mousePosition.Y - bounds.Y;
            mouseDown = true;
        }

        public static void mouse_Move(Point mousePosition, Form f)
        {
            if (mouseDown)
            {
                mouseX = mousePosition.X - mouseInX;
                mouseY = mousePosition.Y - mouseInY;

                f.SetDesktopLocation(mouseX, mouseY);
            }
        }
    }
}
