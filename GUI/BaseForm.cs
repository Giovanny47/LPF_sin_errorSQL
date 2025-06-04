using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI
{
    public  static class BaseForm
    {

        public static void Minimizar(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }


        public static void Salir()
        {
            Application.Exit();
        }

        public static void ArrastrarVentana(Form form)
        {
            ReleaseCapture();
            SendMessage(form.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
    }
}