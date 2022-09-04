using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class CadastroMotoristas : UserControl
    {
        readonly Utilidades utils = new();

        LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                cadastrarMotoristas.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentMotorista.Location = new Point(0, 0);

                    mkCPF.ReadOnly = false;
                    mkCPF.Cursor = Cursors.IBeam;
                    buscarCPF.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentMotorista.Location = new Point(0, 62);

                    mkCPF.ReadOnly = true;
                    mkCPF.Cursor = Cursors.No;
                    buscarCPF.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                maskInput.Text = value["CPF"].ToString();

                if (value != null)
                {
                    tbID.Text = value["ID"].ToString();
                    tbNome.Text = value["Nome"].ToString();
                    dateNascimento.Text = value["DATA_NASCIMENTO"].ToString();
                    mkCPF.Text = value["CPF"].ToString();
                    mkRG.Text = value["RG"].ToString();
                    mkTelefone.Text = value["TELEFONE"].ToString();
                    mkCelular.Text = value["CELULAR"].ToString();
                    tbEmail.Text = value["EMAIL"].ToString();
                    mkCEP.Text = value["CEP"].ToString();
                    comboUF.Text = value["UF"].ToString();
                    comboCidade.Text = value["CIDADE"].ToString();
                    tbLogradouro.Text = value["LOGRADOURO"].ToString();
                    tbNumeroCasa.Text = value["NUMERO_LOGRADOURO"].ToString();
                    tbBairro.Text = value["BAIRRO"].ToString();
                    tbComplemento.Text = value["COMPLEMENTO"].ToString();

                    mkCNH.Text = value["NUMERO_CNH"].ToString();
                    comboCNH.SelectedItem = value["CATEGORIA_CNH"].ToString();
                    dateVencimentoCNH.Text = value["VENCIMENTO_CNH"].ToString();
                    comboVeiculoProprio.Text = value["VEICULO_PROPRIO"].ToString();
                    comboMOPP.SelectedItem = value["MOPP"].ToString();
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
        private void buscarCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCPF);
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

        private void cadastrarMotoristas_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && validar())
            {
                string SQL = "Insert Into C_Motoristas (NUM_ID, NOME,RG,CPF,DATA_NASCIMENTO,TELEFONE,CELULAR,EMAIL," +
                "LOGRADOURO,NUMERO_LOGRADOURO,BAIRRO,COMPLEMENTO,CEP,CIDADE,UF,NUMERO_CNH,CATEGORIA_CNH," +
                "VENCIMENTO_CNH,VEICULO_PROPRIO,MOPP) Values";
                SQL += $"('{tbID.Text} ',' {tbNome.Text}', '{mkRG.Text}', '{mkCPF.Text}', '{dateNascimento.Text}', '{mkTelefone.Text}'" +
                    $", '{mkCelular.Text} ', ' {tbEmail.Text}', '{tbLogradouro.Text}', '{tbNumeroCasa.Text}', '{tbBairro.Text}'" +
                    $", '{tbComplemento.Text}', '{mkCEP.Text}', '{comboCidade.Text}', '{comboUF.Text}','{mkCNH.Text}', '{comboCNH.Text}'" +
                    $", '{dateVencimentoCNH.Text}', '{comboVeiculoProprio.Text}', '{comboMOPP.Text}')";

                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentMotorista);
                limpar.CleanControl(searchPanel);

                atualizarIDMotorista();
            }

            if (Type.Contains("Update") && validar())
            {
                string SQLUp = $"UPDATE C_Motoristas SET " +
                $"NUM_ID= '{tbID.Text}', " +
                $"Nome= '{tbNome.Text}', " +
                $"DATA_NASCIMENTO= '{dateNascimento.Text}', " +
                $"RG= '{mkRG.Text}', " +
                $"TELEFONE= '{mkTelefone.Text}', " +
                $"CELULAR= '{mkCelular.Text}', " +
                $"EMAIL= '{tbEmail.Text}', " +
                $"CEP= '{mkCEP.Text}', " +
                $"UF= '{comboUF.Text}', " +
                $"CIDADE= '{comboCidade.Text}', " +
                $"LOGRADOURO= '{tbLogradouro.Text}', " +
                $"NUMERO_LOGRADOURO= '{tbNumeroCasa.Text}', " +
                $"BAIRRO= '{tbBairro.Text}', " +
                $"COMPLEMENTO= '{tbComplemento.Text}', " +

                $"NUMERO_CNH= '{mkCNH.Text}', " +
                $"CATEGORIA_CNH= '{comboCNH.Text}', " +
                $"VENCIMENTO_CNH= '{dateVencimentoCNH.Text}', " +
                $"VEICULO_PROPRIO= '{comboVeiculoProprio.Text}', " +
                $"MOPP= '{comboMOPP.Text}' " +
                $"WHERE CPF = '{maskInput.Text.Replace('.', ',')}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentMotorista);
                limpar.CleanControl(searchPanel);
            }
        }

        private void buscarCPF_Click(object sender, EventArgs e)
        {
            if (maskInput.MaskCompleted)
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM C_Motoristas WHERE CPF = '{maskInput.Text}'", contentMotorista)!;

                if (dados != null)
                {
                    maskInput.Text = dados["CPF"].ToString();

                    tbID.Text = dados["NUM_ID"].ToString();
                    tbNome.Text = dados["Nome"].ToString();
                    dateNascimento.Text = dados["DATA_NASCIMENTO"].ToString();
                    mkRG.Text = dados["RG"].ToString();
                    mkTelefone.Text = dados["TELEFONE"].ToString();
                    mkCelular.Text = dados["CELULAR"].ToString();
                    tbEmail.Text = dados["EMAIL"].ToString();
                    mkCEP.Text = dados["CEP"].ToString();
                    comboUF.Text = dados["UF"].ToString();
                    comboCidade.Text = dados["CIDADE"].ToString();
                    tbLogradouro.Text = dados["LOGRADOURO"].ToString();
                    tbNumeroCasa.Text = dados["NUMERO_LOGRADOURO"].ToString();
                    tbBairro.Text = dados["BAIRRO"].ToString();
                    tbComplemento.Text = dados["COMPLEMENTO"].ToString();

                    mkCNH.Text = dados["NUMERO_CNH"].ToString();
                    comboCNH.SelectedItem = dados["CATEGORIA_CNH"].ToString();
                    dateVencimentoCNH.Text = dados["VENCIMENTO_CNH"].ToString();
                    comboVeiculoProprio.Text = dados["VEICULO_PROPRIO"].ToString();
                    comboMOPP.SelectedItem = dados["MOPP"].ToString();
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
            }
        }
        private void typeData_Click(object sender, EventArgs e)
        {
            maskInput.Focus();
        }
        private void maskInput_TextChanged(object sender, EventArgs e)
        {
            mkCPF.Text = maskInput.Text;

            utils.feedbackColorInput(maskInput, typeData);
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
    }
}
