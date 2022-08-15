using Interface.Properties;

namespace Interface
{
    public partial class Dash : Form
    {
        readonly Utilidades utils = new();

        readonly Navigation navigationDash = new();
        public Dash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            navigationDash.TypeControlDash = "Clientes";
            navigationDash.TypeControlOver = "Overview";

            navigationDash.ClientesNavigation(overview1, cadastroClientes1, buttonClientes, lineClientes);

            navigationDash.ColorsNavigationButtons(buttonOver, buttonCa, buttonUp, buttonDel);
            navigationDash.ColorsNavigationLines(lineOverview, lineCadastro, lineUpdate, lineDelete);
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
            navigationDash.TypeControlDash = "Clientes";

            navigationDash.ClientesNavigation(overview1, cadastroClientes1, buttonClientes, lineClientes);
        }

        private void buttonClientes_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonClientes_MouseLeave(object sender, EventArgs e)
        {

        }

        private void buttonEx_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {

        }


        private void buttonOver_Click(object sender, EventArgs e)
        {
            navigationDash.TypeControlOver = "Overview";

            navigationDash.ClientesNavigation(overview1, cadastroClientes1, buttonClientes, lineClientes);

            navigationDash.ColorsNavigationButtons(buttonOver, buttonCa, buttonUp, buttonDel);
            navigationDash.ColorsNavigationLines(lineOverview, lineCadastro, lineUpdate, lineDelete);
        }
        private void buttonOver_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonOver_MouseLeave(object sender, EventArgs e)
        {

        }
        public void buttonCa_Click(object sender, EventArgs e)
        {
            navigationDash.TypeControlOver = "Cadastro";

            navigationDash.ClientesNavigation(overview1, cadastroClientes1, buttonClientes, lineClientes);

            navigationDash.ColorsNavigationButtons(buttonOver, buttonCa, buttonUp, buttonDel);
            navigationDash.ColorsNavigationLines(lineOverview, lineCadastro, lineUpdate, lineDelete);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            navigationDash.TypeControlOver = "Update";

            navigationDash.ClientesNavigation(overview1, cadastroClientes1, buttonClientes, lineClientes);

            navigationDash.ColorsNavigationButtons(buttonOver, buttonCa, buttonUp, buttonDel);
            navigationDash.ColorsNavigationLines(lineOverview, lineCadastro, lineUpdate, lineDelete);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            navigationDash.TypeControlOver = "Delete";

            navigationDash.ClientesNavigation(overview1, cadastroClientes1, buttonClientes, lineClientes);

            navigationDash.ColorsNavigationButtons(buttonOver, buttonCa, buttonUp, buttonDel);
            navigationDash.ColorsNavigationLines(lineOverview, lineCadastro, lineUpdate, lineDelete);
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

        private void body_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, body, Color.FromArgb(30, 30, 36), true, true, false, false);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, flowLayoutPanel2, Color.FromArgb(30, 30, 36), false, false, false, true);
        }

        private void panelPrices_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}