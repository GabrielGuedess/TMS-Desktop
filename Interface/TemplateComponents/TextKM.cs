using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.TemplateComponents
{
    public class TextKM : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(225, 19);
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);

        }
        string valor;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                KeyUp += new KeyEventHandler(key);
                void key(Object o, KeyEventArgs e)
                {
                    valor = Text;
                    if (valor == "")
                        valor = "0,00 Km";

                    valor = valor.Replace("Km", "").Replace(",", "");

                    if (valor.Length == 1)
                        valor = "00,00" + valor;
                    else if (valor.Length == 2)
                        valor = "00,0" + valor;
                    else if (valor.Length == 2)
                        valor = "00,0" + valor;
                    else
                        valor = valor.Insert(valor.Length - 3, ",");

                    Text = string.Format("{0:n} Km", Convert.ToDouble(valor));
                    Select(Text.Length - 3, 0);
                }


            }
            else
                e.Handled = true;
        }
    }
}
