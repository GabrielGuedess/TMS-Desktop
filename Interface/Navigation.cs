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
                string panelName = panel.Name.Replace("line", "");

                if (activeOver == panelName)
                {
                    utils.paintLine(panel);
                }
                else
                {
                    utils.removePaintLine(panel);
                }
            }
        }

        public void ClientesNavigation(Overview overview, CadastroClientes cadastroClientes, Button button, Panel line)
        {
            utils.paintButtonPanel(button, line);

            if (activeDash == "Clientes")
            {
                if (activeOver == "Overview")
                {
                    overview.Visible = true;
                    cadastroClientes.Visible = false;
                }

                if (activeOver == "Cadastro")
                {
                    overview.Visible = false;
                    cadastroClientes.Visible = true;
                    cadastroClientes.TypeControl = "Cadastro";
                }

                if (activeOver == "Update")
                {
                    overview.Visible = false;
                    cadastroClientes.Visible = true;
                    cadastroClientes.TypeControl = "Update";
                }

                if (activeOver == "Delete")
                {
                    overview.Visible = false;
                    cadastroClientes.Visible = false;
                    MessageBox.Show("Delete");
                }
            }

        }
    }
}
