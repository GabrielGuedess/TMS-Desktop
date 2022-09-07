using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class CadastroSinistros : UserControl
    {
        readonly Utilidades utils = new();

        LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                cadastrarSinistro.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentSinistros.Location = new Point(0, 0);

                    tbCodigdoSinistro.ReadOnly = false;
                    tbCodigdoSinistro.Cursor = Cursors.IBeam;
                    buscarCodigo.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentSinistros.Location = new Point(0, 62);

                    tbCodigdoSinistro.ReadOnly = true;
                    tbCodigdoSinistro.Cursor = Cursors.No;
                    buscarCodigo.Visible = true;
                }
            }
        }
        public DataRow OverviewDataResponse
        {
            set
            {
                cod.Text = value["ID"].ToString();

                if (value != null)
                {
                    tbCodigdoSinistro.Text = value["ID"].ToString();
                    comboTipoSinistro.Text = value["TipoSinistro"].ToString();
                    tbDescricaoSinistro.Text = value["DescricaoSinistro"].ToString();
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

        private void atualizarIDSinistro()
        {
            ConnectDB connectDB = new ConnectDB();
            string SQL = "SELECT MAX (ID) FROM tbSinistros";
            var dados = connectDB.pesquisar(SQL);
            string data = (string)dados!.Rows[0][0];
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

        private void cadastrarSinistro_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && Validation.Validar(contentSinistros))
            {
                string SQL = "Insert Into tbSinistros(TipoSinistro, DescricaoSinistro, ID) Values";

                SQL += "('" + comboTipoSinistro.Text + "','" + tbDescricaoSinistro.Text + "','" + tbCodigdoSinistro.Text + "')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentSinistros);
                limpar.CleanControl(searchPanel);

                atualizarIDSinistro();
            }

            if (Type.Contains("Update") && Validation.Validar(contentSinistros))
            {
                string SQLUp = $"UPDATE tbSinistros SET " +
                $"TipoSinistro= '{comboTipoSinistro.Text}', " +
                $"DescricaoSinistro= '{tbDescricaoSinistro.Text}' " +
                $"WHERE ID = '{cod.Text.Replace('.', ',')}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentSinistros);
                limpar.CleanControl(searchPanel);
            }
        }

        private void buscarCodigo_Click(object sender, EventArgs e)
        {
            if (cod.Text != "")
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM tbSinistros WHERE ID = '{cod.Text}'", contentSinistros)!;

                if (dados != null)
                {
                    cod.Text = dados["ID"].ToString();

                    comboTipoSinistro.Text = dados["TipoSinistro"].ToString();
                    tbDescricaoSinistro.Text = dados["DescricaoSinistro"].ToString();
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cod.Focus();
            }
        }

        private void cod_TextChanged(object sender, EventArgs e)
        {
            tbCodigdoSinistro.Text = cod.Text;

            utils.feedbackColorInputNumLetters(cod, typeData);
        }
    }
}
