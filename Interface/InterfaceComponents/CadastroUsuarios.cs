using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
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
            try { 
                List<string> notValidar = new();
                notValidar.Add(tbSenhaConfirmacao.Name);
                if (Type.Contains("Cadastro") && Validation.Validar(contentUsuario, notValidar))
                {
               
                    TMSContext db = new();
                    int lastID = 0;
                    if (db.Usuario.Count() > 0)
                    {
                        lastID = db.Usuario.Max(id => id.ID_usuario) + 1;
                    }

                    Usuario usuario = new Usuario
                    {
                        ID_usuario = lastID,
                        Nome = tbNome.Text,
                        Email = tbEmail.Text,
                        Senha = tbSenha.Text,
                        Telefone = "qualquer",
                        CPF = mkCPF.Text,
                        User_name = "qualquer",
                        Celular = mkCelular.Text
                        
                    };
                    
                    db.Usuario.Add(usuario);
                    db.SaveChanges();

                    limpar.CleanControl(contentUsuario);
                    limpar.CleanControl(searchPanel);
               
                }
                else if (Type.Contains("Update") && Validation.Validar(contentUsuario, notValidar))
                {
                    TMSContext db = new();
                    Usuario usuario = db.Usuario.FirstOrDefault(a => a.CPF == mkCPF.Text);
                    if (usuario == null)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    usuario.Nome = tbNome.Text;
                    usuario.CPF = mkCPF.Text;
                    usuario.Email = tbEmail.Text;
                    usuario.Celular = mkCelular.Text;
                    usuario.Senha = tbSenha.Text;
                

                    db.SaveChanges();

                    limpar.CleanControl(contentUsuario);
                    limpar.CleanControl(searchPanel);
                }
            }
            catch (DbUpdateException erro)
            {
                if (typeof(MySqlException).IsInstanceOfType(erro.InnerException))
                {
                    MySqlException mySqlException = (MySqlException)erro.InnerException;
                    if (MySqlErrorCode.DuplicateKeyEntry == mySqlException.ErrorCode)
                    {
                        string campoDuplicado = mySqlException.Message.Split("'")[3];
                        string valorDoCampo = mySqlException.Message.Split("'")[1];
                        MessageBox.Show($"O valor {valorDoCampo} do campo {campoDuplicado} já cadastrado."
                            + "Adicione um valor que não estaja cadastrado");
                    }
                    else if (MySqlErrorCode.DatabaseAccessDenied == mySqlException.ErrorCode)
                    {
                        MessageBox.Show("Acesso Bloqueado");
                    }
                }
            }

        }
        private void buscarCPF_Click(object sender, EventArgs e)
        {
            if (searchUsuario.MaskCompleted)
            {
                TMSContext db = new();

                Usuario usuario= db.Usuario.FirstOrDefault(a => a.CPF == mkCPF.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado");
                    return;
                }

                tbNome.Text = usuario.Nome;
                tbEmail.Text = usuario.Email;
                mkCPF.Text = usuario.CPF;
                mkCelular.Text = usuario.Celular;
                
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

    }
}
