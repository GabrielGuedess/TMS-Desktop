using Interface.Properties;

namespace Interface.InterfaceComponents
{
    public partial class Navbar : UserControl
    {
        public Dash? dash { get; set; }

        private bool isCollapsedCadastro;

        private bool isCollapsedPlanejamento;

        public Navbar()
        {
            InitializeComponent();
        }
        private void Navbar_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (panelDropDown.Height == panelDropDown.MaximumSize.Height)
            {
                isCollapsedCadastro = false;
            }
            else
            {
                isCollapsedCadastro = true;
            }
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Clientes", dash!.navigationDash.TypeControlOver);
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Usuarios", dash!.navigationDash.TypeControlOver);
        }

        private void buttonRotas_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Rotas", dash!.navigationDash.TypeControlOver);
        }

        private void buttonMotoristas_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Motoristas", dash!.navigationDash.TypeControlOver);
        }

        private void buttonVeiculos_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Veiculos", dash!.navigationDash.TypeControlOver);
        }

        private void buttonTerceiros_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Terceiros", dash!.navigationDash.TypeControlOver);
        }

        private void buttonSinistros_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Sinistros", dash!.navigationDash.TypeControlOver);
        }

        private void buttonNotasFicais_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Notas", dash!.navigationDash.TypeControlOver);
        }

        private void buttonTarifasETaxas_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Tarifas", dash!.navigationDash.TypeControlOver);
        }

        private void buttonRedesDeTransporte_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Redes", dash!.navigationDash.TypeControlOver);
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Pedidos", dash!.navigationDash.TypeControlOver);
        }

        private void buttonEmpresa_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Empresa", dash!.navigationDash.TypeControlOver);
        }

        private void buttonProcesso_Click(object sender, EventArgs e)
        {
            dash!.NavigationController("Processo", dash!.navigationDash.TypeControlOver);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsedCadastro)
            {
                buttonCadastro.ForeColor = Color.FromArgb(0, 98, 255);
                buttonCadastro.Image = Resources.ep_arrow_right_bold_top;

                panelDropDown.Height += 10;

                if (panelDropDown.Height == panelDropDown.MaximumSize.Height)
                {
                    timer1.Stop();
                    isCollapsedCadastro = false;
                }
            }
            else
            {
                buttonCadastro.ForeColor = Color.White;
                buttonCadastro.Image = Resources.ep_arrow_right_bold_down;

                panelDropDown.Height -= 10;

                if (panelDropDown.Height == panelDropDown.MinimumSize.Height)
                {
                    timer1.Stop();
                    isCollapsedCadastro = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsedPlanejamento)
            {
                buttonManutencao.ForeColor = Color.FromArgb(0, 98, 255);
                buttonManutencao.Image = Resources.ep_arrow_right_bold_top;

                panelDropDownPlan.Height += 10;

                if (panelDropDownPlan.Height == panelDropDownPlan.MaximumSize.Height)
                {
                    timer2.Stop();
                    isCollapsedPlanejamento = false;
                }
            }
            else
            {
                buttonManutencao.ForeColor = Color.White;
                buttonManutencao.Image = Resources.ep_arrow_right_bold_down;
                panelDropDownPlan.Height -= 10;

                if (panelDropDownPlan.Height == panelDropDownPlan.MinimumSize.Height)
                {
                    timer2.Stop();
                    isCollapsedPlanejamento = true;
                }
            }
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (panelDropDown.Height == panelDropDown.MaximumSize.Height)
            {
                isCollapsedCadastro = false;
            }
            else
            {
                isCollapsedCadastro = true;
            }
        }

        private void buttonPlanejamento_Click(object sender, EventArgs e)
        {
            timer2.Start();

            if (panelDropDownPlan.Height == panelDropDownPlan.MaximumSize.Height)
            {
                isCollapsedPlanejamento = false;
            }
            else
            {
                isCollapsedPlanejamento = true;
            }
        }
    }
}
