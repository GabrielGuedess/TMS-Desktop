using Interface.Properties;
using System.Windows.Forms;

namespace Interface
{
    public partial class Dash : Form
    {
        readonly Utilidades utils = new();

        readonly Navigation navigationDash = new();

        private void NavigationController(string dash, string over)
        {
            // Declaração do tipo de Form seja renderizado
            navigationDash.TypeControlDash = dash;
            navigationDash.TypeControlOver = over;

            // Método para realizar a troca de pagina (igual um SPA)
            navigationDash.NavigationRoutes(overview1, cadastroClientes1, cadastroRotas1);

            // Métodos para mostrar qual a pagina selecionada no momento
            navigationDash.ColorsNavigationButtons(buttonOver, buttonCa, buttonUp, buttonDel);
            navigationDash.ColorsNavigationLines(lineOverview, lineCadastro, lineUpdate, lineDelete);
            navigationDash.ColorsNavigationDashButtons(buttonClientes, buttonRotas);
            navigationDash.ColorsNavigationDashLines(lineClientes, lineRotas);
        }

        public Dash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NavigationController("Clientes", "Overview");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            utils.expansivePanels(10, panelSerch);

            utils.alignCenterPanels(panel1, containerOverview, true, false, 0, 20);
            utils.alignCenterPanels(panel3, containerCadastro, true, false, 0, 20);
            utils.alignCenterPanels(panel14, containerUpdate, true, false, 0, 20);
            utils.alignCenterPanels(panel16, containerDelete, true, false, 0, 20);

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            NavigationController("Clientes", navigationDash.TypeControlOver);
        }

        private void buttonRotas_Click_1(object sender, EventArgs e)
        {
            NavigationController("Rotas", navigationDash.TypeControlOver);
        }

        private void buttonOver_Click(object sender, EventArgs e)
        {
            NavigationController(navigationDash.TypeControlDash, "Overview");
        }
        public void buttonCa_Click(object sender, EventArgs e)
        {
            NavigationController(navigationDash.TypeControlDash, "Cadastro");
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            NavigationController(navigationDash.TypeControlDash, "Update");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            NavigationController(navigationDash.TypeControlDash, "Delete");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panel1, containerOverview, true, false, 0, 20);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panel3, containerCadastro, true, false, 0, 20);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panel14, containerUpdate, true, false, 0, 20);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panel16, containerDelete, true, false, 0, 20);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, flowLayoutPanel2, Color.FromArgb(30, 30, 36), false, false, false, true);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, panel8, Color.FromArgb(30, 30, 36), false, false, false, true);
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, body, Color.FromArgb(30, 30, 36), true, false, false, false);
        }
    }
}