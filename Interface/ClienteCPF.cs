using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class UserControl1 : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            get { return Type; }

            set
            {

                Type = value;

                if (Type.Contains("Update"))
                {
                    mkCPF.ReadOnly = true;
                    mkCPF.Cursor = Cursors.No;
                    buscarCPF.Visible = true;
                }
                else
                {
                    mkCPF.ReadOnly = false;
                    mkCPF.Cursor = Cursors.IBeam;
                    buscarCPF.Visible = false;
                }

                cadastrarCPF.Text = Type;
            }
        }

        public DataRow DataForUpdate
        {
            set
            {
                if (value != null)
                {
                    mkCPF.Text = value["CPF"].ToString();
                    tbNome.Text = value["Nome"].ToString();
                    dateNascimento.Text = value["Data_Nasc"].ToString();
                    comboGenero.Text = value["Genero"].ToString();
                    mkRG.Text = value["RG"].ToString();
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

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            utils.expansivePanels(10, panel51, panelTextCPFClient,
            panelTextNomeClient, panelDateTimerClient, panelTextRGClient, panelTextTelefoneCLient,
            panelTextEmailClient, panelTextCEPClient, panelTextEnderecoClient);
        }

        private void cadastrar_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarCPF);
        }

        private void buscarCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCPF);
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            List<string> notValidar = new();
            notValidar.Add(mkTelefone.Name);
            notValidar.Add(tbComplemento.Name);
            if (Type.Contains("Cadastro") && Validation.Validar(contentCPF, notValidar))
            {
                string SQL = "insert into Clientes_Fisicos (Nome, CPF, RG, Data_Nasc, Genero, CEP, Logradouro, Numero," +
                    " Bairro, UF, Cidade, Email, Telefone, Celular, Complemento) values";

                SQL += $"('{tbNome.Text}','{mkCPF.Text}', '{mkRG.Text}', " +
                    $"'{dateNascimento.Text}', '{comboGenero.Text}', '{mkCEP.Text}', " +
                    $"'{tbLogradouro.Text}', '{tbNumCasa.Text}', '{tbBairro.Text}', " +
                    $"'{comboUF.Text}', '{comboCidade.Text}', '{tbEmail.Text}', '{mkTelefone.Text}', " +
                    $"'{mkCelular.Text}', '{tbComplemento.Text}')";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentCPF);
                limpar.CleanControl(Parent.Controls["searchPanel"].Controls["panelSerch"]);
            }

            if (Type.Contains("Update") && Validation.Validar(contentCPF, notValidar))
            {
                string SQLUp = $"UPDATE Clientes_Fisicos SET " +
                $"Nome= '{tbNome.Text}', " +
                $"RG= '{mkRG.Text}', " +
                $"Data_Nasc= '{dateNascimento.Text}', " +
                $"Genero= '{comboGenero.Text}', " +
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
                $"WHERE CPF = '{mkCPF.Text.Replace('.', ',')}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentCPF);
                limpar.CleanControl(Parent.Controls["searchPanel"].Controls["panelSerch"]);
            }
        }
        private void buscarCPF_Click(object sender, EventArgs e)
        {
            masckedboxTemplete? inputMask = Parent.Controls["searchPanel"].Controls["panelSerch"].Controls["mkBoxCdClientSearch"] as masckedboxTemplete;

            if (inputMask!.MaskCompleted)
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM Clientes_Fisicos WHERE CPF = '{inputMask.Text}'", contentCPF)!;

                if (dados != null)
                {
                    mkCPF.Text = dados["CPF"].ToString();
                    tbNome.Text = dados["Nome"].ToString();
                    dateNascimento.Text = dados["Data_Nasc"].ToString();
                    comboGenero.Text = dados["Genero"].ToString();
                    mkRG.Text = dados["RG"].ToString();
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
                MessageBox.Show("É necessário preencher o campo CPF corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
            }
        }
    }
}
