using Interface.Properties;

namespace Interface
{
    public partial class CadastroRedesDeTransporte : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set
            {
                cadastrarRede.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentRedes.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentRedes.Location = new Point(0, 62);
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
        private void atualizarIDRede()
        {
            ConnectDB connectDB = new ConnectDB();
            string SQL = "SELECT MAX (NUM_ID) FROM C_Redes_de_Transporte";
            var dados = connectDB.pesquisar(SQL);
            string data = (string)dados.Rows[0][0];
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
            tbIDRede.Text = "T" + numIDsg;
        }
        private void cadastrarRede_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            else
            {
                string SQL = "Insert Into C_Redes_de_Transporte (NUM_ID, TIPO_REDE, DESCRICAO_REDE, TIPO_MOTORISTA, TIPO_VEICULOS) Values";
                SQL += "('" + tbIDRede.Text + "','" + tbTipoRede.Text + "','" + tbDescricaoRede.Text + "','" + comboCategoriaCNH.Text + "','" + comboTipoVeiculo.Text + "')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentRedes);
                atualizarIDRede();
            }
        }
    }
}
