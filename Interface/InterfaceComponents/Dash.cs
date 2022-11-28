using Interface.FormsControls;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class Dash : Form
    {
        readonly Utilidades utils = new();

        public Navigation navigationDash = new();

        public string RouteDash = "";

        private string gg = "";

        public DataRow OverviewDataRequest
        {
            set
            {

                if (overview1.CacheType == "Clientes_Fisicos")
                {
                    cadastroClientes1.Pessoa = "CPF";
                    cadastroClientes1.OverviewDataResponse = value;
                }

                if (overview1.CacheType == "Clientes_Juridicos")
                {
                    cadastroClientes1.Pessoa = "CNPJ";
                    cadastroClientes1.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Usuarios"))
                {
                    cadastroUsuarios1.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Rotas"))
                {
                    cadastroRoutes1.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Motoristas"))
                {
                    cadastroMotoristas2.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Veiculos"))
                {
                    cadastroVeiculos1.OverviewDataResponse = value; ;
                }

                if (overview1.CacheType.Contains("Terceiros"))
                {
                    cadastroTerceiros1.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Sinistros"))
                {
                    cadastroSinistros2.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Notas"))
                {
                    cadastroNotasFicais2.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Tarifas"))
                {
                    cadastroTarifaseTaxas1.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Redes"))
                {
                    cadastroRedesDeTransporte2.OverviewDataResponse = value;
                }

            }
        }

        public string RouteDashRequest
        {
            get => RouteDash;
        }

        public void NavigationController(string dash, string over)
        {
            // Declaração do tipo de Form seja renderizado
            navigationDash.TypeControlDash = dash;
            navigationDash.TypeControlOver = over;

            RouteDash = dash;

            // Método para realizar a troca de pagina (igual um SPA)

            navigationDash.NavigationRoutes(
                overview1,
                cadastroClientes1,
                cadastroRoutes1,
                cadastroUsuarios1,
                cadastroMotoristas2,
                cadastroVeiculos1,
                cadastroTerceiros1,
                cadastroSinistros2,
                cadastroNotasFicais2,
                cadastroTarifaseTaxas1,
                cadastroRedesDeTransporte2
              );


            // Métodos para mostrar qual a pagina selecionada no momento

            //*Over
            navigationDash.ColorsNavigationButtons(buttonOver, buttonCa, buttonUp, buttonDel);
            navigationDash.ColorsNavigationLines(lineOverview, lineCadastro, lineUpdate, lineDelete);

            //*Dash

            navigationDash.ColorsNavigationDashButtons(
                (Button)navbar1.Controls["panelDropDown"].Controls["panel33"].Controls["buttonClientes"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel1"].Controls["buttonUsuarios"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel3"].Controls["buttonRotas"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel5"].Controls["buttonMotoristas"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel7"].Controls["buttonVeiculos"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel9"].Controls["buttonTerceiros"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel11"].Controls["buttonSinistros"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel13"].Controls["buttonNotasFicais"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel15"].Controls["buttonTarifasETaxas"],
                (Button)navbar1.Controls["panelDropDown"].Controls["panel17"].Controls["buttonRedesDeTransporte"]
              );

            navigationDash.ColorsNavigationDashLines(
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel33"].Controls["lineClientes"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel1"].Controls["lineUsuarios"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel3"].Controls["lineRotas"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel5"].Controls["lineMotoristas"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel7"].Controls["lineVeiculos"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel9"].Controls["lineTerceiros"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel11"].Controls["lineSinistros"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel13"].Controls["lineNotasFicais"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel15"].Controls["lineTarifasETaxas"],
                (Panel)navbar1.Controls["panelDropDown"].Controls["panel17"].Controls["lineRedesDeTransporte"]
              );
        }

        public Dash()
        {
            InitializeComponent();

            overview1.dash = this;
            navbar1.dash = this;

            overview1.clientes = cadastroClientes1;

            cadastroClientes1.overview = overview1;
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


        private void buttonOver_Click(object sender, EventArgs e)
        {
            NavigationController(navigationDash.TypeControlDash, "Overview");
        }
        public void buttonCa_Click(object sender, EventArgs e)
        {
            NavigationController(navigationDash.TypeControlDash, "Cadastro");
        }

        public void buttonUp_Click(object sender, EventArgs e)
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

        private void overview1_Load(object sender, EventArgs e)
        {

        }
    }
}
