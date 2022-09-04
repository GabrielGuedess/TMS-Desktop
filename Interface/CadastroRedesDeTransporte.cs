using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class CadastroRedesDeTransporte : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                cadastrarRede.Text = value;

                if (value.Contains("Cadastro"))
                {
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
                maskRedeID.Text = value["ID_REDE"].ToString();

                if (value != null)
                {
                    maskRedeID.Text = value["ID_REDE"].ToString();

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
            atualizarIDRede();
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

        private void atualizarIDRede()
        {
            ConnectDB connectDB = new ConnectDB();
            string SQL = "SELECT MAX (NUM_ID) FROM C_Redes_de_Transporte";
            var dados = connectDB.pesquisar(SQL);
            string data = (string)dados!.Rows[0][0];
            string IdRede = data.Replace("T", "");
            int numID = int.Parse(IdRede);
            numID++;
            string numIDsg = numID.ToString();
            if (numIDsg.Length == 1)
            {
                numIDsg = numIDsg.Insert(numIDsg.Length - 1, "00");
            }
            else if (numIDsg.Length == 2)
                numIDsg = numIDsg.Insert(numIDsg.Length - 2, "0");
            this.numID.Text = "T" + numIDsg;
        }
        private void cadastrarRede_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && validar())
            {
                string SQL = "Insert Into C_Redes_de_Transporte (NUM_ID, TIPO_REDE, DESCRICAO_REDE, TIPO_MOTORISTA, TIPO_VEICULOS) Values";
                SQL += "('" + numID.Text + "','" + tbTipoRede.Text + "','" + tbDescricaoRede.Text + "','" + comboCategoriaCNH.Text + "','" + comboTipoVeiculo.Text + "')";

                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentRedes);
                limpar.CleanControl(panelSerch);

                atualizarIDRede();
            }

            if (Type.Contains("Update") && validar())
            {
                string SQLUp = $"UPDATE C_Redes_de_Transporte SET " +
                $"NUM_ID= '{numID.Text}', " +
                $"TIPO_REDE= '{tbTipoRede.Text}', " +
                $"DESCRICAO_REDE= '{tbDescricaoRede.Text}', " +
                $"TIPO_MOTORISTA= '{comboCategoriaCNH.Text}', " +
                $"TIPO_VEICULOS= '{comboTipoVeiculo.Text}' " +
                $"WHERE ID_REDE= {maskRedeID.Text}";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentRedes);
                limpar.CleanControl(searchPanel);
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
                    maskRedeID.Text = dados["ID_REDE"].ToString();

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

        private bool validar()
        {
            if (tbTipoRede.Text == String.Empty)
            {
                MessageBox.Show("O campo Tipo de Rede é obrigatório", "Erro", MessageBoxButtons.OK);
                tbTipoRede.Focus();
                return false;
            }

            if (tbDescricaoRede.Text == String.Empty)
            {
                MessageBox.Show("O campo Descrição da Rede é obrigatório", "Erro", MessageBoxButtons.OK);
                tbDescricaoRede.Focus();
                return false;
            }

            if (comboCategoriaCNH.Text == String.Empty)
            {
                MessageBox.Show("O campo Categoria da CNH é obrigatório", "Erro", MessageBoxButtons.OK);
                comboCategoriaCNH.Focus();
                return false;
            }

            if (comboTipoVeiculo.Text == String.Empty)
            {
                MessageBox.Show("O campo Tipo de Veículo é obrigatório", "Erro", MessageBoxButtons.OK);
                comboTipoVeiculo.Focus();
                return false;
            }
            return true;
        }
    }
}
