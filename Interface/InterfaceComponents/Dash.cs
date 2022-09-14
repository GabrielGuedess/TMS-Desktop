using Interface.FormsControls;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class Dash : Form
    {
        readonly Utilidades utils = new();

        readonly Navigation navigationDash = new();

        public string RouteDash = "";

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
                    cadastroMotoristas1.OverviewDataResponse = value;
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
                    cadastroSinistros1.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Notas"))
                {
                    cadastroNotasFicais1.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Tarifas"))
                {
                    cadastroTarifaseTaxas1.OverviewDataResponse = value;
                }

                if (overview1.CacheType.Contains("Redes"))
                {
                    cadastroRedesDeTransporte1.OverviewDataResponse = value;
                }

            }
        }

        public string RouteDashRequest
        {
            get => RouteDash;
        }

        private void NavigationController(string dash, string over)
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
                cadastroMotoristas1,
                cadastroVeiculos1,
                cadastroTerceiros1,
                cadastroSinistros1,
                cadastroNotasFicais1,
                cadastroTarifaseTaxas1,
                cadastroRedesDeTransporte1
              );

            // Métodos para mostrar qual a pagina selecionada no momento

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
                buttonNotasFicais,
                buttonTarifasETaxas,
                buttonRedesDeTransporte
              );

            navigationDash.ColorsNavigationDashLines(
                lineClientes,
                lineUsuarios,
                lineRotas,
                lineMotoristas,
                lineVeiculos,
                lineTerceiros,
                lineSinistros,
                lineNotasFicais,
                lineTarifasETaxas,
                lineRedesDeTransporte
              );
        }

        public Dash()
        {
            InitializeComponent();

            overview1.dash = this;
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
        private void buttonTarifasETaxas_Click(object sender, EventArgs e)
        {
            NavigationController("Tarifas", navigationDash.TypeControlOver);
        }
        private void buttonRedesDeTransporte_Click(object sender, EventArgs e)
        {
            NavigationController("Redes", navigationDash.TypeControlOver);
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
    }
}
