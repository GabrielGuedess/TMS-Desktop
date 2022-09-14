using Interface.TemplateComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.ControlValidationAuxiliary
{
    public class Validation
    {
        public static bool Validar(Control elementPai)
        {
            // recebe o elemento pai e faz uma verificação nos seus filhos(controles)
            //para ser qual é o seu tipo
            foreach (Control control in elementPai.Controls)
            {
                //se o elemento filho do Pai for um Panel, é necessario passar
                //esse elemento filho para o método Validar para ver qual 
                // se esse filho tem os controles que precisa ser validado
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
                //esse é o método responsável por fazer a verificação 
                //dos campos
                else if (verificarControl(control) == false)
                {
                    return false;
                }
            }
            return true;
        }

        // Esse é a Sobrecarga do método validar que permite
        // deixar de verificar alguns campos que não são 
        // Obrigatorios
        public static bool Validar(Control elementPai, List<string> notValidar)
        {

            foreach (Control control in elementPai.Controls)
            {
                //Atraves da List que o método recebe ele 
                //verifica se os filhos(Controls) do controle que está sendo verificado
                //está na List e se tiver ele returna true e não 
                //faz a verificação do campo
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
                else if (verificarControl(control) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //recebe os filhos do controle Pai e verefica qual é 
        //seu tipo e partir disso chama o método message 
        private static bool verificarControl(Control control)
        {
            if (control is TextBoxOnlyNum)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is TextBoxOnlyLetters)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is TextBoxOnlyNum_Letters)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is TextBoxTemplete)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is TextKg)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is TextKM)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is TextM3)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is TextMoney)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is ComboBox)
            {
                if (message(control) == false)
                    return false;
            }
            else if (control is DateTimePicker)
            {
                DateTimePicker datePicker = (DateTimePicker)control;
                if (datePicker.Format == DateTimePickerFormat.Custom)
                {
                    message(control);
                    return false;
                }
            }
            else if (control is MasckedboxTemplete)
            {
                MasckedboxTemplete maskedBox = (MasckedboxTemplete)control;
                if (maskedBox.MaskCompleted == false)
                {
                    message(control);
                    return false;
                }
            }
            return true;
        }

        //O método message é responsavel por mostrar 
        //a messagem que o campo deve ser preenchido na 
        //tela do usuário 
        private static bool message(Control control)
        {
            if (control.Text == string.Empty || control is MasckedboxTemplete || control is EmpDateTimer)
            {
                MessageBox.Show($"O campo {nameCampo(control)} é obrigatório estar preenchido corretemente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control.Focus();
                return false;
            }
            return true;
        }
        //Esse método é resposável por ler a Label que cada
        //campo tem e retornar o texto dessa lavel
        private static string nameCampo(Control control)
        {
            foreach (Control label in control.Parent.Controls)
            {
                if (label is System.Windows.Forms.Label)
                {
                    return label.Text;
                }
            }
            foreach (Control label in control.Parent.Parent.Controls)
            {
                if (label is System.Windows.Forms.Label)
                {
                    return label.Text;
                }
            }
            return "";
        }
        public static bool validarTelefone(MasckedboxTemplete mkTelefone)
        {
            if (mkTelefone.Text.Length > 1 && mkTelefone.Text.Length < 10)
            {
                MessageBox.Show("É necessário preencher o campo telefone corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkTelefone.Focus();
                return false;
            }
            return true;
        }
        public static bool validarSenha(TextBoxTemplete tbSenha, TextBoxTemplete tbSenhaConfimação)
        {
            if (tbSenha.Text != tbSenhaConfimação.Text)
            {
                MessageBox.Show("As senhas não se conhecidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSenha.Focus();
                return false;
            }
            return true;
        }
    }
}
