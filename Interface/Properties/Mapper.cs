namespace Interface.Properties
{
    internal class Mapper
    {
        public string? TypeDataDatabase;

        public string? TypeWhereDatabase;

        public void mapperForDatabase(string route, bool CPF)
        {
            if (route.Contains("Clientes"))
            {
                TypeDataDatabase = CPF ? "Clientes_Fisicos" : "Clientes_Juridicos";
                TypeWhereDatabase = TypeDataDatabase == "Clientes_Fisicos" ? "CPF" : "CPNJ";
            }

            if (route.Contains("Usuarios"))
            {
                TypeDataDatabase = "Usuario";
                TypeWhereDatabase = "CPF";
            }

            if (route.Contains("Rotas"))
            {
                TypeDataDatabase = "Rotas";
                TypeWhereDatabase = "ID_Rota";
            }

            if (route.Contains("Motoristas"))
            {
                TypeDataDatabase = "C_Motoristas";
                TypeWhereDatabase = "CPF";
            }

            if (route.Contains("Veiculos"))
            {
                TypeDataDatabase = "tbVeiculos";
                TypeWhereDatabase = "Placa";
            }

            if (route.Contains("Terceiros"))
            {
                TypeDataDatabase = "tbTerceiros";
                TypeWhereDatabase = "CPF";
            }

            if (route.Contains("Sinistros"))
            {
                TypeDataDatabase = "tbSinistros";
                TypeWhereDatabase = "ID";
            }

            if (route.Contains("Notas"))
            {
                TypeDataDatabase = "C_Nota_Fiscal";
                TypeWhereDatabase = "CHAVE_ACESSO";
            }

            if (route.Contains("Tarifas"))
            {
                TypeDataDatabase = "Tarifas_taxas";
                TypeWhereDatabase = "Nome_Emp";
            }

            if (route.Contains("Redes"))
            {
                TypeDataDatabase = "C_Redes_de_Transporte";
                TypeWhereDatabase = "ID_REDE";
            }
        }

        public void mapperForOverview(string route, Label typeData, masckedboxTemplete maskInput, Panel panelRadio, Panel panelOverview, bool CPF = true)
        {
            if (route.Contains("Clientes"))
            {
                panelRadio.Visible = true;
                panelOverview.Location = new Point(0, 124);

                typeData.Text = CPF ? "CPF" : "CNPJ";
                maskInput.Text = "";
                maskInput.Mask = CPF ? "000.000.000-00" : "00.000.000/0000-00";
            }

            if (route.Contains("Usuarios"))
            {
                typeData.Text = "CPF";
                maskInput.Text = "";
                maskInput.Mask = "000.000.000-00";
            }

            if (route.Contains("Rotas"))
            {
                typeData.Text = "ID";
                maskInput.Text = "";
                maskInput.Mask = "";
            }

            if (route.Contains("Motoristas"))
            {
                typeData.Text = "CPF";
                maskInput.Text = "";
                maskInput.Mask = "000.000.000-00";
            }

            if (route.Contains("Veiculos"))
            {
                typeData.Text = "Placa";
                maskInput.Text = "";
                maskInput.Mask = ">&&&&&&&";
            }

            if (route.Contains("Terceiros"))
            {
                typeData.Text = "CPF";
                maskInput.Text = "";
                maskInput.Mask = "000.000.000-00";
            }

            if (route.Contains("Sinistros"))
            {
                typeData.Text = "Código";
                maskInput.Text = "";
                maskInput.Mask = "";
            }

            if (route.Contains("Notas"))
            {
                typeData.Text = "Chave de Acesso";
                maskInput.Text = "";
                maskInput.Mask = "";
            }

            if (route.Contains("Tarifas"))
            {
                typeData.Text = "Nome da empresa";
                maskInput.Text = "";
                maskInput.Mask = "";
            }

            if (route.Contains("Redes"))
            {
                typeData.Text = "ID REDE";
                maskInput.Text = "";
                maskInput.Mask = "";
            }
        }
    }
}
