using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Properties;
using Interface.TemplateComponents;
using Interface.Utilities;
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
            List<string> notValidar = new();
            notValidar.Add(mkTelefone.Name);
            notValidar.Add(tbComplemento.Name);
            if (Type.Contains("Cadastro") && Validation.Validar(contentCNPJ, notValidar) && Validation.validarTelefone(mkTelefone))
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

            if (Type.Contains("Update") && Validation.Validar(contentCNPJ, notValidar) && Validation.validarTelefone(mkTelefone))
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
            MasckedboxTemplete? inputMask = Parent.Controls["searchPanel"].Controls["panelSerch"].Controls["mkBoxCdClientSearch"] as MasckedboxTemplete;

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
