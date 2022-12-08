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
    public partial class CadastroSinistros : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        private int lastID;

        public string TypeControl
        {
            set
            {

                Type = value;

                cadastrarSinistro.Text = value;

                limpar.CleanControl(contentSinistros);
                limpar.CleanControl(searchPanel);

                idSinistro();

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentSinistros.Location = new Point(0, 0);

                    buscarCodigo.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentSinistros.Location = new Point(0, 62);

                    buscarCodigo.Visible = true;

                    limpar.CleanControl(contentSinistros);
                    limpar.CleanControl(searchPanel);
                }
            }
        }
        public DataRow OverviewDataResponse
        {
            set
            {
                if (value != null)
                {
                    cod.Text = value["ID_Sinistro"].ToString();
                    tbCod.Text = value["ID_Sinistro"].ToString();
                    comboTipoSinistro.Text = value["Tipo_Sinistro"].ToString();
                    tbDescricaoSinistro.Text = value["Descricao"].ToString();
                }
            }
        }

        public CadastroSinistros()
        {
            InitializeComponent();
        }

        private void idSinistro()
        {
            TMSContext db = new();

            if (db.Sinistro.Count() > 0)
            {
                lastID = db.Sinistro.Max(id => id.ID_Sinistro) + 1;
            }

            tbCod.Text = lastID.ToString();
        }

        private void CadastroSinistros_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarSinistro_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarSinistro);
        }
        private void buscarCodigo_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarCodigo);
        }



        private void cadastrarSinistro_Click(object sender, EventArgs e)
        {
            try
            {
                idSinistro();

                if (Type.Contains("Cadastro") && Validation.Validar(contentSinistros))
                {
                    try
                    {
                        TMSContext db = new();

                        Sinistro sinistro = new Sinistro
                        {
                            ID_Sinistro = lastID,
                            Descricao = tbDescricaoSinistro.Text,
                            Tipo_sinistro = comboTipoSinistro.Text
                        };

                        db.Sinistro.Add(sinistro);
                        db.SaveChanges();

                        limpar.CleanControl(contentSinistros);
                        limpar.CleanControl(searchPanel);

                        lastID++;
                        tbCod.Text = lastID.ToString();

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                else if (Type.Contains("Update") && Validation.Validar(contentSinistros))
                {
                    TMSContext db = new();

                    Sinistro sinistro = db.Sinistro.FirstOrDefault(a => a.ID_Sinistro == int.Parse(cod.Text));

                    if (sinistro == null)
                    {
                        MessageBox.Show("Error");
                        return;
                    }

                    sinistro.Descricao = tbDescricaoSinistro.Text;
                    sinistro.Tipo_sinistro = comboTipoSinistro.Text;

                    db.SaveChanges();

                    limpar.CleanControl(contentSinistros);
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

        private void buscarCodigo_Click(object sender, EventArgs e)
        {
            idSinistro();

            if (cod.Text.Length > 0)
            {
                TMSContext db = new();

                Sinistro sinistro = db.Sinistro.FirstOrDefault(a => a.ID_Sinistro == int.Parse(cod.Text));

                if (sinistro == null)
                {
                    MessageBox.Show("Sinistro não encontrado");
                    return;
                }

                tbCod.Text = sinistro.ID_Sinistro.ToString();
                tbDescricaoSinistro.Text = sinistro.Descricao;
                comboTipoSinistro.Text = sinistro.Tipo_sinistro;


            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod.Focus();
            }
        }

        private void cod_TextChanged(object sender, EventArgs e)
        {
            utils.feedbackColorInputNumLetters(cod, typeData);
        }

    }
}
