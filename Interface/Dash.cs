using Interface.Properties;

namespace Interface
{
    public partial class Dash : Form
    {
        readonly Utilidades utils = new();

        readonly Navigation navigationDash = new();

        private void NavigationController(string dash, string over)
        {
            // Declara��o do tipo de Form seja renderizado
            navigationDash.TypeControlDash = dash;
            navigationDash.TypeControlOver = over;

            // M�todo para realizar a troca de pagina (igual um SPA)
            navigationDash.NavigationRoutes(
                overview1,
                cadastroClientes1,
                cadastroRoutes1,
                cadastroUsuarios1,
                cadastroMotoristas1,
                cadastroVeiculos1,
                cadastroTerceiros1,
                cadastroSinistros1,
                cadastroNotasFicais1
              );

            // M�todos para mostrar qual a pagina selecionada no momento

            //*Over
            navigationDash.ColorsNavigationButtons(buttonOver, buttonCa, buttonUp, buttonDel);
            navigationDash.ColorsNavigationLines(lineOverview, lineCadastro, lineUpdate, lineDelete);

            //*Dash
            navigationDash.ColorsNavigationDashButtons(
                buttonClientes,
                buttonUsuarios,
                buttonRotas,
                buttonMotoristas,
                buttonVeiculos,
                buttonTerceiros,
                buttonSinistros,
                buttonNotasFicais
              );

            navigationDash.ColorsNavigationDashLines(
                lineClientes,
                lineUsuarios,
                lineRotas,
                lineMotoristas,
                lineVeiculos,
                lineTerceiros,
                lineSinistros,
                lineNotasFicais
              );
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

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            NavigationController("Usuarios", navigationDash.TypeControlOver);
        }

        private void buttonRotas_Click_1(object sender, EventArgs e)
        {
            NavigationController("Rotas", navigationDash.TypeControlOver);
        }
        private void buttonMotoristas_Click(object sender, EventArgs e)
        {
            NavigationController("Motoristas", navigationDash.TypeControlOver);
        }
        private void buttonVeiculos_Click(object sender, EventArgs e)
        {
            NavigationController("Veiculos", navigationDash.TypeControlOver);
        }
        private void buttonTerceiros_Click(object sender, EventArgs e)
        {
            NavigationController("Terceiros", navigationDash.TypeControlOver);
        }
        private void buttonSinistros_Click(object sender, EventArgs e)
        {
            NavigationController("Sinistros", navigationDash.TypeControlOver);
        }
        private void buttonNotasFicais_Click(object sender, EventArgs e)
        {
            NavigationController("Notas", navigationDash.TypeControlOver);
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