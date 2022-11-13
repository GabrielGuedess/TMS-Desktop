using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Properties;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class CadastroMotoristas : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        readonly ConnectDB DBFunctions = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {

                Type = value;

                cadastrarMotoristas.Text = value;

                if (value.Contains("Cadastro"))
                {
                    //tbID.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Motoristas", "m");
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
                    tbID.Text = value["NUM_ID"].ToString();
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
                    tbNumCasa.Text = value["NUMERO_LOGRADOURO"].ToString();
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



        private void cadastrarMotoristas_Click(object sender, EventArgs e)
        {
            List<string> notValidar = new();
            notValidar.Add(tbComplemento.Name);
            notValidar.Add(mkTelefone.Name);
            if (Type.Contains("Cadastro") && Validation.Validar(contentMotorista, notValidar))
            {
                string SQL = "Insert Into C_Motoristas (NUM_ID, NOME,RG,CPF,DATA_NASCIMENTO,TELEFONE,CELULAR,EMAIL," +
                "LOGRADOURO,NUMERO_LOGRADOURO,BAIRRO,COMPLEMENTO,CEP,CIDADE,UF,NUMERO_CNH,CATEGORIA_CNH," +
                "VENCIMENTO_CNH,VEICULO_PROPRIO,MOPP) Values";
                SQL += $"('{tbID.Text} ',' {tbNome.Text}', '{mkRG.Text}', '{mkCPF.Text}', '{dateNascimento.Text}', '{mkTelefone.Text}'" +
                    $", '{mkCelular.Text} ', ' {tbEmail.Text}', '{tbLogradouro.Text}', '{tbNumCasa.Text}', '{tbBairro.Text}'" +
                    $", '{tbComplemento.Text}', '{mkCEP.Text}', '{comboCidade.Text}', '{comboUF.Text}','{mkCNH.Text}', '{comboCNH.Text}'" +
                    $", '{dateVencimentoCNH.Text}', '{comboVeiculoProprio.Text}', '{comboMOPP.Text}')";

                DBFunctions.cadastrar(SQL);

                limpar.CleanControl(contentMotorista);
                limpar.CleanControl(searchPanel);

                //tbID.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Motoristas", "m");
            }

            if (Type.Contains("Update") && Validation.Validar(contentMotorista, notValidar) && Validation.validarTelefone(mkTelefone))
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
                $"NUMERO_LOGRADOURO= '{tbNumCasa.Text}', " +
                $"BAIRRO= '{tbBairro.Text}', " +
                $"COMPLEMENTO= '{tbComplemento.Text}', " +

                $"NUMERO_CNH= '{mkCNH.Text}', " +
                $"CATEGORIA_CNH= '{comboCNH.Text}', " +
                $"VENCIMENTO_CNH= '{dateVencimentoCNH.Text}', " +
                $"VEICULO_PROPRIO= '{comboVeiculoProprio.Text}', " +
                $"MOPP= '{comboMOPP.Text}' " +
                $"WHERE CPF = '{maskInput.Text.Replace('.', ',')}'";

                DBFunctions.cadastrar(SQLUp);

                limpar.CleanControl(contentMotorista);
                limpar.CleanControl(searchPanel);
                //tbID.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Motoristas", "m");
            }
        }

        private void buscarCPF_Click(object sender, EventArgs e)
        {
            if (maskInput.MaskCompleted)
            {
                DataRow dados = DBFunctions.pesquisarRow($"SELECT * FROM C_Motoristas WHERE CPF = '{maskInput.Text}'", contentMotorista)!;

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
                    tbNumCasa.Text = dados["NUMERO_LOGRADOURO"].ToString();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mkCEP.MaskCompleted)
            {
                ClientCEP clientCEP = new();
                var result = clientCEP.getCEP(mkCEP.Text);
                if (result.UF == null)
                {
                    return;
                }
                tbBairro.Text = result.Bairro;
                comboCidade.Text = result.Cidade;
                comboUF.Text = result.UF;
                tbLogradouro.Text = result.Logradouro;
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo CEP corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
