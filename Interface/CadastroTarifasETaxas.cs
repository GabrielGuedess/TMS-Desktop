using Interface.Properties;

namespace Interface
{
    public partial class CadastroTarifasETaxas : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set
            {
                CadastrarTarifaOuTaxa.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentTarifas.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentTarifas.Location = new Point(0, 62);
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

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private bool validar()
        {
            if(tbDescricaoTaxa.Text == String.Empty)
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

        private void CadastrarTarifaOuTaxa_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                return;
            }
            else
            {
                string selected =string.Empty;
                if (checkTaxa.Checked)
                {
                    selected = "Taxa";
                }
                else if(checkTarifa.Checked)
                {
                    selected = "Tarifa";
                }
                string SQL= "INSERT INTO Tarifas_Taxas (Taxa_Tarifa, Descricao, Nome_Empresa) VALUES";
                SQL += "('" + selected + "','" + tbDescricaoTaxa.Text + "','" + tbNomeEmpresa.Text + "')";
                ConnectDB connectDB = new ConnectDB();
                connectDB.cadastrar(SQL);
                LimparFormularios limpar = new();
                limpar.CleanControl(contentTarifas);
            }
        }
    }
}
