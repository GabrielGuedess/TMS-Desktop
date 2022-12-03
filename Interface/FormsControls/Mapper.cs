using Interface.TemplateComponents;

namespace Interface.FormsControls
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
                TypeWhereDatabase = "ID_usuario";
            }

            if (route.Contains("Rota"))
            {
                TypeDataDatabase = "Rotas";
                TypeWhereDatabase = "ID_rota";
            }

            if (route.Contains("Motoristas"))
            {
                TypeDataDatabase = "Motorista";
                TypeWhereDatabase = "ID_motorista";
            }

            if (route.Contains("Veiculos"))
            {
                TypeDataDatabase = "Veiculo";
                TypeWhereDatabase = "ID_veiculo";
            }

            if (route.Contains("Terceiros"))
            {
                TypeDataDatabase = "MotoristaTerceiro";
                TypeWhereDatabase = "ID_motorista_terceiro";
            }

            if (route.Contains("Sinistros"))
            {
                TypeDataDatabase = "Sinistro";
                TypeWhereDatabase = "ID_Sinistro";
            }

            if (route.Contains("Notas"))
            {
                TypeDataDatabase = "NotaFiscal";
                TypeWhereDatabase = "ID_nota_fiscal";
            }

            if (route.Contains("Tarifas"))
            {
                TypeDataDatabase = "TarifasETaxas";
                TypeWhereDatabase = "ID_ta";
            }

            if (route.Contains("Redes"))
            {
                TypeDataDatabase = "RedeTransporte";
                TypeWhereDatabase = "ID_rede";
            }
        }

        public void mapperForOverview(string route, Label typeData, MasckedboxTemplete maskInput, Panel panelRadio, Panel panelOverview, bool CPF = true)
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
                maskInput.Mask = "00-0000-00000000000000-00-000-000000000-00000000-0";
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
