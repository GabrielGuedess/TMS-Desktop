﻿using Interface.InterfaceComponents;
using Interface.Utilities;

namespace Interface.FormsControls
{
    public class Navigation
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
            CadastroNotasFicais cadastroNotasFicais,
            CadastroTarifasETaxas cadastroTarifasETaxas,
            CadastroRedesDeTransporte cadastroRedesDeTransporte,
            CadastroPedido pedido,
            TelaProcessoManutencao processoManutencao,
            CadastroEmpresaManutencao cadastroEmpresaManutencao
            )
        {
            if (activeOver == "Overview" || activeOver == "Delete")
            {
                overview.Visible = true;
                overview.TypeControl = $"{activeOver}-{activeDash}";

                cadastroClientes.Visible = false;
                cadastroUsuarios.Visible = false;
                cadastroRotas.Visible = false;
                cadastroMotoristas.Visible = false;
                cadastroVeiculos.Visible = false;
                cadastroTerceiros.Visible = false;
                cadastroSinistros.Visible = false;
                cadastroNotasFicais.Visible = false;
                cadastroTarifasETaxas.Visible = false;
                cadastroRedesDeTransporte.Visible = false;
                pedido.Visible = false;
                processoManutencao.Visible = false;
                cadastroEmpresaManutencao.Visible = false;
            }

            if (activeOver == "Cadastro" || activeOver == "Update")
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
                cadastroTarifasETaxas.Visible = activeDash == "Tarifas";
                cadastroRedesDeTransporte.Visible = activeDash == "Redes";
                pedido.Visible = activeDash == "Pedidos";
                processoManutencao.Visible = activeDash == "Processo";
                cadastroEmpresaManutencao.Visible = activeDash == "Empresa";


                cadastroClientes.TypeControl = $"{activeOver}-{activeDash}";
                cadastroUsuarios.TypeControl = $"{activeOver}-{activeDash}";
                cadastroRotas.TypeControl = $"{activeOver}-{activeDash}";
                cadastroMotoristas.TypeControl = $"{activeOver}-{activeDash}";
                cadastroVeiculos.TypeControl = $"{activeOver}-{activeDash}";
                cadastroTerceiros.TypeControl = $"{activeOver}-{activeDash}";
                cadastroSinistros.TypeControl = $"{activeOver}-{activeDash}";
                cadastroNotasFicais.TypeControl = $"{activeOver}-{activeDash}";
                cadastroTarifasETaxas.TypeControl = $"{activeOver}-{activeDash}";
                cadastroRedesDeTransporte.TypeControl = $"{activeOver}-{activeDash}";
                pedido.TypeControl = $"{activeOver}-{activeDash}";
                processoManutencao.TypeControl = $"{activeOver}-{activeDash}";
                cadastroEmpresaManutencao.TypeControl = $"{activeOver}-{activeDash}";
            }
        }
    }
}
