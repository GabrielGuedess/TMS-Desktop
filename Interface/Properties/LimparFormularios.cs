using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Properties;

namespace Interface.Properties
{
    public class LimparFormularios
    {
        public void ClearControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is textBoxnOnlyNum)
                {
                    ((textBoxnOnlyNum)c).Text = "";
                }
                else if (c is textBoxOnlyLetters)
                {
                    ((textBoxOnlyLetters)c).Text = "";
                }
                else if (c is textBoxOnlyNum_Letters)
                {
                    ((textBoxOnlyNum_Letters)c).Text = "";
                }
                else if (c is textBoxTemplete)
                {
                    ((textBoxTemplete)c).Text = "";
                }
                else if (c is TextKg)
                {
                    ((TextKg)c).Text = "";
                }
                else if (c is TextKm)
                {
                    ((TextKm)c).Text = "";
                }
                else if (c is TextM3)
                {
                    ((TextM3)c).Text = "";
                }
                else if (c is TextMoney)
                {
                    ((TextMoney)c).Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is DateTimePicker)
                {
                    ((EmpDateTimer)c).Format = DateTimePickerFormat.Custom;
                }

                else if (c is MaskedTextBox)
                {
                    ((masckedboxTemplete)c).Text = "";
                }
                else if (c is Panel)
                {
                    ClearControl(c);
                }
                else if (c is PanelBorderRounded)
                {
                    ClearControl(c);
                }
                else if (c is PanelBorderRoundedOnLeft)
                {
                    ClearControl(c);
                }
                else if (c is PanelBorderRoundedOnRight)
                {
                    ClearControl(c);
                }
            }
        }
    }
}
