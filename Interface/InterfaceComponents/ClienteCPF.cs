using Interface.ControlValidationAuxiliary;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.ModelsDB;
using Interface.Properties;
using Interface.TemplateComponents;
using Interface.Utilities;
using System.Data;
using System.Data.Entity;

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
                try
                {
                    TMSContext db = new();
                    int lastID = 0;

                    if (db.ClienteFisico.Count() > 0)
                    {
                        lastID = db.ClienteFisico.Max(id => id.ID_for_cliente) + 1;
                    }

                    Cliente cliente = new Cliente
                    {
                        ID_cliente = lastID,
                        CEP = mkCEP.Text,
                        Logradouro = tbLogradouro.Text,
                        Numero_endereco = tbNumCasa.Text,
                        Bairro = tbBairro.Text,
                        Complemento_endereco = tbComplemento.Text,
                        Cidade = comboCidade.Text,
                        UF = comboUF.Text,
                    };

                    ClienteFisico clienteFisico = new ClienteFisico
                    {
                        ID_for_cliente = lastID,
                        Nome = tbNome.Text,
                        Data_nascimento = dateNascimento.convertDateOnly(),
                        Genero = comboGenero.Text,
                        RG = mkRG.Text,
                        CPF = mkCPF.Text,
                        ID_for_clienteNavigation = cliente
                    };


                    CelularCliente celular = new CelularCliente
                    {
                        Celular = mkCelular.Text,
                        ID_for_cliente = lastID
                    };

                    EmailCliente email = new EmailCliente
                    {
                        Email = tbEmail.Text,
                        ID_for_cliente = lastID
                    };


                    TelefoneCliente telefone = new TelefoneCliente
                    {
                        Telefone = mkTelefone.Text,
                        ID_for_cliente = lastID
                    };

                    cliente.CelularCliente.Add(celular);
                    cliente.EmailCliente.Add(email);

                    if (mkTelefone.Text.Length > 0)
                    {
                        cliente.TelefoneCliente.Add(telefone);
                    }

                    db.Cliente.Add(cliente);
                    db.ClienteFisico.Add(clienteFisico);

                    db.SaveChanges();

                    limpar.CleanControl(contentCPF);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if (Type.Contains("Update") && Validation.Validar(contentCPF, notValidar))
            {
                TMSContext db = new();

                ClienteFisico clienteFisico = db.ClienteFisico
                    .Include(a => a.ID_for_clienteNavigation.CEP)
                    .First(a => a.CPF == mkCPF.Text);

                TelefoneCliente telefoneCliente = db.TelefoneCliente.First(a => a.ID_for_cliente == clienteFisico.ID_for_cliente);
                CelularCliente celularCliente = db.CelularCliente.First(a => a.ID_for_cliente == clienteFisico.ID_for_cliente);
                EmailCliente emailCliente = db.EmailCliente.First(a => a.ID_for_cliente == clienteFisico.ID_for_cliente);


                if (clienteFisico == null)
                {
                    MessageBox.Show("Error");
                    return;
                }

                if (mkTelefone.Text.Length > 0)
                {
                    telefoneCliente.Telefone = mkTelefone.Text;
                }
                else
                {
                    clienteFisico.ID_for_clienteNavigation.TelefoneCliente.Clear();
                }

                clienteFisico.Nome = tbNome.Text;
                clienteFisico.CPF = mkCPF.Text;
                clienteFisico.RG = mkRG.Text;
                clienteFisico.Data_nascimento = dateNascimento.convertDateOnly();
                clienteFisico.Genero = comboGenero.Text;
                celularCliente.Celular = mkCelular.Text;
                emailCliente.Email = tbEmail.Text;
                clienteFisico.ID_for_clienteNavigation.CEP = mkCEP.Text;
                clienteFisico.ID_for_clienteNavigation.UF = comboUF.Text;
                clienteFisico.ID_for_clienteNavigation.Cidade = comboCidade.Text;
                clienteFisico.ID_for_clienteNavigation.Bairro = tbBairro.Text;
                clienteFisico.ID_for_clienteNavigation.Logradouro = tbLogradouro.Text;
                clienteFisico.ID_for_clienteNavigation.Numero_endereco = tbNumCasa.Text;
                clienteFisico.ID_for_clienteNavigation.Complemento_endereco = tbComplemento.Text;

                db.SaveChanges();

                limpar.CleanControl(contentCPF);
                limpar.CleanControl(Parent.Controls["searchPanel"].Controls["panelSerch"]);
            }
        }
        private void buscarCPF_Click(object sender, EventArgs e)
        {
            MasckedboxTemplete? inputMask = Parent.Controls["searchPanel"].Controls["panelSerch"].Controls["mkBoxCdClientSearch"] as MasckedboxTemplete;

            if (inputMask!.MaskCompleted)
            {
                TMSContext db = new();

                ClienteFisico clienteFisico = db.ClienteFisico
                    .Include(a => a.ID_for_clienteNavigation.CEP)
                    .First(a => a.CPF == mkCPF.Text);

                Cliente cliente = db.Cliente.First(a => a.ClienteFisico.CPF == clienteFisico.CPF);

                TelefoneCliente telefoneCliente = db.TelefoneCliente.First(a => a.ID_for_cliente == clienteFisico.ID_for_cliente);
                CelularCliente celularCliente = db.CelularCliente.First(a => a.ID_for_cliente == clienteFisico.ID_for_cliente);
                EmailCliente emailCliente = db.EmailCliente.First(a => a.ID_for_cliente == clienteFisico.ID_for_cliente);


                if (clienteFisico == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                    return;
                }

                mkCPF.Text = clienteFisico.CPF;
                tbNome.Text = clienteFisico.Nome;
                dateNascimento.Text = clienteFisico.Data_nascimento.ToString();
                comboGenero.SelectedText = clienteFisico.Genero;
                mkRG.Text = clienteFisico.RG;
                mkTelefone.Text = telefoneCliente.Telefone;
                mkCelular.Text = celularCliente.Celular;
                tbEmail.Text = emailCliente.Email;
                mkCEP.Text = cliente.CEP;
                comboUF.Text = cliente.UF;
                comboCidade.Text = cliente.Cidade;
                tbLogradouro.Text = cliente.Logradouro;
                tbNumCasa.Text = cliente.Numero_endereco;
                tbBairro.Text = cliente.Bairro;
                tbComplemento.Text = cliente.Complemento_endereco;

            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {labelCPFClient.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
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
