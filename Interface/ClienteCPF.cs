using Interface.Properties;

namespace Interface
{
    public partial class UserControl1 : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set { cadastrarCPF.Text = value; }
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

        private void cadastrar_Click(object sender, EventArgs e)
        {
            if (cadastrarCPF.Text == "Cadastro")
            {
                cadastrarCPF.Text = "1Cadastro";
            }

            if (cadastrarCPF.Text == "Update")
            {
                cadastrarCPF.Text = "2Update";
            }

            if (validar() == false)
            {
                return;
            }
            else
            {
                string SQL = "insert into Clientes_Fisicos (Nome, CPF, RG, Data_Nasc, Genero, CEP, Logradouro, Numero," +
                    " Bairro, UF, Cidade, Email, Telefone, Celular, Complemento) values";
                SQL += $"('{tbNome.Text}','{mkCPF.Text}', '{mkRG.Text}', " +
                    $"'{dateNascimento.Text}', '{comboGenero.Text}', '{mkCEP.Text}', " +
                    $"'{tbLogradouro.Text}', '{tbNumCasa.Text}', '{tbBairro.Text}', " +
                    $"'{comboUF.Text}', '{comboCidade.Text}', '{tbEmail.Text}', '{mkTelefone.Text}', " +
                    $"'{mkCelular.Text}', '{tbComplemento.Text}')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentCPF);
            }
        }

        private bool validar()
        {
            if(mkCPF.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo CPF corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
                return false;
            }
            if (tbNome.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Nome corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Focus();
                return false;
            }
            if (dateNascimento.Text == " ")
            {
                MessageBox.Show("É necessário preencher o campo Data de Nascimento corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNascimento.Focus();
                return false;
            }
            if (comboGenero.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Genero corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboGenero.Focus();
                return false;
            }
            if (mkRG.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo RG corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkRG.Focus();
                return false;
            }
            if (mkTelefone.Text.Length >1 && mkTelefone.Text.Length <10)
            {
                MessageBox.Show("É necessário preencher o campo Telefone corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkTelefone.Focus();
                return false;
            }
            if (mkCelular.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo Celular corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCelular.Focus();
                return false;
            }
            if (tbEmail.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Email corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmail.Focus();
                return false;
            }
            if (mkCEP.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo CEP corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCEP.Focus();
                return false;
            }
            if (comboUF.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo UF corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboUF.Focus();
                return false;
            }
            if (comboCidade.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Cidade corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCidade.Focus();
                return false;
            }
            if (tbLogradouro.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Logradouro corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLogradouro.Focus();
                return false;
            }
            if (tbNumCasa.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo N° corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNumCasa.Focus();
                return false;
            }
            if (tbLogradouro.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Logradouro corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLogradouro.Focus();
                return false;
            }
            if (tbBairro.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Bairro corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbLogradouro.Focus();
                return false;
            }
            return true;
        }
    }
}
