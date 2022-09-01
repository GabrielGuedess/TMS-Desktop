using Interface.Properties;
using System.Runtime.ConstrainedExecution;

namespace Interface
{
    public partial class CadastroUsuarios : UserControl
    {
        readonly Utilidades utils = new();

        public string TypeControl
        {
            set
            {
                cadastrarUsuario.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentUsuario.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentUsuario.Location = new Point(0, 62);
                }
            }
        }

        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void CadastroUsuarios_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelBorderRoundedNome, panelBorderRoundedCelular);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarUsuario_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarUsuario);
        }
        private bool validar()
        {
            if (tbNome.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Focus();
                return false;
            }
            if (tbSenha.Text == string.Empty)
            {
                MessageBox.Show("O campo Senha é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSenha.Focus();
                return false;
            }
            if (mkCPF.Text == string.Empty)
            {
                MessageBox.Show("O campo CPF é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
                return false;
            }
            if (mkCelular.Text == string.Empty)
            {
                MessageBox.Show("O campo Celular é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCelular.Focus();
                return false;
            }
            if (tbEmail.Text == string.Empty)
            {
                MessageBox.Show("O campo E-mail é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEmail.Focus();
                return false;
            }

            if(tbSenha.Text != tbSenhaConfirmacao.Text)
            {
                MessageBox.Show("As senha não se correspondem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSenha.Focus();
                return false;
            }
            return true;
        }

        private void cadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            else
            {
                string SQL = "insert into Usuario (CPF, Nome, Senha, Num_Cel, Email) values";
                SQL += "('" + mkCPF.Text + "','" + tbNome.Text + "','" + tbSenha.Text + "','" + mkCelular.Text + "','" + tbEmail.Text + "')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentUsuario);
            }
        }
    }
}
