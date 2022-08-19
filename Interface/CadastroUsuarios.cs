using Interface.Properties;

namespace Interface
{
    public partial class CadastroUsuarios : UserControl
    {
        readonly Utilidades utils = new();

        public string TypeControl
        {
            set
            {
                cadastrarUsuario.Text = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    contentUsuario.Location = new Point(0, 0);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    contentUsuario.Location = new Point(0, 62);
                }
            }
        }

        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void CadastroUsuarios_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
            utils.expansivePanels(10, panelBorderRoundedNome, panelBorderRoundedCelular);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, searchPanel, true, true);
        }

        private void cadastrarUsuario_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarUsuario);
        }
    }
}
