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
                TypeDataDatabase = CPF ? "ClienteFisico" : "ClienteJuridico";
                TypeWhereDatabase = TypeDataDatabase == "ClienteFisico" ? "CPF" : "CPNJ";
            }

            if (route.Contains("Usuarios"))
            {
                TypeDataDatabase = "Usuario";
                TypeWhereDatabase = "CPF";
            }

            if (route.Contains("Rota"))
            {
                TypeDataDatabase = "Rotas";
                TypeWhereDatabase = "ID_rota";
            }

            if (route.Contains("Motoristas"))
            {
                TypeDataDatabase = "Motorista";
                TypeWhereDatabase = "CPF";
            }

            if (route.Contains("Veiculos"))
            {
                TypeDataDatabase = "Veiculo";
                TypeWhereDatabase = "Placa";
            }

            if (route.Contains("Terceiros"))
            {
                TypeDataDatabase = "MotoristaTerceiro";
                TypeWhereDatabase = "CPF";
            }

            if (route.Contains("Sinistros"))
            {
                TypeDataDatabase = "Sinistro";
                TypeWhereDatabase = "ID_Sinistro";
            }

            if (route.Contains("Notas"))
            {
                TypeDataDatabase = "NotaFiscal";
                TypeWhereDatabase = "Chave_acesso";
            }

            if (route.Contains("Tarifas"))
            {
                TypeDataDatabase = "TarifasETaxas";
                TypeWhereDatabase = "Nome_empresa";
            }

            if (route.Contains("Redes"))
            {
                TypeDataDatabase = "RedeTransporte";
                TypeWhereDatabase = "ID_rede";
            }

            if (route.Contains("Pedidos"))
            {
                TypeDataDatabase = "PedidoCliente";
                TypeWhereDatabase = "ID_pedido";
            }

            if (route.Contains("Empresa"))
            {
                TypeDataDatabase = "PessoaJuridica";
                TypeWhereDatabase = "CNPJ";
            }

            if (route.Contains("Processo"))
            {
                TypeDataDatabase = "Manutencao";
                TypeWhereDatabase = "ID_manutencao";
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
                typeData.Text = "ID Sinistro";
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
                typeData.Text = "ID Rede";
                maskInput.Text = "";
                maskInput.Mask = "";
            }

            if (route.Contains("Pedidos"))
            {
                typeData.Text = "ID Pedido";
                maskInput.Text = "";
                maskInput.Mask = "";
            }

            if (route.Contains("Empresa"))
            {
                typeData.Text = "CNPJ";
                maskInput.Text = "";
                maskInput.Mask = "00.000.000/0000-00";
            }

            if (route.Contains("Processo"))
            {
                typeData.Text = "Placa";
                maskInput.Text = "";
                maskInput.Mask = "&&&&&&&";
            }
        }
    }
}
