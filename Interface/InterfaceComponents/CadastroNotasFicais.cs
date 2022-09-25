using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Utilities;
using System.Data;

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
                    tbIDNotaFiscal.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Nota_Fiscal", "F");
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
                    tbIDNotaFiscal.Text = value["NUM_ID"].ToString();
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
            utils.expansivePanels(10, panelID, panelTipo);
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
            if (Type.Contains("Cadastro") && Validation.Validar(contentNotas))
            {
                string SQL = "Insert Into C_Nota_Fiscal (NUM_ID, CHAVE_ACESSO,NUMERO,TIPO,SERIE,DESCRICAO) Values";
                SQL += $"('{tbIDNotaFiscal.Text.TrimStart()} ','{mkChaveAcesso.Text}','{tbNumero.Text}', '{tbTipoNota.Text}', '{tbSerieNota.Text}', '{tbDescricaoNota.Text}')";
                DBFunctions.cadastrar(SQL);

                limpar.CleanControl(contentNotas);
                limpar.CleanControl(searchPanel);

                tbIDNotaFiscal.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Nota_Fiscal", "F");
            }

            if (Type.Contains("Update") && Validation.Validar(contentNotas))
            {
                string SQLUp = $"UPDATE C_Nota_Fiscal SET " +
                $"NUM_ID= '{tbIDNotaFiscal.Text}', " +
                $"NUMERO= '{tbNumero.Text}', " +
                $"TIPO= '{tbTipoNota.Text}', " +
                $"SERIE= '{tbSerieNota.Text}', " +
                $"DESCRICAO= '{tbDescricaoNota.Text}' " +
                $"WHERE CHAVE_ACESSO = '{mkSearchChaveAcesso.Text.Replace('.', ',')}'";

                DBFunctions.cadastrar(SQLUp);

                limpar.CleanControl(contentNotas);
                limpar.CleanControl(searchPanel);
                tbIDNotaFiscal.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Nota_Fiscal", "F");
            }
        }

        private void buscarCod_Click(object sender, EventArgs e)
        {
            if (mkSearchChaveAcesso.Text != "")
            {
                DataRow dados = DBFunctions.pesquisarRow($"SELECT * FROM C_Nota_Fiscal WHERE CHAVE_ACESSO = '{mkSearchChaveAcesso.Text}'", contentNotas)!;

                if (dados != null)
                {
                    mkSearchChaveAcesso.Text = dados["CHAVE_ACESSO"].ToString();
                    mkChaveAcesso.Text = dados["CHAVE_ACESSO"].ToString();
                    tbIDNotaFiscal.Text = dados["NUM_ID"].ToString();
                    tbNumero.Text = dados["NUMERO"].ToString();
                    tbTipoNota.Text = dados["TIPO"].ToString();
                    tbSerieNota.Text = dados["SERIE"].ToString();
                    tbDescricaoNota.Text = dados["DESCRICAO"].ToString();
                }
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
