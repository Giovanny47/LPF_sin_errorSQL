using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class fondoutil
    {
        //aaqui pronto va el codigo para colocar un fondo a los Form
        public static void colocarFondo(Panel panel, string rutaImagen)
        {
            if (System.IO.File.Exists(rutaImagen))
            {
                panel.BackgroundImage = new Bitmap(rutaImagen);
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                panel.BackColor = Color.Transparent;
            }


        }
        public static void colocarFondo(Form form, string rutaImagen)
        {
            if (System.IO.File.Exists(rutaImagen))
            {
                form.BackgroundImage = new Bitmap(rutaImagen);
                form.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
