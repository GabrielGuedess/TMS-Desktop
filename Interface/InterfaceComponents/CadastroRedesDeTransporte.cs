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
    public partial class CadastroRedesDeTransporte : UserControl
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

                cadastrarRede.Text = value;

                limpar.CleanControl(contentRedes);
                limpar.CleanControl(searchPanel);

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentRedes.Location = new Point(0, 0);

                    idRedes();

                    ID_Rede.ReadOnly = false;
                    ID_Rede.Cursor = Cursors.IBeam;
                    buscarNumId.Visible = false;

                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentRedes.Location = new Point(0, 62);

                    ID_Rede.ReadOnly = true;
                    ID_Rede.Cursor = Cursors.No;
                    buscarNumId.Visible = true;

                    limpar.CleanControl(contentRedes);
                    limpar.CleanControl(searchPanel);
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                maskRedeID.Text = value["NUM_ID"].ToString();

                if (value != null)
                {
                    maskRedeID.Text = value["NUM_ID"].ToString();

                    ID_Rede.Text = value["NUM_ID"].ToString();
                    tbTipoRede.Text = value["TIPO_REDE"].ToString();
                    tbDescricaoRede.Text = value["DESCRICAO_REDE"].ToString();
                    comboCategoriaCNH.Text = value["TIPO_MOTORISTA"].ToString();
                    comboTipoVeiculo.Text = value["TIPO_VEICULOS"].ToString();
                }
            }
        }

        public CadastroRedesDeTransporte()
        {
            InitializeComponent();
        }

        private void idRedes()
        {
            TMSContext db = new();

            if (db.RedeTransporte.Count() > 0)
            {
                lastID = db.Sinistro.Max(id => id.ID_Sinistro)+1;
            }

            ID_Rede.Text = lastID.ToString();
        }

        private void CadastroRedesDeTransporte_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelBorderRoundedID);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarRede_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarRede);
        }
        private void buscarNumId_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarNumId);
        }


        private void cadastrarRede_Click(object sender, EventArgs e)
        {
            try
            {
                if (Type.Contains("Cadastro") && Validation.Validar(contentRedes))
                {

                    TMSContext db = new();

                    RedeTransporte redeTransporte = new RedeTransporte
                    {
                        ID_rede = lastID,
                        Descricao = tbDescricaoRede.Text,
                        Tipo_rede = tbTipoRede.Text,
                        Categoria_CNH = comboCategoriaCNH.Text,
                        Tipo_veiculo = comboTipoVeiculo.Text,
                    };
                    db.RedeTransporte.Add(redeTransporte);

                    db.SaveChanges();

                    limpar.CleanControl(contentRedes);
                    limpar.CleanControl(searchPanel);
                    lastID++;
                    ID_Rede.Text = lastID.ToString();
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


            if (Type.Contains("Update") && Validation.Validar(contentRedes))
            {
                TMSContext db = new();

                RedeTransporte redeTransporte = db.RedeTransporte.FirstOrDefault(a => a.ID_rede == int.Parse(maskRedeID.Text));

                if (redeTransporte == null)
                {
                    MessageBox.Show("Error");
                    return;
                }

                redeTransporte.Descricao = tbDescricaoRede.Text;
                redeTransporte.Tipo_rede = tbTipoRede.Text;
                redeTransporte.Categoria_CNH = comboCategoriaCNH.Text;
                redeTransporte.Tipo_veiculo = comboTipoVeiculo.Text;

                db.SaveChanges();

                limpar.CleanControl(contentRedes);
                limpar.CleanControl(searchPanel);
            }
        }

        private void buscarNumId_Click(object sender, EventArgs e)
        {
            idRedes();

            if (maskRedeID.Text.Length > 0)
            {
                TMSContext db = new();

                RedeTransporte redeTransporte = db.RedeTransporte.FirstOrDefault(a => a.ID_rede == int.Parse(maskRedeID.Text));

                if (redeTransporte == null)
                {
                    ID_Rede.Text = "";

                    MessageBox.Show("Rede de Transporte não encontrado");
                    return;
                }

                ID_Rede.Text = redeTransporte.ID_rede.ToString();
                tbDescricaoRede.Text = redeTransporte.Descricao;
                tbTipoRede.Text = redeTransporte.Tipo_rede;
                comboCategoriaCNH.Text = redeTransporte.Categoria_CNH;
                comboTipoVeiculo.Text = redeTransporte.Tipo_veiculo;
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskRedeID.Focus();
            }
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            maskRedeID.Focus();
        }

        private void numId_TextChanged(object sender, EventArgs e)
        {
            utils.feedbackColorInputNumLetters(maskRedeID, typeData);
        }


    }
}
