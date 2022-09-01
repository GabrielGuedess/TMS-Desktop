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

        private bool validar()
        {
            if (mkCPF.Text.Length < 11)
            {
                MessageBox.Show("CPF digitado é invalido");
                return false;
            }
            if (mkCelular.Text.Length < 11)
            {
                MessageBox.Show("Celular digitado é inválido");
                return false;
            }
            if (mkTelefone.Text.Length > 1 && mkTelefone.Text.Length < 10)
            {
                MessageBox.Show("Telefone digitado é inválido");
                return false;
            }
            if (mkCEP.Text.Length < 8)
            {
                MessageBox.Show("CEP digitado é inválido");
                return false;
            }
            if (mkCNH.Text.Length < 10)
            {
                MessageBox.Show("CNH digitada é inválido");
                return false;
            }
            if (dateVencimentoCNH.Text == " ")
            {
                MessageBox.Show("Preencha o campo de Vencimento da CNH");
                return false;
            }
            if (comboVeiculoProprio.Text == "")
            {
                MessageBox.Show("Preencha o campo veiculo próprio");
                return false;
            }
            if (comboMOPP.Text == "")
            {
                MessageBox.Show("Preencha o campo Curso MOPP");
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
            }
        }

    }
}
