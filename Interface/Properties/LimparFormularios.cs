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
        public void CleanControl(Control elementPai)
        {
            foreach (Control control in elementPai.Controls)
            {
                if (control is textBoxnOnlyNum)
                {
                    ((textBoxnOnlyNum)control).Text = "";
                }
                else if (control is textBoxOnlyLetters)
                {
                    ((textBoxOnlyLetters)control).Text = "";
                }
                else if (control is textBoxOnlyNum_Letters)
                {
                    ((textBoxOnlyNum_Letters)control).Text = "";
                }
                else if (control is textBoxTemplete)
                {
                    ((textBoxTemplete)control).Text = "";
                }
                else if (control is TextKg)
                {
                    ((TextKg)control).Text = "";
                }
                else if (control is TextKm)
                {
                    ((TextKm)control).Text = "";
                }
                else if (control is TextM3)
                {
                    ((TextM3)control).Text = "";
                }
                else if (control is TextMoney)
                {
                    ((TextMoney)control).Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    ((EmpDateTimer)control).Format = DateTimePickerFormat.Custom;
                }

                else if (control is MaskedTextBox)
                {
                    ((masckedboxTemplete)control).Text = "";
                }
                else if (control is Panel)
                {
                    CleanControl(control);
                }
                else if (control is PanelBorderRounded)
                {
                    CleanControl(control);
                }
                else if (control is PanelBorderRoundedOnLeft)
                {
                    CleanControl(control);
                }
                else if (control is PanelBorderRoundedOnRight)
                {
                    CleanControl(control);
                }
            }
        }
    }
}
