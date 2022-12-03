using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interface.Migrations
{
    public partial class AddCampoTipoVeiculoInTableModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "veiculoterceiro",
                newName: "VeiculoTerceiro");

            migrationBuilder.RenameTable(
                name: "veiculo",
                newName: "Veiculo");

            migrationBuilder.RenameTable(
                name: "usuario",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "telefonemotoristaterceiro",
                newName: "TelefoneMotoristaTerceiro");

            migrationBuilder.RenameTable(
                name: "telefonefuncionario",
                newName: "TelefoneFuncionario");

            migrationBuilder.RenameTable(
                name: "telefonecliente",
                newName: "TelefoneCliente");

            migrationBuilder.RenameTable(
                name: "tarifasetaxas",
                newName: "TarifasETaxas");

            migrationBuilder.RenameTable(
                name: "sinistro",
                newName: "Sinistro");

            migrationBuilder.RenameTable(
                name: "rotaretorno",
                newName: "RotaRetorno");

            migrationBuilder.RenameTable(
                name: "rota",
                newName: "Rota");

            migrationBuilder.RenameTable(
                name: "redetransporte",
                newName: "RedeTransporte");

            migrationBuilder.RenameTable(
                name: "processopedido",
                newName: "ProcessoPedido");

            migrationBuilder.RenameTable(
                name: "pessoajuridica",
                newName: "PessoaJuridica");

            migrationBuilder.RenameTable(
                name: "pedidocliente",
                newName: "PedidoCliente");

            migrationBuilder.RenameTable(
                name: "notafiscal",
                newName: "NotaFiscal");

            migrationBuilder.RenameTable(
                name: "motoristaterceiro",
                newName: "MotoristaTerceiro");

            migrationBuilder.RenameTable(
                name: "motorista",
                newName: "Motorista");

            migrationBuilder.RenameTable(
                name: "modelo",
                newName: "Modelo");

            migrationBuilder.RenameTable(
                name: "mercadoria",
                newName: "Mercadoria");

            migrationBuilder.RenameTable(
                name: "marca",
                newName: "Marca");

            migrationBuilder.RenameTable(
                name: "emailmotoristaterceiro",
                newName: "EmailMotoristaTerceiro");

            migrationBuilder.RenameTable(
                name: "emailfuncionario",
                newName: "EmailFuncionario");

            migrationBuilder.RenameTable(
                name: "emailcliente",
                newName: "EmailCliente");

            migrationBuilder.RenameTable(
                name: "contratomotoristaterceiro",
                newName: "ContratoMotoristaTerceiro");

            migrationBuilder.RenameTable(
                name: "clientejuridico",
                newName: "ClienteJuridico");

            migrationBuilder.RenameTable(
                name: "clientefisico",
                newName: "ClienteFisico");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "celularmotoristaterceiro",
                newName: "CelularMotoristaTerceiro");

            migrationBuilder.RenameTable(
                name: "celularfuncionario",
                newName: "CelularFuncionario");

            migrationBuilder.RenameTable(
                name: "celularcliente",
                newName: "CelularCliente");

            migrationBuilder.RenameTable(
                name: "carroceria",
                newName: "Carroceria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "VeiculoTerceiro",
                newName: "veiculoterceiro");

            migrationBuilder.RenameTable(
                name: "Veiculo",
                newName: "veiculo");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "usuario");

            migrationBuilder.RenameTable(
                name: "TelefoneMotoristaTerceiro",
                newName: "telefonemotoristaterceiro");

            migrationBuilder.RenameTable(
                name: "TelefoneFuncionario",
                newName: "telefonefuncionario");

            migrationBuilder.RenameTable(
                name: "TelefoneCliente",
                newName: "telefonecliente");

            migrationBuilder.RenameTable(
                name: "TarifasETaxas",
                newName: "tarifasetaxas");

            migrationBuilder.RenameTable(
                name: "Sinistro",
                newName: "sinistro");

            migrationBuilder.RenameTable(
                name: "RotaRetorno",
                newName: "rotaretorno");

            migrationBuilder.RenameTable(
                name: "Rota",
                newName: "rota");

            migrationBuilder.RenameTable(
                name: "RedeTransporte",
                newName: "redetransporte");

            migrationBuilder.RenameTable(
                name: "ProcessoPedido",
                newName: "processopedido");

            migrationBuilder.RenameTable(
                name: "PessoaJuridica",
                newName: "pessoajuridica");

            migrationBuilder.RenameTable(
                name: "PedidoCliente",
                newName: "pedidocliente");

            migrationBuilder.RenameTable(
                name: "NotaFiscal",
                newName: "notafiscal");

            migrationBuilder.RenameTable(
                name: "MotoristaTerceiro",
                newName: "motoristaterceiro");

            migrationBuilder.RenameTable(
                name: "Motorista",
                newName: "motorista");

            migrationBuilder.RenameTable(
                name: "Modelo",
                newName: "modelo");

            migrationBuilder.RenameTable(
                name: "Mercadoria",
                newName: "mercadoria");

            migrationBuilder.RenameTable(
                name: "Marca",
                newName: "marca");

            migrationBuilder.RenameTable(
                name: "EmailMotoristaTerceiro",
                newName: "emailmotoristaterceiro");

            migrationBuilder.RenameTable(
                name: "EmailFuncionario",
                newName: "emailfuncionario");

            migrationBuilder.RenameTable(
                name: "EmailCliente",
                newName: "emailcliente");

            migrationBuilder.RenameTable(
                name: "ContratoMotoristaTerceiro",
                newName: "contratomotoristaterceiro");

            migrationBuilder.RenameTable(
                name: "ClienteJuridico",
                newName: "clientejuridico");

            migrationBuilder.RenameTable(
                name: "ClienteFisico",
                newName: "clientefisico");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "cliente");

            migrationBuilder.RenameTable(
                name: "CelularMotoristaTerceiro",
                newName: "celularmotoristaterceiro");

            migrationBuilder.RenameTable(
                name: "CelularFuncionario",
                newName: "celularfuncionario");

            migrationBuilder.RenameTable(
                name: "CelularCliente",
                newName: "celularcliente");

            migrationBuilder.RenameTable(
                name: "Carroceria",
                newName: "carroceria");
        }
    }
}
