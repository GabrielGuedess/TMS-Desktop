using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.TemplateComponents;
namespace Interface.ControlValidationAuxiliary
{
    public class LimparFormularios
    {
        public void CleanControl(Control elementPai)
        {
            foreach (Control control in elementPai.Controls)
            {
                if (control is TextBoxOnlyNum)
                {
                    ((TextBoxOnlyNum)control).Text = "";
                }
                else if (control is TextBoxOnlyLetters)
                {
                    ((TextBoxOnlyLetters)control).Text = "";
                }
                else if (control is TextBoxOnlyNum_Letters)
                {
                    ((TextBoxOnlyNum_Letters)control).Text = "";
                }
                else if (control is TextBoxTemplete)
                {
                    ((TextBoxTemplete)control).Text = "";
                }
                else if (control is TextKg)
                {
                    ((TextKg)control).Text = "";
                }
                else if (control is TextKM)
                {
                    ((TextKM)control).Text = "";
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
                    ((MasckedboxTemplete)control).Text = "";
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
