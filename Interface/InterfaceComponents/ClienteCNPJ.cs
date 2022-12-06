using Interface.ControlValidationAuxiliary;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Properties;
using Interface.TemplateComponents;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
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
                try
                {
                    TMSContext db = new();

                    int lastID = 0;

                    if (db.ClienteJuridico.Count() > 0)
                    {
                        lastID = db.ClienteJuridico.Max(id => id.ID_for_cliente) + 1;
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
                        Tipo_cliente = "J",
                        UF = comboUF.Text,
                    };

                    ClienteJuridico clienteJuridico = new ClienteJuridico
                    {
                        ID_for_cliente = lastID,
                        Nome_fantasia = tbNomeFantasia.Text,
                        Inscricao_estadual = mkInscricaoEstatudal.Text,
                        Razao_social = tbRazaoSocial.Text,
                        CNPJ = mkCNPJ.Text,
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
                    db.ClienteJuridico.Add(clienteJuridico);

                    db.SaveChanges();

                    limpar.CleanControl(contentCNPJ);
                    limpar.CleanControl(Parent.Controls["searchPanel"].Controls["panelSerch"]);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if (Type.Contains("Update") && Validation.Validar(contentCNPJ, notValidar) && Validation.validarTelefone(mkTelefone))
            {
                TMSContext db = new();

                ClienteJuridico clienteJuridico = db.ClienteJuridico.First(a => a.CNPJ == mkCNPJ.Text);

                Cliente cliente = db.Cliente.First(a => a.ClienteJuridico!.CNPJ == clienteJuridico.CNPJ);

                TelefoneCliente telefoneCliente = db.TelefoneCliente.First(a => a.ID_for_cliente == clienteJuridico.ID_for_cliente);
                CelularCliente celularCliente = db.CelularCliente.First(a => a.ID_for_cliente == clienteJuridico.ID_for_cliente);
                EmailCliente emailCliente = db.EmailCliente.First(a => a.ID_for_cliente == clienteJuridico.ID_for_cliente);


                if (clienteJuridico == null)
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
                    cliente.TelefoneCliente.Clear();
                }

                clienteJuridico.Nome_fantasia = tbNomeFantasia.Text;
                clienteJuridico.CNPJ = mkCNPJ.Text;
                clienteJuridico.Razao_social = tbRazaoSocial.Text;
                clienteJuridico.Inscricao_estadual = mkInscricaoEstatudal.Text;
                celularCliente.Celular = mkCelular.Text;
                emailCliente.Email = tbEmail.Text;
                cliente.CEP = mkCEP.Text;
                cliente.UF = comboUF.Text;
                cliente.Cidade = comboCidade.Text;
                cliente.Bairro = tbBairro.Text;
                cliente.Logradouro = tbLogradouro.Text;
                cliente.Numero_endereco = tbNumCasa.Text;
                cliente.Complemento_endereco = tbComplemento.Text;

                db.SaveChanges();

                limpar.CleanControl(contentCNPJ);
                limpar.CleanControl(Parent.Controls["searchPanel"].Controls["panelSerch"]);
            }

        }
        private void buscarCNPJ_Click(object sender, EventArgs e)
        {
            MasckedboxTemplete? inputMask = Parent.Controls["searchPanel"].Controls["panelSerch"].Controls["mkBoxCdClientSearch"] as MasckedboxTemplete;

            if (inputMask!.MaskCompleted)
            {
                TMSContext db = new();

                ClienteJuridico clienteJuridico = db.ClienteJuridico
                    .First(a => a.CNPJ == mkCNPJ.Text);

                Cliente cliente = db.Cliente.First(a => a.ClienteJuridico!.CNPJ == clienteJuridico.CNPJ);

                TelefoneCliente telefoneCliente = db.TelefoneCliente.First(a => a.ID_for_cliente == clienteJuridico.ID_for_cliente);
                CelularCliente celularCliente = db.CelularCliente.First(a => a.ID_for_cliente == clienteJuridico.ID_for_cliente);
                EmailCliente emailCliente = db.EmailCliente.First(a => a.ID_for_cliente == clienteJuridico.ID_for_cliente);


                if (clienteJuridico == null)
                {
                    MessageBox.Show("Cliente não encontrado");
                    return;
                }

                mkCNPJ.Text = clienteJuridico.CNPJ;
                tbNomeFantasia.Text = clienteJuridico.Nome_fantasia;
                mkInscricaoEstatudal.Text = clienteJuridico.Inscricao_estadual;
                tbRazaoSocial.Text = clienteJuridico.Razao_social;
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
