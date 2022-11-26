using Interface.ControlValidationAuxiliary;
using Interface.DataBaseControls;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class CadastroSinistros : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        readonly ConnectDB DBFunctions = new();

        public string TypeControl
        {
            set
            {

                Type = value;

                cadastrarSinistro.Text = value;

                if (value.Contains("Cadastro"))
                {
                   // tbCodigdoSinistro.Text = DBFunctions.atualizaID("SELECT MAX (ID) FROM tbSinistros", "r");
                    searchPanel.Visible = false;
                    contentSinistros.Location = new Point(0, 0);

                    
                    buscarCodigo.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentSinistros.Location = new Point(0, 62);

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
                    comboTipoSinistro.Text = value["TipoSinistro"].ToString();
                    tbDescricaoSinistro.Text = value["DescricaoSinistro"].ToString();
                }
            }
        }

        public CadastroSinistros()
        {
            InitializeComponent();
            

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
            if (Type.Contains("Cadastro") && Validation.Validar(contentSinistros))
            {
                /*string SQL = "Insert Into tbSinistros(TipoSinistro, DescricaoSinistro, ID) Values";

                SQL += "('" + comboTipoSinistro.Text + "','" + tbDescricaoSinistro.Text + "','" + tbCodigdoSinistro.Text + "')";

                DBFunctions.cadastrar(SQL);*/


                //sinistro.ID_Sinistro = int.Parse(tbCodigdoSinistro.Text);
                

                limpar.CleanControl(contentSinistros);
                limpar.CleanControl(searchPanel);
                //tbCodigdoSinistro.Text = DBFunctions.atualizaID("SELECT MAX (ID) FROM tbSinistros", "r");
            }

            if (Type.Contains("Update") && Validation.Validar(contentSinistros))
            {
                string SQLUp = $"UPDATE tbSinistros SET " +
                $"TipoSinistro= '{comboTipoSinistro.Text}', " +
                $"DescricaoSinistro= '{tbDescricaoSinistro.Text}' " +
                $"WHERE ID = '{cod.Text.Replace('.', ',')}'";
                DBFunctions.cadastrar(SQLUp);
                limpar.CleanControl(contentSinistros);
                limpar.CleanControl(searchPanel);
               // tbCodigdoSinistro.Text = DBFunctions.atualizaID("SELECT MAX (ID) FROM tbSinistros", "r");
            }
        }

        private void buscarCodigo_Click(object sender, EventArgs e)
        {
            if (cod.Text != "")
            {
                DataRow dados = DBFunctions.pesquisarRow($"SELECT * FROM tbSinistros WHERE ID = '{cod.Text}'", contentSinistros)!;

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
            

            utils.feedbackColorInputNumLetters(cod, typeData);
        }

    }
}
