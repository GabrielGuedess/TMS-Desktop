using Interface.Properties;
using System.Data.SQLite;

namespace Interface
{
    public partial class CadastroSinistros : UserControl
    {
        readonly Utilidades utils = new();

        public string TypeControl
        {
            set
            {
                cadastrarSinistro.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentSinistros.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentSinistros.Location = new Point(0, 62);
                }
            }
        }

        public CadastroSinistros()
        {
            InitializeComponent();
            atualizarIDSinistro();
        }

        private void CadastroSinistros_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            //utils.expansivePanels(10, panelSinistro);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarSinistro_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarSinistro);
        }

        private void atualizarIDSinistro()
        {
            ConnectDB connectDB = new ConnectDB();
            string SQL = "SELECT MAX (ID) FROM tbSinistros";
            var dados = connectDB.pesquisar(SQL);
            string data = (string)dados.Rows[0][0];
            string IdSinistro = data.Replace("R", "");
            int numID = int.Parse(IdSinistro);
            numID++;
            string numIDsg = numID.ToString();
            if (numIDsg.Length == 1)
            {
                numIDsg = numIDsg.Insert(numIDsg.Length - 1, "00");
            }
            else if (numIDsg.Length == 2)
                numIDsg = numIDsg.Insert(numIDsg.Length - 2, "0");
            tbCodigdoSinistro.Text = "R" + numIDsg;
        }

        private bool validar()
        {
            if(tbCodigdoSinistro.Text == String.Empty)
            {
                MessageBox.Show("O campo Codigo de Sinistro é Obrigatorio", "Erro", MessageBoxButtons.OK);
                tbCodigdoSinistro.Focus();

                return false;
            }
            else if (comboTipoSinistro.Text == String.Empty)
            {
                MessageBox.Show("O campo Tipo de Sinistro é obrigatório", "Erro", MessageBoxButtons.OK);
                comboTipoSinistro.Focus();
                return false;
            }
            else if (tbDescricaoSinistro.Text == String.Empty)
            {
                MessageBox.Show("É obrigatório adicinar uma descrição ao sinistro", "Erro", MessageBoxButtons.OK);
                tbDescricaoSinistro.Focus();
                return false;
            }

            return true;
        }

        private void cadastrarSinistro_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            else
            {
                string SQL = "Insert Into tbSinistros(TipoSinistro, DescricaoSinistro, ID) Values";

                SQL += "('" + comboTipoSinistro.Text + "','" + tbDescricaoSinistro.Text + "','" + tbCodigdoSinistro.Text + "')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentSinistros);
                atualizarIDSinistro();
            }
        }
    }
}
