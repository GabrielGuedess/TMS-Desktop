using Interface.Properties;

namespace Interface
{
    public partial class Overview : UserControl
    {
        readonly Utilidades utils = new();

        readonly Navigation navigationDash = new();

        public string TypeControl
        {
            set
            {
                buscar.Text = value;

                if (value.Contains("Clientes"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "000.000.000-00";
                }

                if (value.Contains("Usuarios"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "000.000.000-00";
                }

                if (value.Contains("Rotas"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }

                if (value.Contains("Motoristas"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "000.000.000-00";
                }

                if (value.Contains("Veiculos"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "&&&&&&&";
                }

                if (value.Contains("Terceiros"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "000.000.000-00";
                }

                if (value.Contains("Sinistros"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }

                if (value.Contains("Notas"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }

                if (value.Contains("Tarifas"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }
                if (value.Contains("Redes"))
                {
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }
            }
        }
        public Overview()
        {
            InitializeComponent();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, panel17, Color.FromArgb(0, 98, 255), false, false, false, true);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        private void Overview_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            utils.expansiveDataGrid(20, dataGridView1);
        }

        private void buscar_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscar);
        }
    }
}
