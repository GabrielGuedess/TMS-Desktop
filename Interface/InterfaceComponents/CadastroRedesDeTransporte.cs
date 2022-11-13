using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class CadastroRedesDeTransporte : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        ConnectDB DBFunctions = new();

        public string TypeControl
        {
            set
            {

                Type = value;

                cadastrarRede.Text = value;

                if (value.Contains("Cadastro"))
                {
                    //numID.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Redes_de_Transporte", "T");
                    searchPanel.Visible = false;
                    contentRedes.Location = new Point(0, 0);

                    numID.ReadOnly = false;
                    numID.Cursor = Cursors.IBeam;
                    buscarNumId.Visible = false;

                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentRedes.Location = new Point(0, 62);

                    numID.ReadOnly = true;
                    numID.Cursor = Cursors.No;
                    buscarNumId.Visible = true;
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

                    numID.Text = value["NUM_ID"].ToString();
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
            if (Type.Contains("Cadastro") && Validation.Validar(contentRedes))
            {
                string SQL = "Insert Into C_Redes_de_Transporte (NUM_ID, TIPO_REDE, DESCRICAO_REDE, TIPO_MOTORISTA, TIPO_VEICULOS) Values";
                SQL += "('" + numID.Text + "','" + tbTipoRede.Text + "','" + tbDescricaoRede.Text + "','" + comboCategoriaCNH.Text + "','" + comboTipoVeiculo.Text + "')";

                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentRedes);
                limpar.CleanControl(panelSerch);

                //numID.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Redes_de_Transporte", "T");
            }

            if (Type.Contains("Update") && Validation.Validar(contentRedes))
            {
                string SQLUp = $"UPDATE C_Redes_de_Transporte SET " +
                $"TIPO_REDE= '{tbTipoRede.Text}', " +
                $"DESCRICAO_REDE= '{tbDescricaoRede.Text}', " +
                $"TIPO_MOTORISTA= '{comboCategoriaCNH.Text}', " +
                $"TIPO_VEICULOS= '{comboTipoVeiculo.Text}' " +
                $"WHERE NUM_ID = '{maskRedeID.Text}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentRedes);
                limpar.CleanControl(searchPanel);
                //numID.Text = DBFunctions.atualizaID("SELECT MAX (NUM_ID) FROM C_Redes_de_Transporte", "T");
            }
        }

        private void buscarNumId_Click(object sender, EventArgs e)
        {
            if (maskRedeID.Text != "")
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM C_Redes_de_Transporte WHERE ID_REDE = {maskRedeID.Text}", contentRedes)!;

                if (dados != null)
                {
                    maskRedeID.Text = dados["NUM_ID"].ToString();

                    numID.Text = dados["NUM_ID"].ToString();
                    tbTipoRede.Text = dados["TIPO_REDE"].ToString();
                    tbDescricaoRede.Text = dados["DESCRICAO_REDE"].ToString();
                    comboCategoriaCNH.Text = dados["TIPO_MOTORISTA"].ToString();
                    comboTipoVeiculo.Text = dados["TIPO_VEICULOS"].ToString();
                }
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
