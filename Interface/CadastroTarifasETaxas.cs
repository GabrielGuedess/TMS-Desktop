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
    }
}
