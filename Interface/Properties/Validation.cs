using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Properties
{
    public class Validation
    {
        public static bool Validar(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is Panel)
                {

                    if (Validar(control) == false)
                        return false;
                }
                else if (control is PanelBorderRounded)
                {
                    if (Validar(control) == false)
                        return false;
                }
                else if (control is PanelBorderRoundedOnLeft)
                {
                    if (Validar(control) == false)
                        return false;
                }
                else if (control is PanelBorderRoundedOnRight)
                {
                    if (Validar(control) == false)
                        return false;
                }
                else if (control is textBoxnOnlyNum)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is textBoxOnlyLetters)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is textBoxOnlyNum_Letters)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is textBoxTemplete)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is TextKg)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is TextKm)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is TextM3)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is TextMoney)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is ComboBox)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker datePicker = (DateTimePicker)control;
                    if (datePicker.Format == DateTimePickerFormat.Custom)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }

                else if (control is masckedboxTemplete)
                {
                    masckedboxTemplete m = (masckedboxTemplete)control;
                    if (m.MaskCompleted == false)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }

            }
            return true;
        }

        public static bool Validar(Control controls, List<string> notValidar)
        {
            foreach (Control control in controls.Controls)
            {
                foreach (string item in notValidar)
                {
                    if (control.Name == item)
                    {
                        return true;
                    }
                }
                if (control is Panel)
                {

                    if (Validar(control, notValidar) == false)
                        return false;
                }
                else if (control is PanelBorderRounded)
                {
                    if (Validar(control, notValidar) == false)
                        return false;
                }
                else if (control is PanelBorderRoundedOnLeft)
                {
                    if (Validar(control, notValidar) == false)
                        return false;
                }
                else if (control is PanelBorderRoundedOnRight)
                {
                    if (Validar(control, notValidar) == false)
                        return false;
                }
                else if (control is textBoxnOnlyNum)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is textBoxOnlyLetters)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is textBoxOnlyNum_Letters)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is textBoxTemplete)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is TextKg)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is TextKm)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is TextM3)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is TextMoney)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is ComboBox)
                {
                    if (control.Text == String.Empty)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker datePicker = (DateTimePicker)control;
                    if (datePicker.Format == DateTimePickerFormat.Custom)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }

                else if (control is masckedboxTemplete)
                {
                    masckedboxTemplete m = (masckedboxTemplete)control;
                    if (m.MaskCompleted == false)
                    {
                        string nameComponente = "";
                        foreach (Control x in control.Parent.Parent.Controls)
                        {
                            if (x is System.Windows.Forms.Label)
                            {
                                nameComponente = x.Text;
                            }
                        }
                        MessageBox.Show($"O campo {nameComponente} é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
