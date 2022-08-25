using Interface.Properties;

namespace Interface
{
    public partial class CadastroVeiculos : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set
            {
                cadastrarVeiculo.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentVeiculos.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentVeiculos.Location = new Point(0, 62);
                }
            }
        }

        public CadastroVeiculos()
        {
            InitializeComponent();
        }

        private void CadastroVeiculos_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelPlaca, panelAno, panelCapacidade, panelRNTRC, panelMotorista, panelValor);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarVeiculo_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarVeiculo);
        }
    }
}
