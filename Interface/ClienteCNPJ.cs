using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class ClienteCNPJ : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                if (Type.Contains("Update"))
                {
                    mkCNPJ.ReadOnly = true;
                    mkCNPJ.Cursor = Cursors.No;
                    buscarCNPJ.Visible = true;
                }
                else
                {
                    mkCNPJ.ReadOnly = false;
                    mkCNPJ.Cursor = Cursors.IBeam;
                    buscarCNPJ.Visible = false;
                }

                cadastrarCNPJ.Text = Type;
            }
        }

        public DataRow DataForUpdate
        {
            set
            {
                if (value != null)
                {
                    mkCNPJ.Text = value["CNPJ"].ToString();
                    comboSituacaoCNPJ.Text = value["Situacao"].ToString();
                    tbNomeFantasia.Text = value["N_Fantasia"].ToString();
                    mkInscricaoEstatudal.Text = value["I_Estadual"].ToString();
                    tbRazaoSocial.Text = value["R_Social"].ToString();
                    mkTelefone.Text = value["Telefone"].ToString();
                    mkCelular.Text = value["Celular"].ToString();
                    tbEmail.Text = value["Email"].ToString();
                    mkCEP.Text = value["CEP"].ToString();
                    comboUF.Text = value["UF"].ToString();
                    comboCidade.Text = value["Cidade"].ToString();
                    tbLogradouro.Text = value["Logradouro"].ToString();
                    tbNumCasa.Text = value["Numero"].ToString();
                    tbBairro.Text = value["Bairro"].ToString();
                    tbComplemento.Text = value["Complemento"].ToString();
                }
            }
        }

        public ClienteCNPJ()
        {
            InitializeComponent();
        }

        private void cadastrarCNPJ_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarCNPJ);
        }

        private void buscarCNPJ_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCNPJ);
        }

        private void cadastrarCNPJ_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && validar())
            {
                string SQL = "insert into Pessoa_Juridica (CNPJ, Raz_Soc, Nom_Fan, Ins_Est, Tel, Situacao, Num_Cel, Email," +
                    " CEP, Endereco, Numero, Comple, Bairro, Cidade, UF) values";
                SQL += "('" + mkCNPJ.Text + "','" + tbRazaoSocial.Text + "" +
                    "','" + tbNomeFantasia.Text + "','" + mkInscricaoEstatudal.Text + "','"
                    + mkTelefone.Text + "','" + comboSituacaoCNPJ.Text + "','" + mkCelular.Text + "','"
                    + tbEmail.Text + "','" + mkCEP.Text + "','" + tbLogradouro.Text + "','" + tbNumCasa.Text + "" +
                    "','" + tbComplemento.Text + "','" + tbBairro.Text + "','" + comboCidade.Text + "','"
                    + comboUF.Text + "')";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentCNPJ);
                limpar.CleanControl(Parent.Controls["searchPanel"].Controls["panelSerch"]);
            }

            if (Type.Contains("Update") && validar())
            {
                string SQLUp = $"UPDATE Clientes_Juridicos SET " +
                $"N_Fantasia = '{tbNomeFantasia.Text}', " +
                $"R_Social = '{tbRazaoSocial.Text}', " +
                $"I_Estadual= '{mkInscricaoEstatudal.Text}', " +
                $"Situacao= '{comboSituacaoCNPJ.Text}', " +
                $"CEP= '{mkCEP.Text}', " +
                $"Logradouro= '{tbLogradouro.Text}', " +
                $"Numero= '{tbNumCasa.Text}', " +
                $"Bairro= '{tbBairro.Text}', " +
                $"UF= '{comboUF.Text}', " +
                $"Cidade= '{comboCidade.Text}', " +
                $"Email= '{tbEmail.Text}', " +
                $"Telefone= '{mkTelefone.Text}', " +
                $"Celular= '{mkCelular.Text}', " +
                $"Complemento= '{tbComplemento.Text}' " +
                $"WHERE CNPJ = '{mkCNPJ.Text.Replace('.', ',')}'";


                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentCNPJ);
                limpar.CleanControl(Parent.Controls["searchPanel"].Controls["panelSerch"]);
            }

        }
        private void buscarCNPJ_Click(object sender, EventArgs e)
        {
            masckedboxTemplete? inputMask = Parent.Controls["searchPanel"].Controls["panelSerch"].Controls["mkBoxCdClientSearch"] as masckedboxTemplete;

            if (inputMask!.MaskCompleted)
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM Clientes_Juridicos WHERE CNPJ = '{inputMask.Text}'", contentCNPJ)!;

                if (dados != null)
                {
                    mkCNPJ.Text = dados["CNPJ"].ToString();
                    tbNomeFantasia.Text = dados["N_Fantasia"].ToString();
                    mkInscricaoEstatudal.Text = dados["I_Estadual"].ToString();
                    tbRazaoSocial.Text = dados["R_Social"].ToString();
                    mkTelefone.Text = dados["Telefone"].ToString();
                    mkCelular.Text = dados["Celular"].ToString();
                    tbEmail.Text = dados["Email"].ToString();
                    mkCEP.Text = dados["CEP"].ToString();
                    comboUF.Text = dados["UF"].ToString();
                    comboCidade.Text = dados["Cidade"].ToString();
                    tbLogradouro.Text = dados["Logradouro"].ToString();
                    tbNumCasa.Text = dados["Numero"].ToString();
                    tbBairro.Text = dados["Bairro"].ToString();
                    tbComplemento.Text = dados["Complemento"].ToString();
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher o campo CNPJ corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCNPJ.Focus();
            }
        }

        private bool validar()
        {
            if (mkCNPJ.Text.Length < 14)
            {
                MessageBox.Show("O campo CNPF é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCNPJ.Focus();
                return false;
            }
            if (tbRazaoSocial.Text == string.Empty)
            {
                MessageBox.Show("O campo Razão Social é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbRazaoSocial.Focus();
                return false;
            }

            if (tbNomeFantasia.Text == "")
            {
                MessageBox.Show("O campo Nome Fantasia é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNomeFantasia.Focus();
                return false;
            }
            if (mkTelefone.Text.Length > 1 && mkTelefone.Text.Length < 10)
            {
                MessageBox.Show("O campo Telefone é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkTelefone.Focus();
                return false;
            }
            if (mkCelular.MaskCompleted == false)
            {
                MessageBox.Show("O campo Celular é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCelular.Focus();
                return false;
            }
            if (mkInscricaoEstatudal.MaskCompleted == false)
            {
                MessageBox.Show("O campo Inscrição Estadual é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkInscricaoEstatudal.Focus();
                return false;
            }
            if (comboSituacaoCNPJ.Text == string.Empty)
            {
                MessageBox.Show("O campo Situação é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboSituacaoCNPJ.Focus();
                return false;
            }
            if (tbEmail.Text == string.Empty)
            {
                MessageBox.Show("O campo Email é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmail.Focus();
                return false;
            }
            if (mkCEP.MaskCompleted == false)
            {
                MessageBox.Show("O campo CEP é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCEP.Focus();
                return false;
            }
            if (tbNumCasa.Text == string.Empty)
            {
                MessageBox.Show("O campo Num é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNumCasa.Focus();
                return false;
            }
            if (tbBairro.Text == string.Empty)
            {
                MessageBox.Show("O campo Bairro é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbBairro.Focus();
                return false;
            }
            if (comboCidade.Text == string.Empty)
            {
                MessageBox.Show("O campo Cidade é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCidade.Focus();
                return false;
            }
            if (comboUF.Text == string.Empty)
            {
                MessageBox.Show("O campo UF é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboUF.Focus();
                return false;
            }
            if (mkCNPJ.MaskCompleted == false)
            {
                MessageBox.Show("O campo CNPJ é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCNPJ.Focus();
                return false;
            }
            if (tbLogradouro.Text == string.Empty)
            {
                MessageBox.Show("O campo Logradouro é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLogradouro.Focus();
                return false;
            }
            return true;
        }
    }
}
