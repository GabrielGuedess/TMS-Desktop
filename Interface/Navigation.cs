using Interface.Properties;

namespace Interface
{
    internal class Navigation
    {
        public static void ClientesNavigation(CadastroClientes cadastroClientes, Button buttonClientes, Panel lineClientes)
        {
            Utilidades utils = new();

            string activeDash = "";

            string activeOver = "";

            if (activeDash == "Clientes")
            {
                utils.paintButton_Panel(buttonClientes, lineClientes);

                if (activeOver == "Overview")
                {
                    cadastroClientes.Visible = false;
                }

                if (activeOver == "Cadastro")
                {
                    cadastroClientes.Visible = true;
                }

                if (activeOver == "Update")
                {
                    cadastroClientes.Visible = false;
                }

                if (activeOver == "Delete")
                {
                    cadastroClientes.Visible = false;
                }
            }


        }
    }
}
