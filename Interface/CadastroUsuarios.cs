using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class CadastroUsuarios : UserControl
    {
        readonly Utilidades utils = new();

        LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            get { return Type; }

            set
            {
                Type = value;

                cadastrarUsuario.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentUsuario.Location = new Point(0, 0);

                    mkCPF.ReadOnly = false;
                    mkCPF.Cursor = Cursors.IBeam;
                    buscarCPF.Visible = false;
                }

                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentUsuario.Location = new Point(0, 62);

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
                searchUsuario.Text = value["CPF"].ToString();

                if (value != null)
                {
                    searchUsuario.Text = value["CPF"].ToString();

                    tbNome.Text = value["Nome"].ToString();
                    mkCelular.Text = value["Num_Cel"].ToString();
                    tbEmail.Text = value["Email"].ToString();
                    tbSenha.Text = value["Senha"].ToString();
                    tbSenhaConfirmacao.Text = tbSenha.Text;
                }
            }
        }

        public CadastroUsuarios()
        {
            InitializeComponent();

            tbSenha.PasswordChar = '*';
            tbSenhaConfirmacao.PasswordChar = '*';
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
        private void buscarCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCPF);
        }

        private void cadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && validar())
            {
                string SQL = "insert into Usuario (CPF, Nome, Senha, Num_Cel, Email) values";
                SQL += "('" + mkCPF.Text + "','" + tbNome.Text + "','" + tbSenha.Text + "','" + mkCelular.Text + "','" + tbEmail.Text + "')";

                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                LimparFormularios limpar = new();

                limpar.CleanControl(contentUsuario);
                limpar.CleanControl(searchPanel);
            }

            if (Type.Contains("Update") && validar())
            {
                string SQLUp = $"UPDATE Usuario SET " +
                $"Nome= '{tbNome.Text}', " +
                $"Email= '{tbEmail.Text}', " +
                $"Num_Cel= '{mkCelular.Text}', " +
                $"Senha= '{tbSenha.Text}' " +
                $"WHERE CPF = '{searchUsuario.Text.Replace('.', ',')}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentUsuario);
                limpar.CleanControl(searchPanel);
            }
        }
        private void buscarCPF_Click(object sender, EventArgs e)
        {
            if (searchUsuario.MaskCompleted)
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM Usuario WHERE CPF = '{searchUsuario.Text}'", contentUsuario)!;

                if (dados != null)
                {
                    searchUsuario.Text = dados["CPF"].ToString();

                    tbNome.Text = dados["Nome"].ToString();
                    tbEmail.Text = dados["Email"].ToString();
                    mkCelular.Text = dados["Num_Cel"].ToString();
                    tbSenha.Text = dados["Senha"].ToString();
                    tbSenhaConfirmacao.Text = tbSenha.Text;
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
            }
        }

        private void searchUsuario_TextChanged(object sender, EventArgs e)
        {
            mkCPF.Text = searchUsuario.Text;

            utils.feedbackColorInput(searchUsuario, typeData);
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            searchUsuario.Focus();
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

            if (tbSenha.Text != tbSenhaConfirmacao.Text)
            {
                MessageBox.Show("As senha não se correspondem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSenha.Focus();
                return false;
            }

            return true;
        }
    }
}
