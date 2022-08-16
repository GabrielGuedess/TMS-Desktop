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
            get
            {
                return activeDash;
            }
            set
            {
                activeDash = value;

            }
        }

        public string TypeControlOver
        {
            get
            {
                return activeOver;
            }
            set
            {
                activeOver = value;

            }
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
                if (button.Text.Contains(activeDash))
                {
                    utils.paintButton(button);
                }
                else
                {
                    utils.removePaintButton(button);
                }
            }
        }

        public void NavigationRoutes(Overview overview, CadastroClientes cadastroClientes, CadastroRotas cadastroRotas)
        {
            if (activeDash == "Clientes")
            {
                if (activeOver == "Overview")
                {
                    overview.Visible = true;
                    overview.TypeControl = "Overview-Clientes";
                    cadastroClientes.Visible = false;
                    cadastroRotas.Visible = false;
                }

                if (activeOver == "Cadastro")
                {
                    overview.Visible = false;
                    cadastroClientes.Visible = true;
                    cadastroClientes.TypeControl = "Cadastro-Clientes";
                    cadastroRotas.Visible = false;
                }

                if (activeOver == "Update")
                {
                    overview.Visible = false;
                    cadastroClientes.Visible = true;
                    cadastroClientes.TypeControl = "Update-Clientes";
                    cadastroRotas.Visible = false;
                }

                if (activeOver == "Delete")
                {
                    overview.Visible = true;
                    overview.TypeControl = "Delete-Clientes";
                    cadastroClientes.Visible = false;
                    cadastroRotas.Visible = false;
                }
            }

            if (activeDash == "Rotas")
            {
                if (activeOver == "Overview")
                {
                    overview.Visible = true;
                    overview.TypeControl = "Overview-Rotas";
                    cadastroRotas.Visible = false;
                }

                if (activeOver == "Cadastro")
                {
                    overview.Visible = false;
                    cadastroRotas.Visible = true;
                    cadastroRotas.TypeControl = "Update-Rotas";
                }

                if (activeOver == "Update")
                {
                    overview.Visible = false;
                    cadastroRotas.Visible = true;
                    cadastroRotas.TypeControl = "Update-Rotas";
                }

                if (activeOver == "Delete")
                {
                    overview.Visible = true;
                    overview.TypeControl = "Delete-Rotas";
                    cadastroRotas.Visible = false;
                }
            }
        }
    }
}
