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
    }
}
