using Interface.Properties;

namespace Interface
{
    public partial class CadastroMotoristas : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set
            {
                cadastrarMotoristas.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentMotorista.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentMotorista.Location = new Point(0, 62);
                }
            }
        }
        public CadastroMotoristas()
        {
            InitializeComponent();
            atualizarIDMotorista();
        }

        private void CadastroMotoristas_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelBorderRoundedID, panelBorderRoundedCPF, panelBorderRoundedNCNH, panelBorderRoundedEmail, panelBorderRoundedEndereco);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarMotoristas_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarMotoristas);
        }
        private void atualizarIDMotorista()
        {
            ConnectDB connectDB = new ConnectDB();
            string SQL = "SELECT MAX (NUM_ID) FROM C_Motoristas";
            var dados = connectDB.pesquisar(SQL);
            string data = (string)dados.Rows[0][0];
            string IdNota = data.Replace("M", "");
            int numID = int.Parse(IdNota);
            numID++;
            string numIDsg = numID.ToString();
            if (numIDsg.Length == 1)
            {
                numIDsg = numIDsg.Insert(numIDsg.Length - 1, "00");
            }
            else if (numIDsg.Length == 2)
                numIDsg = numIDsg.Insert(numIDsg.Length - 2, "0");
            tbID.Text = "M" + numIDsg;
        }

        private bool validar()
        {
            if (mkCPF.Text.Length < 11)
            {
                MessageBox.Show("CPF digitado é invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
                return false;
            }
            if (mkCelular.Text.Length < 11)
            {
                MessageBox.Show("Celular digitado é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCelular.Focus();
                return false;
            }
            if (mkTelefone.Text.Length > 1 && mkTelefone.Text.Length < 10)
            {
                MessageBox.Show("Telefone digitado é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkTelefone.Focus();
                return false;
            }
            if (mkCEP.Text.Length < 8)
            {
                MessageBox.Show("CEP digitado é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCEP.Focus();
                return false;
            }
            if (mkCNH.Text.Length < 10)
            {
                MessageBox.Show("CNH digitada é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCNH.Focus();
                return false;
            }
            if (dateVencimentoCNH.Text == " ")
            {
                MessageBox.Show("Preencha o campo de Vencimento da CNH", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateVencimentoCNH.Focus();
                return false;
            }
            if (comboVeiculoProprio.Text == "")
            {
                MessageBox.Show("Preencha o campo veiculo próprio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboVeiculoProprio.Focus();
                return false;
            }
            if (comboMOPP.Text == "")
            {
                MessageBox.Show("Preencha o campo Curso MOPP", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboMOPP.Focus();
                return false;
            }
            if (comboCNH.Text == "")
            {
                MessageBox.Show("Preencha o campo Categoria CNH", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCNH.Focus();
                return false;
            }
            if (comboUF.Text == "")
            {
                MessageBox.Show("Preencha o campo UF", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboUF.Focus();
                return false;
            }
            if (comboCidade.Text == "")
            {
                MessageBox.Show("Preencha o campo Cidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCidade.Focus();
                return false;
            }
            if (tbLogradouro.Text == "")
            {
                MessageBox.Show("Preencha o campo Logradouro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLogradouro.Focus();
                return false;
            }
            if (tbNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Focus();
                return false;
            }
            if (mkRG.MaskCompleted == false)
            {
                MessageBox.Show("Preencha o campo Rg", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkRG.Focus();
                return false;
            }
            if (tbEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmail.Focus();
                return false;
            }
            if (tbNumeroCasa.Text == String.Empty)
            {
                MessageBox.Show("Preencha o campo N°", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNumeroCasa.Focus();
                return false;
            }
            if (tbBairro.Text == "")
            {
                MessageBox.Show("Preencha o campo Categoria Bairro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbBairro.Focus();
                return false;
            }
            return true;
        }

        private void cadastrarMotoristas_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            else
            {
                string SQL;
                //Comando SQL
                SQL = "Insert Into C_Motoristas (NUM_ID, NOME,RG,CPF,DATA_NASCIMENTO,TELEFONE,CELULAR,EMAIL," +
                "LOGRADOURO,NUMERO_LOGRADOURO,BAIRRO,COMPLEMENTO,CEP,CIDADE,UF,NUMERO_CNH,CATEGORIA_CNH," +
                "VENCIMENTO_CNH,VEICULO_PROPRIO,MOPP) Values";
                SQL += $"('{tbID.Text} ',' {tbNome.Text}', '{mkRG.Text}', '{mkCPF.Text}', '{dateNascimento.Text}', '{mkTelefone.Text}'" +
                    $", '{mkCelular.Text} ', ' {tbEmail.Text}', '{tbLogradouro.Text}', '{tbNumeroCasa.Text}', '{tbBairro.Text}'" +
                    $", '{tbComplemento.Text}', '{mkCEP.Text}', '{comboCidade.Text}', '{comboUF.Text}','{mkCNH.Text}', '{comboCNH.Text}'" +
                    $", '{dateVencimentoCNH.Text}', '{comboVeiculoProprio.Text}', '{comboMOPP.Text}')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentMotorista);
                atualizarIDMotorista();
            }
        }

    }
}
