using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class PlaceholderUtil
    {
        public static void AplicarPlaceholders(Dictionary<TextBox, string> placeholders)
        {
            foreach (var pair in placeholders)
            {
                pair.Key.Text = pair.Value;
                pair.Key.ForeColor = Color.DimGray;
                pair.Key.GotFocus += (s, e) =>
                {
                    if (pair.Key.Text == pair.Value)
                    {
                        pair.Key.Text = "";
                        pair.Key.ForeColor = Color.Black;
                    }
                };
                pair.Key.Leave += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(pair.Key.Text))
                    {
                        pair.Key.Text = pair.Value;
                        pair.Key.ForeColor = Color.DimGray;
                    }
                };
            }
        }
    }
}
