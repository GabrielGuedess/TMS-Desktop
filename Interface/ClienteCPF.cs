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
                string SQL = "insert into Pessoa_Juridica (Nome, CPF, RG, Data_Nasc, Genero, CEP, Logradouro, Numero," +
                    " Bairro, UF, Cidade, Email, Telefone, Celular, Complemento) values";
                SQL += "('" + mkCNPJ.Text + "','" + tbRazaoSocial.Text + "" +
                    "','" + tbNomeFantasia.Text + "','" + mkInscricaoEstatudal.Text + "','"
                    + mkTelefone.Text + "','" + comboSituacaoCNPJ.Text + "','" + mkCelular.Text + "','"
                    + tbEmail.Text + "','" + mkCEP.Text + "','" + tbLogradouro.Text + "','" + tbNumCasa.Text + "" +
                    "','" + tbComplemento.Text + "','" + tbBairro.Text + "','" + comboCidade.Text + "','"
                    + comboUF.Text + "')";
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
            if (dateNascimento.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Data de Nascimento corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNascimento.Focus();
                return false;
            }
            if (comboGemero.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Genero corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboGemero.Focus();
                return false;
            }
            if (mkRG.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo RG corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkRG.Focus();
                return false;
            }
            if (mkTelefone.MaskCompleted == false)
            {
                MessageBox.Show("É necessário preencher o campo Telefone corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkTelefone.Focus();
                return false;
            }
            if (tbNomeEmail.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Email corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNomeEmail.Focus();
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
            if (tbBairro.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher o campo Bairro corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbBairro.Focus();
                return false;
            }
            return true;
        }
    }
}
