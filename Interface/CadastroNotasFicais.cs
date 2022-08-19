using Interface.Properties;

namespace Interface
{
    public partial class CadastroNotasFicais : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set
            {
                cadastrarNota.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentNotas.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentNotas.Location = new Point(0, 62);
                }
            }
        }

        public CadastroNotasFicais()
        {
            InitializeComponent();
        }

        private void CadastroNotasFicais_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelID, panelTipo);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarNota_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarNota);
        }
    }
}
