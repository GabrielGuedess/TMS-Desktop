using Interface.Properties;

namespace Interface
{
    internal class Navigation
    {
        readonly Utilidades utils = new();

        private string activeDash = "";

        private string activeOver = "";
        public string TypeControlDash
        {
            get => activeDash;
            set => activeDash = value;
        }

        public string TypeControlOver
        {
            get => activeOver;
            set => activeOver = value;
        }

        public void ColorsNavigationButtons(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                if (activeOver == button.Text)
                {
                    utils.paintButton(button);
                }
                else
                {
                    utils.removePaintButton(button);
                }
            }
        }

        public void ColorsNavigationLines(params Panel[] panels)
        {
            foreach (Panel panel in panels)
            {
                if (panel.Name.Contains(activeOver))
                {
                    utils.paintLine(panel);
                }
                else
                {
                    utils.removePaintLine(panel);
                }
            }
        }

        public void ColorsNavigationDashLines(params Panel[] panels)
        {
            foreach (Panel panel in panels)
            {
                if (panel.Name.Contains(activeDash))
                {
                    utils.paintLine(panel);
                }
                else
                {
                    utils.removePaintLine(panel);
                }
            }
        }

        public void ColorsNavigationDashButtons(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                if (button.Name.Contains(activeDash))
                {
                    utils.paintButton(button);
                }
                else
                {
                    utils.removePaintButton(button);
                }
            }
        }

        public void NavigationRoutes(
            Overview overview,
            CadastroClientes cadastroClientes,
            CadastroRoutes cadastroRotas,
            CadastroUsuarios cadastroUsuarios,
            CadastroMotoristas cadastroMotoristas,
            CadastroVeiculos cadastroVeiculos,
            CadastroTerceiros cadastroTerceiros,
            CadastroSinistros cadastroSinistros,
            CadastroNotasFicais cadastroNotasFicais
            )
        {
            if (activeOver == "Overview")
            {
                overview.Visible = true;
                overview.TypeControl = $"Overview-{activeDash}";

                cadastroClientes.Visible = false;
                cadastroUsuarios.Visible = false;
                cadastroRotas.Visible = false;
                cadastroMotoristas.Visible = false;
                cadastroVeiculos.Visible = false;
                cadastroTerceiros.Visible = false;
                cadastroSinistros.Visible = false;
                cadastroNotasFicais.Visible = false;
            }

            if (activeOver == "Cadastro")
            {
                overview.Visible = false;

                cadastroClientes.Visible = activeDash == "Clientes";
                cadastroUsuarios.Visible = activeDash == "Usuarios";
                cadastroRotas.Visible = activeDash == "Rotas";
                cadastroMotoristas.Visible = activeDash == "Motoristas";
                cadastroVeiculos.Visible = activeDash == "Veiculos";
                cadastroTerceiros.Visible = activeDash == "Terceiros";
                cadastroSinistros.Visible = activeDash == "Sinistros";
                cadastroNotasFicais.Visible = activeDash == "Notas";


                cadastroClientes.TypeControl = $"Cadastro-{activeDash}";
                cadastroUsuarios.TypeControl = $"Cadastro-{activeDash}";
                cadastroRotas.TypeControl = $"Cadastro-{activeDash}";
                cadastroMotoristas.TypeControl = $"Cadastro-{activeDash}";
                cadastroVeiculos.TypeControl = $"Cadastro-{activeDash}";
                cadastroTerceiros.TypeControl = $"Cadastro-{activeDash}";
                cadastroSinistros.TypeControl = $"Cadastro-{activeDash}";
                cadastroNotasFicais.TypeControl = $"Cadastro-{activeDash}";
            }

            if (activeOver == "Update")
            {
                overview.Visible = false;

                cadastroClientes.Visible = activeDash == "Clientes";
                cadastroUsuarios.Visible = activeDash == "Usuarios";
                cadastroRotas.Visible = activeDash == "Rotas";
                cadastroMotoristas.Visible = activeDash == "Motoristas";
                cadastroVeiculos.Visible = activeDash == "Veiculos";
                cadastroTerceiros.Visible = activeDash == "Terceiros";
                cadastroSinistros.Visible = activeDash == "Sinistros";
                cadastroNotasFicais.Visible = activeDash == "Notas";

                cadastroClientes.TypeControl = $"Update-{activeDash}";
                cadastroUsuarios.TypeControl = $"Update-{activeDash}";
                cadastroRotas.TypeControl = $"Update-{activeDash}";
                cadastroMotoristas.TypeControl = $"Update-{activeDash}";
                cadastroVeiculos.TypeControl = $"Update-{activeDash}";
                cadastroTerceiros.TypeControl = $"Update-{activeDash}";
                cadastroSinistros.TypeControl = $"Update-{activeDash}";
                cadastroNotasFicais.TypeControl = $"Update-{activeDash}";
            }

            if (activeOver == "Delete")
            {
                overview.Visible = true;
                overview.TypeControl = $"Delete-{activeDash}";

                cadastroClientes.Visible = false;
                cadastroUsuarios.Visible = false;
                cadastroRotas.Visible = false;
                cadastroMotoristas.Visible = false;
                cadastroVeiculos.Visible = false;
                cadastroTerceiros.Visible = false;
                cadastroSinistros.Visible = false;
                cadastroNotasFicais.Visible = false;
            }
        }
    }
}
