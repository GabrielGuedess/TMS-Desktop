using Interface.Properties;

namespace Interface
{
    public partial class Overview : UserControl
    {
        readonly Utilidades utils = new();

        public string TypeControl
        {
            set
            {
                buscar.Text = value;
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
