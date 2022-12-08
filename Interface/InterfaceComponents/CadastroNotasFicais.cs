using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.ModelsDB.TMSDataBaseContext;
using Interface.ModelsDB;
using Interface.Utilities;
using System.Data;
using MySqlConnector;
using Microsoft.EntityFrameworkCore;

namespace Interface
{
    public partial class CadastroNotasFicais : UserControl
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

                cadastrarNota.Text = value;

                if (value.Contains("Cadastro"))
                {
                    //tbIDNotaFiscal.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Nota_Fiscal", "F");
                    searchPanel.Visible = false;
                    contentNotas.Location = new Point(0, 0);

                    mkChaveAcesso.ReadOnly = false;
                    mkChaveAcesso.Cursor = Cursors.IBeam;
                    buscarCod.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentNotas.Location = new Point(0, 62);

                    mkChaveAcesso.ReadOnly = true;
                    mkChaveAcesso.Cursor = Cursors.No;
                    buscarCod.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                mkSearchChaveAcesso.Text = value["CHAVE_ACESSO"].ToString();

                if (value != null)
                {
                    mkChaveAcesso.Text = value["CHAVE_ACESSO"].ToString();
                    tbNumero.Text = value["NUMERO"].ToString();
                    tbTipoNota.Text = value["TIPO"].ToString();
                    tbSerieNota.Text = value["SERIE"].ToString();
                    tbDescricaoNota.Text = value["DESCRICAO"].ToString();
                }
            }
        }

        public CadastroNotasFicais()
        {
            InitializeComponent();
        }

        private void CadastroNotasFicais_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelTipo);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarNota_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarNota);
        }
        private void buscarCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCod);
        }

        private void cadastrarNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (Type.Contains("Cadastro") && Validation.Validar(contentNotas))
                {
                    NotaFiscal notaFiscal = new()
                    {
                        Chave_acesso = mkChaveAcesso.Text,
                        Descricao = tbDescricaoNota.Text,
                        Numero = tbNumero.Text,
                        Serie = tbSerieNota.Text,
                        Tipo = tbTipoNota.Text
                    };

                    TMSContext db = new();
                    db.NotaFiscal.Add(notaFiscal);
                    db.SaveChanges();

                    limpar.CleanControl(contentNotas);
                    limpar.CleanControl(searchPanel);

                    //tbIDNotaFiscal.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Nota_Fiscal", "F");
                }

                if (Type.Contains("Update") && Validation.Validar(contentNotas))
                {
                    TMSContext db = new();
                    NotaFiscal nota = db.NotaFiscal.FirstOrDefault(a => a.Chave_acesso == mkSearchChaveAcesso.Text);

                    if (nota == null)
                    {
                        MessageBox.Show("Erro ao atualizar Nota");
                        return;
                    }
                    nota.Chave_acesso = mkChaveAcesso.Text;
                    nota.Numero = tbNumero.Text;
                    nota.Descricao = tbDescricaoNota.Text;
                    nota.Serie = tbSerieNota.Text;
                    nota.Tipo = tbTipoNota.Text;

                    db.SaveChanges();
                    limpar.CleanControl(contentNotas);
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

        private void buscarCod_Click(object sender, EventArgs e)
        {
            if (mkSearchChaveAcesso.Text != "")
            {
                TMSContext db = new();
                NotaFiscal nota = db.NotaFiscal.FirstOrDefault(a => a.Chave_acesso == mkSearchChaveAcesso.Text);
                if (nota == null)
                {
                    MessageBox.Show("Erro ao buscar Nota");
                    return;
                }
                mkChaveAcesso.Text = nota.Chave_acesso;
                tbNumero.Text = nota.Numero;
                tbDescricaoNota.Text = nota.Descricao;
                tbSerieNota.Text = nota.Serie;
                tbTipoNota.Text = nota.Tipo;
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkSearchChaveAcesso.Focus();
            }
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            mkSearchChaveAcesso.Focus();
        }

        private void tbSearchChaveAcesso_TextChanged(object sender, EventArgs e)
        {
            mkChaveAcesso.Text = mkSearchChaveAcesso.Text;

            utils.feedbackColorInput(mkSearchChaveAcesso, typeData);
        }


    }
}
