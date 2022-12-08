using CorreioService;
using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Properties;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data;

namespace Interface.InterfaceComponents
{
    public partial class CadastroEmpresaManutencao : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {

                Type = value;

                cadastrarEmpresa.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentCNPJ.Location = new Point(0, 0);


                    buscarEmpresa.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentCNPJ.Location = new Point(0, 62);

                    buscarEmpresa.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                if (value != null)
                {
                    searchEmpresa.Text = value["CNPJ"].ToString();
                    mkCNPJ.Text = value["CNPJ"].ToString();
                    tbNomeFantasia.Text = value["Nome_fantasia"].ToString();
                    mkInscricaoEstatudal.Text = value["Inscricao_estadual"].ToString();
                    tbRazaoSocial.Text = value["Razao_social"].ToString();
                    tbAreaAtuacao.Text = value["Area_atuacao"].ToString();
                    mkCelular.Text = value["Celular"].ToString();
                    mkTelefone.Text = value["Telefone"].ToString();
                    tbEmail.Text = value["Email"].ToString();
                    mkCEP.Text = value["CEP"].ToString();
                    comboUF.Text = value["UF"].ToString();
                    tbBairro.Text = value["Bairro"].ToString();
                    tbLogradouro.Text = value["Logradouro"].ToString();
                    tbNumCasa.Text = value["Numero_endereco"].ToString();
                    tbComplemento.Text = value["Complemento_endereco"].ToString();
                }
            }
        }

        public CadastroEmpresaManutencao()
        {
            InitializeComponent();
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

        private void cadastrarCNPJ_Click(object sender, EventArgs e)
        {
            try
            {
                TMSContext db = new();
                List<string> notValidar = new();
                notValidar.Add(tbComplemento.Name);
                notValidar.Add(mkTelefone.Name);
                if (Type.Contains("Cadastro") && Validation.Validar(contentCNPJ, notValidar) && Validation.validarTelefone(mkTelefone))
                {
                    PessoaJuridica empresa = new();

                    empresa.CNPJ = mkCNPJ.Text;
                    empresa.Nome_fantasia = tbNomeFantasia.Text;
                    empresa.Inscricao_estadual = mkInscricaoEstatudal.Text;
                    empresa.Razao_social = tbRazaoSocial.Text;
                    empresa.Celular = mkCelular.Text;
                    if (mkTelefone.Text.Length > 0)
                    {
                        empresa.Telefone = mkTelefone.Text;
                    }
                    empresa.Email = tbEmail.Text;
                    empresa.CEP = mkCEP.Text;
                    empresa.UF = comboUF.Text;
                    empresa.Cidade = comboCidade.Text;
                    empresa.Area_atuacao = tbAreaAtuacao.Text;
                    empresa.Bairro = tbBairro.Text;
                    empresa.Logradouro = tbLogradouro.Text;
                    empresa.Numero_endereco = tbNumCasa.Text;
                    if (tbComplemento.Text.Length > 0)
                    {
                        empresa.Complemento_endereco = tbComplemento.Text;
                    }
                    db.PessoaJuridica.Add(empresa);
                    db.SaveChanges();
                    limpar.CleanControl(contentCNPJ);
                    limpar.CleanControl(searchPanel);
                }
                else if (Type.Contains("Update") && Validation.Validar(contentCNPJ, notValidar) && Validation.validarTelefone(mkTelefone))
                {
                    PessoaJuridica empresa = db.PessoaJuridica.FirstOrDefault(a => a.CNPJ == searchEmpresa.Text);

                    if (empresa == null)
                    {
                        MessageBox.Show("Erro ao Atualizar Empresa");
                        return;
                    }
                    empresa.CNPJ = mkCNPJ.Text;
                    empresa.Nome_fantasia = tbNomeFantasia.Text;
                    empresa.Inscricao_estadual = mkInscricaoEstatudal.Text;
                    empresa.Razao_social = tbRazaoSocial.Text;
                    empresa.Celular = mkCelular.Text;
                    if (mkTelefone.Text.Length > 0)
                    {
                        empresa.Telefone = mkTelefone.Text;
                    }
                    empresa.Email = tbEmail.Text;
                    empresa.CEP = mkCEP.Text;
                    empresa.UF = comboUF.Text;
                    empresa.Cidade = comboCidade.Text;
                    empresa.Bairro = tbBairro.Text;
                    empresa.Logradouro = tbLogradouro.Text;
                    empresa.Numero_endereco = tbNumCasa.Text;
                    if (tbComplemento.Text.Length > 0)
                    {
                        empresa.Complemento_endereco = tbComplemento.Text;
                    }
                    db.SaveChanges();
                    limpar.CleanControl(contentCNPJ);
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

        private void buscarEmpresa_Click(object sender, EventArgs e)
        {
            if (searchEmpresa.MaskCompleted)
            {
                TMSContext db = new TMSContext();
                PessoaJuridica empresa = db.PessoaJuridica.FirstOrDefault(a => a.CNPJ == searchEmpresa.Text);
                if (empresa == null)
                {
                    MessageBox.Show("Erro ao Buscar");
                    return;
                }
                mkCNPJ.Text = empresa.CNPJ;
                tbNomeFantasia.Text = empresa.Nome_fantasia;
                mkInscricaoEstatudal.Text = empresa.Inscricao_estadual;
                tbRazaoSocial.Text = empresa.Razao_social;
                mkCelular.Text = empresa.Celular;
                mkTelefone.Text = empresa.Telefone;
                tbAreaAtuacao.Text = empresa.Area_atuacao;
                tbEmail.Text = empresa.Email;
                mkCEP.Text = empresa.CEP;
                comboUF.Text = empresa.UF;
                comboCidade.Text = empresa.Cidade;
                tbBairro.Text = empresa.Bairro;
                tbLogradouro.Text = empresa.Logradouro;
                tbNumCasa.Text = empresa.Numero_endereco;
                tbComplemento.Text = empresa.Complemento_endereco;

            }

            else
            {
                MessageBox.Show("Digite corretamente o CNPJ no campo de busca");
                searchEmpresa.Focus();
                return;
            }
        }

        private void panelBorderRoundedOnLeft2_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void buscarEmpresa_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarEmpresa);
        }

        private void cadastrarEmpresa_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarEmpresa);
        }
    }
}
