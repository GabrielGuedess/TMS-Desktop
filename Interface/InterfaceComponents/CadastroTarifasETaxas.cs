using Interface.ControlValidationAuxiliary;
using Interface.ModelsDB;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.Utilities;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data;

namespace Interface
{
    public partial class CadastroTarifasETaxas : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                CadastrarTarifaOuTaxa.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentTarifas.Location = new Point(0, 0);

                    tbNomeEmpresa.ReadOnly = false;
                    tbNomeEmpresa.Cursor = Cursors.IBeam;
                    buscarEmpresa.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentTarifas.Location = new Point(0, 62);

                    tbNomeEmpresa.ReadOnly = true;
                    tbNomeEmpresa.Cursor = Cursors.No;
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
                    empresaMask.Text = value["Nome_Empresa"].ToString();
                    tbDescricaoTaxa.Text = value["Descricao"].ToString();
                    tbNomeEmpresa.Text = value["Nome_Empresa"].ToString();
                    checkTarifa.Checked = value["Tarifa_ou_taxa"].ToString() == "Tarifa";
                    checkTaxa.Checked = value["Tarifa_ou_taxa"].ToString() == "Taxa";
                }
            }
        }
        public CadastroTarifasETaxas()
        {
            InitializeComponent();
        }

        private void CadastroTarifasETaxas_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelDescricao);
        }

        private void CadastrarTarifaOuTaxa_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, CadastrarTarifaOuTaxa);
        }
        private void buscarEmpresa_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarEmpresa);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void CadastrarTarifaOuTaxa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Type.Contains("Cadastro") && Validation.Validar(contentTarifas) && validar())
                {
                    TMSContext db = new();
                    string selected = string.Empty;
                    if (checkTaxa.Checked)
                    {
                        selected = "Taxa";
                    }
                    else if (checkTarifa.Checked)
                    {
                        selected = "Tarifa";
                    }

                    TarifasETaxas tarifasETaxas = new TarifasETaxas
                    {
                        Descricao = tbDescricaoTaxa.Text,
                        Nome_empresa = tbNomeEmpresa.Text,
                        Tarifa_ou_taxa = selected,
                    };
                    db.TarifasETaxas.Add(tarifasETaxas);
                    db.SaveChanges();
                    limpar.CleanControl(contentTarifas);
                    limpar.CleanControl(searchPanel);

                }


                if (Type.Contains("Update") && Validation.Validar(contentTarifas) && validar())
                {
                    TMSContext db = new();

                    TarifasETaxas tarifasETaxas = db.TarifasETaxas.FirstOrDefault(a => a.Nome_empresa == empresaMask.Text);

                    if (tarifasETaxas == null)
                    {
                        MessageBox.Show("Error");
                        return;
                    }

                    string selected = string.Empty;

                    if (checkTaxa.Checked)
                    {
                        selected = "Taxa";
                    }
                    else if (checkTarifa.Checked)
                    {
                        selected = "Tarifa";
                    }

                    tarifasETaxas.Descricao = tbDescricaoTaxa.Text;
                    tarifasETaxas.Nome_empresa = tbNomeEmpresa.Text;
                    tarifasETaxas.Tarifa_ou_taxa = selected;

                    db.SaveChanges();

                    limpar.CleanControl(contentTarifas);
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
            if (empresaMask.Text != "")
            {
                TMSContext db = new();

                TarifasETaxas tarifasETaxas = db.TarifasETaxas.FirstOrDefault(a => a.Nome_empresa == tbNomeEmpresa.Text);

                if (tarifasETaxas == null)
                {
                    MessageBox.Show("Rede de Transporte não encontrado");
                    return;
                }

                tbDescricaoTaxa.Text = tarifasETaxas.Descricao;
                tbNomeEmpresa.Text = tarifasETaxas.Nome_empresa;
                checkTaxa.Checked = tarifasETaxas.Tarifa_ou_taxa == "Taxa";
                checkTarifa.Checked = tarifasETaxas.Tarifa_ou_taxa == "Tarifa";
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empresaMask.Focus();
            }
        }

        private void empresaMask_TextChanged(object sender, EventArgs e)
        {
            tbNomeEmpresa.Text = empresaMask.Text;

            utils.feedbackColorInputNumLetters(empresaMask, typeData);
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            empresaMask.Focus();
        }

        private bool validar()
        {
            if (!checkTaxa.Checked && !checkTarifa.Checked)
            {
                MessageBox.Show("Escolha uma se é taxa ou tarifa", "Erro", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}
