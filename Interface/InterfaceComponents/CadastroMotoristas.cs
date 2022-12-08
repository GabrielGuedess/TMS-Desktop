using GMap.NET.MapProviders;
using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Properties;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data;

namespace Interface
{
    public partial class CadastroMotoristas : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        readonly ConnectDB DBFunctions = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {

                Type = value;

                cadastrarMotoristas.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentMotorista.Location = new Point(0, 0);

                    mkCPF.ReadOnly = false;
                    mkCPF.Cursor = Cursors.IBeam;
                    buscarCPF.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentMotorista.Location = new Point(0, 62);

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
                if (value != null)
                {
                    maskInput.Text = value["CPF"].ToString();
                    tbNome.Text = value["Nome"].ToString();
                    mkCPF.Text = value["CPF"].ToString();
                    mkRG.Text = value["RG"].ToString();
                    dateNascimento.Text = value["Data_nascimento"].ToString();
                    comboGenero.Text = value["Genero"].ToString();
                    mkTelefone.Text = value["Telefone"].ToString();
                    mkCelular.Text = value["Celular"].ToString();
                    tbEmail.Text = value["Email"].ToString();
                    mkCEP.Text = value["CEP"].ToString();
                    comboUF.Text = value["UF"].ToString();
                    comboCidade.Text = value["Cidade"].ToString();
                    tbLogradouro.Text = value["Logradouro"].ToString();
                    tbNumCasa.Text = value["Numero_endereco"].ToString();
                    tbBairro.Text = value["Bairro"].ToString();
                    tbComplemento.Text = value["Complemento_endereco"].ToString();
                }
            }
        }
        public CadastroMotoristas()
        {
            InitializeComponent();
        }

        private void CadastroMotoristas_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelBorderRoundedCPF, panelBorderRoundedNCNH, panelBorderRoundedEmail, panelBorderRoundedEndereco);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarMotoristas_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarMotoristas);
        }
        private void buscarCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCPF);
        }



        private void cadastrarMotoristas_Click(object sender, EventArgs e)
        {
            List<string> notValidar = new();
            notValidar.Add(tbComplemento.Name);
            notValidar.Add(mkTelefone.Name);
            try
            {
                if (Type.Contains("Cadastro") && Validation.Validar(contentMotorista, notValidar))
                {

                    TMSContext db = new();
                    int lastID = 0;
                    if (db.Motorista.Count() > 0)
                    {
                        lastID = db.Motorista.Max(id => id.ID_motorista) + 1;
                    }

                    Motorista motorista = new Motorista
                    {
                        ID_motorista = lastID,
                        Nome = tbNome.Text,
                        CPF = mkCPF.Text,
                        RG = mkRG.Text,
                        Data_nascimento = dateNascimento.convertDateOnly(),
                        Genero = comboGenero.Text,
                        CEP = mkCEP.Text,
                        UF = comboUF.Text,
                        Cidade = comboCidade.Text,
                        Bairro = tbBairro.Text,
                        Logradouro = tbLogradouro.Text,
                        Numero_endereco = tbNumCasa.Text,
                        Complemento_endereco = tbComplemento.Text,
                        Categoria_CNH = comboCNH.Text,
                        Curso_MOPP = comboMOPP.Text,
                        Numero_CNH = mkCNH.Text,
                        Vencimento_CNH = dateVencimentoCNH.convertDateOnly(),
                    };
                    TelefoneFuncionario telefone = new TelefoneFuncionario
                    {
                        Telefone = mkTelefone.Text,
                        ID_for_funcionario = lastID
                    };
                    CelularFuncionario celular = new CelularFuncionario
                    {
                        Celular = mkCelular.Text,
                        ID_for_funcionario = lastID
                    };

                    EmailFuncionario email = new EmailFuncionario
                    {
                        Email = tbEmail.Text,
                        ID_for_funcionario = lastID
                    };

                    motorista.CelularFuncionario.Add(celular);
                    motorista.EmailFuncionario.Add(email);
                    if (mkTelefone.Text.Length > 0)
                    {
                        motorista.TelefoneFuncionario.Add(telefone);
                    }
                    db.Motorista.Add(motorista);
                    db.SaveChanges();

                    limpar.CleanControl(contentMotorista);
                    limpar.CleanControl(searchPanel);
                }


                else if (Type.Contains("Update") && Validation.Validar(contentMotorista, notValidar))
                {
                    TMSContext db = new();
                    Motorista motorista = db.Motorista.Include(a => a.CelularFuncionario)
                        .Include(a => a.TelefoneFuncionario)
                        .Include(a => a.EmailFuncionario).FirstOrDefault(a => a.CPF == mkCPF.Text);
                    if (motorista == null)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    motorista.Nome = tbNome.Text;
                    motorista.CPF = mkCPF.Text;
                    motorista.RG = mkRG.Text;
                    motorista.Data_nascimento = dateNascimento.convertDateOnly();
                    motorista.Genero = comboGenero.Text;
                    motorista.TelefoneFuncionario.First().Telefone = mkTelefone.Text;
                    motorista.CelularFuncionario.First().Celular = mkCelular.Text;
                    motorista.EmailFuncionario.First().Email = tbEmail.Text;
                    motorista.CEP = mkCEP.Text;
                    motorista.UF = comboUF.Text;
                    motorista.Cidade = comboCidade.Text;
                    motorista.Bairro = tbBairro.Text;
                    motorista.Logradouro = tbLogradouro.Text;
                    motorista.Numero_endereco = tbNumCasa.Text;
                    motorista.Complemento_endereco = tbComplemento.Text;
                    motorista.Numero_endereco = tbNumCasa.Text;
                    motorista.Vencimento_CNH = dateVencimentoCNH.convertDateOnly();
                    motorista.Categoria_CNH = comboCNH.Text;
                    motorista.Curso_MOPP = comboMOPP.Text;

                    db.SaveChanges();

                    limpar.CleanControl(contentMotorista);
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
            if (maskInput.MaskCompleted)
            {
                TMSContext db = new();

                Motorista motorista = db.Motorista.Include(a => a.CelularFuncionario)
                    .Include(a => a.TelefoneFuncionario)
                    .Include(a => a.EmailFuncionario).FirstOrDefault(a => a.CPF == mkCPF.Text);

                if (motorista == null)
                {
                    MessageBox.Show("Motorista não encontrado");
                    return;
                }
                tbNome.Text = motorista.Nome;
                mkRG.Text = motorista.RG;
                dateNascimento.Text = motorista.Data_nascimento.ToString();
                comboGenero.Text = motorista.Genero;
                mkTelefone.Text = motorista.TelefoneFuncionario.First().Telefone;
                mkCelular.Text = motorista.CelularFuncionario.First().Celular;
                tbEmail.Text = motorista.EmailFuncionario.First().Email;
                mkCEP.Text = motorista.CEP;
                comboUF.Text = motorista.UF;
                comboCidade.Text = motorista.Cidade;
                tbBairro.Text = motorista.Bairro;
                tbLogradouro.Text = motorista.Logradouro;
                tbNumCasa.Text = motorista.Numero_endereco;
                tbComplemento.Text = motorista.Complemento_endereco;

                comboCNH.Text = motorista.Categoria_CNH;
                dateVencimentoCNH.Text = motorista.Vencimento_CNH.ToString();
                mkCNH.Text = motorista.Numero_CNH;
                comboMOPP.Text = motorista.Curso_MOPP;

            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkCPF.Focus();
            }
        }
        private void typeData_Click(object sender, EventArgs e)
        {
            maskInput.Focus();
        }
        private void maskInput_TextChanged(object sender, EventArgs e)
        {
            mkCPF.Text = maskInput.Text;
            utils.feedbackColorInput(maskInput, typeData);
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
