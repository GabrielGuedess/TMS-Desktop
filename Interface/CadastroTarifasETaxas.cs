using Interface.Properties;
using System.Data;

namespace Interface
{
    public partial class CadastroTarifasETaxas : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();

        private string Type = "";

        public string TypeControl
        {
            set
            {
                Type = value;

                CadastrarTarifaOuTaxa.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentTarifas.Location = new Point(0, 0);

                    tbNomeEmpresa.ReadOnly = false;
                    tbNomeEmpresa.Cursor = Cursors.IBeam;
                    buscarEmpresa.Visible = false;
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentTarifas.Location = new Point(0, 62);

                    tbNomeEmpresa.ReadOnly = true;
                    tbNomeEmpresa.Cursor = Cursors.No;
                    buscarEmpresa.Visible = true;
                }
            }
        }

        public DataRow OverviewDataResponse
        {
            set
            {
                empresaMask.Text = value["Nome_Empresa"].ToString();

                if (value != null)
                {
                    tbDescricaoTaxa.Text = value["Descricao"].ToString();
                    tbNomeEmpresa.Text = value["Nome_Empresa"].ToString();
                    checkTarifa.Checked = value["Taxa_Tarifa"].ToString() == "Tarifa";
                    checkTaxa.Checked = value["Taxa_Tarifa"].ToString() == "Taxa";
                }
            }
        }
        public CadastroTarifasETaxas()
        {
            InitializeComponent();
        }

        private void CadastroTarifasETaxas_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelDescricao);
        }

        private void CadastrarTarifaOuTaxa_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, CadastrarTarifaOuTaxa);
        }
        private void buscarEmpresa_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscarEmpresa);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void CadastrarTarifaOuTaxa_Click(object sender, EventArgs e)
        {
            if (Type.Contains("Cadastro") && validar())
            {
                string selected = string.Empty;
                if (checkTaxa.Checked)
                {
                    selected = "Taxa";
                }
                else if (checkTarifa.Checked)
                {
                    selected = "Tarifa";
                }
                string SQL = "INSERT INTO Tarifas_Taxas (Taxa_Tarifa, Descricao, Nome_Empresa) VALUES";
                SQL += "('" + selected + "','" + tbDescricaoTaxa.Text + "','" + tbNomeEmpresa.Text + "')";

                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);

                limpar.CleanControl(contentTarifas);
                limpar.CleanControl(panelSerch);
            }

            if (Type.Contains("Update") && validar())
            {
                string SQLUp = $"UPDATE Tarifas_Taxas SET " +
                $"Taxa_Tarifa= '{(checkTarifa.Checked ? checkTarifa.Text : checkTaxa.Text)}', " +
                $"Descricao= '{tbDescricaoTaxa.Text}' " +
                $"WHERE Nome_Empresa = '{empresaMask.Text.Replace('.', ',')}'";

                ConnectDB connectDB = new();
                connectDB.cadastrar(SQLUp);

                limpar.CleanControl(contentTarifas);
                limpar.CleanControl(searchPanel);
            }
        }

        private void buscarEmpresa_Click(object sender, EventArgs e)
        {
            if (empresaMask.Text != "")
            {
                ConnectDB connectDB = new();
                DataRow dados = connectDB.pesquisarRow($"SELECT * FROM Tarifas_Taxas WHERE Nome_Empresa = '{empresaMask.Text}'", contentTarifas)!;

                if (dados != null)
                {
                    empresaMask.Text = dados["Nome_Empresa"].ToString();

                    checkTaxa.Text = dados["Taxa_Tarifa"].ToString();
                    checkTarifa.Checked = dados["Taxa_Tarifa"].ToString() == "Tarifa";
                    checkTaxa.Checked = dados["Taxa_Tarifa"].ToString() == "Taxa";
                }
            }
            else
            {
                MessageBox.Show($"É necessário preencher o campo {typeData.Text} corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empresaMask.Focus();
            }
        }

        private void empresaMask_TextChanged(object sender, EventArgs e)
        {
            tbNomeEmpresa.Text = empresaMask.Text;

            utils.feedbackColorInputNumLetters(empresaMask, typeData);
        }

        private void typeData_Click(object sender, EventArgs e)
        {
            empresaMask.Focus();
        }

        private bool validar()
        {
            if (tbDescricaoTaxa.Text == String.Empty)
            {
                MessageBox.Show("É obrigatório descrever sobre taxa", "Erro", MessageBoxButtons.OK);
                tbDescricaoTaxa.Focus();
                return false;
            }
            else if (tbNomeEmpresa.Text == String.Empty)
            {
                MessageBox.Show("Digite o nome da empresa", "Erro", MessageBoxButtons.OK);
                return false;
            }
            else if (!checkTaxa.Checked && !checkTarifa.Checked)
            {
                MessageBox.Show("Escolha uma se é taxa ou tarifa", "Erro", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}
