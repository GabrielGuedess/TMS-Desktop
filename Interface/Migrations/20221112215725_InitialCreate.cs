using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interface.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    ID_cliente = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_endereco = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento_endereco = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_cliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    ID_marca = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome_marca = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_marca);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "motorista",
                columns: table => new
                {
                    ID_motorista = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data_nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Genero = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RG = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_endereco = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento_endereco = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_CNH = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Categoria_CNH = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vencimento_CNH = table.Column<DateOnly>(type: "date", nullable: false),
                    Curso_MOPP = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Disponibilidade = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_motorista);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "motoristaterceiro",
                columns: table => new
                {
                    ID_motorista_terceiro = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data_nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Genero = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RG = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_endereco = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento_endereco = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_CNH = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Categoria_CNH = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vencimento_CNH = table.Column<DateOnly>(type: "date", nullable: false),
                    Curso_MOPP = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Disponibilidade = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_motorista_terceiro);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "notafiscal",
                columns: table => new
                {
                    ID_nota_fiscal = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Chave_acesso = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Serie = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_nota_fiscal);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "pessoajuridica",
                columns: table => new
                {
                    ID_usuario = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome_fantasia = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Inscricao_estadual = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Razao_social = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_endereco = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento_endereco = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celular = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_usuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "redetransporte",
                columns: table => new
                {
                    ID_rede = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo_rede = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Categoria_CNH = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo_veiculo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_rede);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "sinistro",
                columns: table => new
                {
                    ID_Sinistro = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo_sinistro = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_Sinistro);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "tarifasetaxas",
                columns: table => new
                {
                    ID_ta = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome_empresa = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tarifa_ou_taxa = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_ta);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    ID_usuario = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    User_name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celular = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_usuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "celularcliente",
                columns: table => new
                {
                    ID_celular = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_cliente = table.Column<int>(type: "int(11)", nullable: false),
                    Celular = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_celular);
                    table.ForeignKey(
                        name: "FK_cliente4",
                        column: x => x.ID_for_cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_cliente");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "clientefisico",
                columns: table => new
                {
                    ID_for_cliente = table.Column<int>(type: "int(11)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data_nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Genero = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RG = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_for_cliente);
                    table.ForeignKey(
                        name: "FK_cliente2",
                        column: x => x.ID_for_cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_cliente");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "clientejuridico",
                columns: table => new
                {
                    ID_for_cliente = table.Column<int>(type: "int(11)", nullable: false),
                    Nome_fantasia = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Inscricao_estadual = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Razao_social = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_for_cliente);
                    table.ForeignKey(
                        name: "FK_cliente",
                        column: x => x.ID_for_cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_cliente");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "emailcliente",
                columns: table => new
                {
                    ID_email = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_cliente = table.Column<int>(type: "int(11)", nullable: false),
                    Email = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_email);
                    table.ForeignKey(
                        name: "FK_cliente5",
                        column: x => x.ID_for_cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_cliente");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "pedidocliente",
                columns: table => new
                {
                    ID_pedido = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_cliente = table.Column<int>(type: "int(11)", nullable: false),
                    CEP_destino = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro_destino = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_destino = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro_destino = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento_endereco = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade_destino = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF_destino = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_pedido);
                    table.ForeignKey(
                        name: "FK_pedido",
                        column: x => x.ID_for_cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_cliente");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "telefonecliente",
                columns: table => new
                {
                    ID_telefone = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_cliente = table.Column<int>(type: "int(11)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_telefone);
                    table.ForeignKey(
                        name: "FK_cliente3",
                        column: x => x.ID_for_cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_cliente");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "modelo",
                columns: table => new
                {
                    ID_modelo = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ID_for_marca = table.Column<int>(type: "int(11)", nullable: false),
                    Massa_modelo = table.Column<double>(type: "double(6,3) unsigned", nullable: false),
                    Eixo_modelo = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_modelo);
                    table.ForeignKey(
                        name: "FK_marca2",
                        column: x => x.ID_for_marca,
                        principalTable: "marca",
                        principalColumn: "ID_marca");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "veiculo",
                columns: table => new
                {
                    ID_veiculo = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ID_for_marca = table.Column<int>(type: "int(11)", nullable: false),
                    Ano_fabricacao = table.Column<short>(type: "year(4)", nullable: false),
                    Cor = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cod_RENAVAM = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cod_RNTRC = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vencimento_RNTRC = table.Column<DateOnly>(type: "date", nullable: false),
                    Cod_CIOT = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Disponibilidade = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_veiculo);
                    table.ForeignKey(
                        name: "FK_marca",
                        column: x => x.ID_for_marca,
                        principalTable: "marca",
                        principalColumn: "ID_marca");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "celularfuncionario",
                columns: table => new
                {
                    ID_celular = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_funcionario = table.Column<int>(type: "int(11)", nullable: false),
                    Celular = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_celular);
                    table.ForeignKey(
                        name: "FK_funcionario2",
                        column: x => x.ID_for_funcionario,
                        principalTable: "motorista",
                        principalColumn: "ID_motorista");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "emailfuncionario",
                columns: table => new
                {
                    ID_email = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_funcionario = table.Column<int>(type: "int(11)", nullable: false),
                    Email = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_email);
                    table.ForeignKey(
                        name: "FK_funcionario3",
                        column: x => x.ID_for_funcionario,
                        principalTable: "motorista",
                        principalColumn: "ID_motorista");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "telefonefuncionario",
                columns: table => new
                {
                    ID_telefone = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_funcionario = table.Column<int>(type: "int(11)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_telefone);
                    table.ForeignKey(
                        name: "FK_funcionario",
                        column: x => x.ID_for_funcionario,
                        principalTable: "motorista",
                        principalColumn: "ID_motorista");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "celularmotoristaterceiro",
                columns: table => new
                {
                    ID_celular = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_motorista = table.Column<int>(type: "int(11)", nullable: false),
                    Celular = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_celular);
                    table.ForeignKey(
                        name: "FK_terceiro4",
                        column: x => x.ID_for_motorista,
                        principalTable: "motoristaterceiro",
                        principalColumn: "ID_motorista_terceiro");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "contratomotoristaterceiro",
                columns: table => new
                {
                    ID_contrato = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_motorista = table.Column<int>(type: "int(11)", nullable: false),
                    Tipo_contrato = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Inicio_contrato = table.Column<DateOnly>(type: "date", nullable: false),
                    Fim_contrato = table.Column<DateOnly>(type: "date", nullable: false),
                    Situacao_contrato = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Veiculo_proprio = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_contrato);
                    table.ForeignKey(
                        name: "FK_terceiro",
                        column: x => x.ID_for_motorista,
                        principalTable: "motoristaterceiro",
                        principalColumn: "ID_motorista_terceiro");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "emailmotoristaterceiro",
                columns: table => new
                {
                    ID_email = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_motorista = table.Column<int>(type: "int(11)", nullable: false),
                    Email = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_email);
                    table.ForeignKey(
                        name: "FK_terceiro3",
                        column: x => x.ID_for_motorista,
                        principalTable: "motoristaterceiro",
                        principalColumn: "ID_motorista_terceiro");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "telefonemotoristaterceiro",
                columns: table => new
                {
                    ID_telefone = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_motorista = table.Column<int>(type: "int(11)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_telefone);
                    table.ForeignKey(
                        name: "FK_terceiro5",
                        column: x => x.ID_for_motorista,
                        principalTable: "motoristaterceiro",
                        principalColumn: "ID_motorista_terceiro");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "veiculoterceiro",
                columns: table => new
                {
                    ID_veiculo_terceiro = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_motorista = table.Column<int>(type: "int(11)", nullable: false),
                    Placa = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ano_fabricao = table.Column<short>(type: "year(4)", nullable: false),
                    Cod_RENAVAM = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cod_RNTRC = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Vencimento_RNTRC = table.Column<DateOnly>(type: "date", nullable: false),
                    Cod_CIOT = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carroceria = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Massa_modelo = table.Column<double>(type: "double(6,3)", nullable: false),
                    Eixo_modelo = table.Column<int>(type: "int(11)", nullable: false),
                    Massa_carroceria = table.Column<double>(type: "double(6,3)", nullable: false),
                    Eixo_carroceria = table.Column<int>(type: "int(11)", nullable: false),
                    Capacidade_volumetrican = table.Column<double>(type: "double(6,3)", nullable: false),
                    Capacidade_KG = table.Column<double>(type: "double(6,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_veiculo_terceiro);
                    table.ForeignKey(
                        name: "FK_terceiro2",
                        column: x => x.ID_for_motorista,
                        principalTable: "motoristaterceiro",
                        principalColumn: "ID_motorista_terceiro");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "mercadoria",
                columns: table => new
                {
                    ID_mercadoria = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_pedido = table.Column<int>(type: "int(11)", nullable: false),
                    ID_for_cliente = table.Column<int>(type: "int(11)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Massa = table.Column<double>(type: "double(6,3) unsigned", nullable: false),
                    Volume = table.Column<double>(type: "double(6,3) unsigned", nullable: false),
                    Valor = table.Column<double>(type: "double(9,2) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_mercadoria);
                    table.ForeignKey(
                        name: "FK_mercadoria",
                        column: x => x.ID_for_pedido,
                        principalTable: "pedidocliente",
                        principalColumn: "ID_pedido");
                    table.ForeignKey(
                        name: "FK_mercadoria2",
                        column: x => x.ID_for_cliente,
                        principalTable: "cliente",
                        principalColumn: "ID_cliente");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "rota",
                columns: table => new
                {
                    ID_rota = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_pedido = table.Column<int>(type: "int(11)", nullable: false),
                    CEP_partida = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logradouro_partida = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero_partida = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro_partida = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complemento_partida = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade_partida = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF_partida = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Distancia_KM = table.Column<double>(type: "double(6,3) unsigned", nullable: false),
                    Gasto_combustivel_reais = table.Column<double>(type: "double(9,2) unsigned", nullable: false),
                    Gasto_pedagio_reais = table.Column<double>(type: "double(6,2) unsigned", nullable: false),
                    Data_inicio = table.Column<DateOnly>(type: "date", nullable: false),
                    Data_fim = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.ID_rota, x.ID_for_pedido })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "FK_rota",
                        column: x => x.ID_for_pedido,
                        principalTable: "pedidocliente",
                        principalColumn: "ID_pedido");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "rotaretorno",
                columns: table => new
                {
                    ID_retorno = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_rota = table.Column<int>(type: "int(11)", nullable: false),
                    ID_for_pedido = table.Column<int>(type: "int(11)", nullable: false),
                    Distancia_KM = table.Column<double>(type: "double(6,3) unsigned", nullable: false),
                    Gasto_combustivel_reais = table.Column<double>(type: "double(9,2) unsigned", nullable: false),
                    Gasto_pedagio_reais = table.Column<double>(type: "double(6,2) unsigned", nullable: false),
                    Data_inicio = table.Column<DateOnly>(type: "date", nullable: false),
                    Data_fim = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_retorno);
                    table.ForeignKey(
                        name: "FK_retorno2",
                        column: x => x.ID_for_pedido,
                        principalTable: "pedidocliente",
                        principalColumn: "ID_pedido");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "carroceria",
                columns: table => new
                {
                    ID_carroceira = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_modelo = table.Column<int>(type: "int(11)", nullable: false),
                    Descricao_carroceira = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eixo_carroceria = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    Massa_carroceria = table.Column<double>(type: "double(6,3) unsigned", nullable: false),
                    Capacidade_volumetrica = table.Column<double>(type: "double(6,3) unsigned", nullable: false),
                    Capacidade_KG = table.Column<double>(type: "double(6,3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_carroceira);
                    table.ForeignKey(
                        name: "FK_modelo",
                        column: x => x.ID_for_modelo,
                        principalTable: "modelo",
                        principalColumn: "ID_modelo");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "processopedido",
                columns: table => new
                {
                    ID_processo = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ID_for_rota = table.Column<int>(type: "int(11)", nullable: false),
                    ID_for_retorno = table.Column<int>(type: "int(11)", nullable: false),
                    ID_for_veiculo = table.Column<int>(type: "int(11)", nullable: false),
                    ID_for_motorista = table.Column<int>(type: "int(11)", nullable: false),
                    KM_total = table.Column<double>(type: "double(6,3) unsigned", nullable: false),
                    Gasto_total = table.Column<double>(type: "double(9,2) unsigned", nullable: false),
                    Data_inicio = table.Column<DateOnly>(type: "date", nullable: false),
                    DATA_fim = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ID_processo);
                    table.ForeignKey(
                        name: "FK_processo2",
                        column: x => x.ID_for_retorno,
                        principalTable: "rotaretorno",
                        principalColumn: "ID_retorno");
                    table.ForeignKey(
                        name: "FK_processo3",
                        column: x => x.ID_for_veiculo,
                        principalTable: "veiculo",
                        principalColumn: "ID_veiculo");
                    table.ForeignKey(
                        name: "FK_processo4",
                        column: x => x.ID_for_motorista,
                        principalTable: "motorista",
                        principalColumn: "ID_motorista");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateIndex(
                name: "FK_modelo",
                table: "carroceria",
                column: "ID_for_modelo");

            migrationBuilder.CreateIndex(
                name: "Celular",
                table: "celularcliente",
                column: "Celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_cliente4",
                table: "celularcliente",
                column: "ID_for_cliente");

            migrationBuilder.CreateIndex(
                name: "Celular1",
                table: "celularfuncionario",
                column: "Celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_funcionario2",
                table: "celularfuncionario",
                column: "ID_for_funcionario");

            migrationBuilder.CreateIndex(
                name: "Celular2",
                table: "celularmotoristaterceiro",
                column: "Celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_terceiro4",
                table: "celularmotoristaterceiro",
                column: "ID_for_motorista");

            migrationBuilder.CreateIndex(
                name: "CPF",
                table: "clientefisico",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RG",
                table: "clientefisico",
                column: "RG",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CNPJ",
                table: "clientejuridico",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Inscricao_estadual",
                table: "clientejuridico",
                column: "Inscricao_estadual",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Nome_fantasia",
                table: "clientejuridico",
                column: "Nome_fantasia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Razao_social",
                table: "clientejuridico",
                column: "Razao_social",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_terceiro",
                table: "contratomotoristaterceiro",
                column: "ID_for_motorista");

            migrationBuilder.CreateIndex(
                name: "Email",
                table: "emailcliente",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_cliente5",
                table: "emailcliente",
                column: "ID_for_cliente");

            migrationBuilder.CreateIndex(
                name: "Email1",
                table: "emailfuncionario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_funcionario3",
                table: "emailfuncionario",
                column: "ID_for_funcionario");

            migrationBuilder.CreateIndex(
                name: "Email2",
                table: "emailmotoristaterceiro",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_terceiro3",
                table: "emailmotoristaterceiro",
                column: "ID_for_motorista");

            migrationBuilder.CreateIndex(
                name: "Nome_marca",
                table: "marca",
                column: "Nome_marca",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_mercadoria",
                table: "mercadoria",
                column: "ID_for_pedido");

            migrationBuilder.CreateIndex(
                name: "FK_mercadoria2",
                table: "mercadoria",
                column: "ID_for_cliente");

            migrationBuilder.CreateIndex(
                name: "FK_marca2",
                table: "modelo",
                column: "ID_for_marca");

            migrationBuilder.CreateIndex(
                name: "CPF1",
                table: "motorista",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Numero_CNH",
                table: "motorista",
                column: "Numero_CNH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RG1",
                table: "motorista",
                column: "RG",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CPF2",
                table: "motoristaterceiro",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Numero_CNH1",
                table: "motoristaterceiro",
                column: "Numero_CNH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RG2",
                table: "motoristaterceiro",
                column: "RG",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_pedido",
                table: "pedidocliente",
                column: "ID_for_cliente");

            migrationBuilder.CreateIndex(
                name: "Celular3",
                table: "pessoajuridica",
                column: "Celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CNPJ1",
                table: "pessoajuridica",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Email3",
                table: "pessoajuridica",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Inscricao_estadual1",
                table: "pessoajuridica",
                column: "Inscricao_estadual",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Nome_fantasia1",
                table: "pessoajuridica",
                column: "Nome_fantasia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Razao_social1",
                table: "pessoajuridica",
                column: "Razao_social",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Telefone",
                table: "pessoajuridica",
                column: "Telefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_processo",
                table: "processopedido",
                column: "ID_for_rota");

            migrationBuilder.CreateIndex(
                name: "FK_processo2",
                table: "processopedido",
                column: "ID_for_retorno");

            migrationBuilder.CreateIndex(
                name: "FK_processo3",
                table: "processopedido",
                column: "ID_for_veiculo");

            migrationBuilder.CreateIndex(
                name: "FK_processo4",
                table: "processopedido",
                column: "ID_for_motorista");

            migrationBuilder.CreateIndex(
                name: "FK_rota",
                table: "rota",
                column: "ID_for_pedido");

            migrationBuilder.CreateIndex(
                name: "FK_retorno",
                table: "rotaretorno",
                column: "ID_for_rota");

            migrationBuilder.CreateIndex(
                name: "FK_retorno2",
                table: "rotaretorno",
                column: "ID_for_pedido");

            migrationBuilder.CreateIndex(
                name: "FK_cliente3",
                table: "telefonecliente",
                column: "ID_for_cliente");

            migrationBuilder.CreateIndex(
                name: "Telefone1",
                table: "telefonecliente",
                column: "Telefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_funcionario",
                table: "telefonefuncionario",
                column: "ID_for_funcionario");

            migrationBuilder.CreateIndex(
                name: "Telefone2",
                table: "telefonefuncionario",
                column: "Telefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_terceiro5",
                table: "telefonemotoristaterceiro",
                column: "ID_for_motorista");

            migrationBuilder.CreateIndex(
                name: "Telefone3",
                table: "telefonemotoristaterceiro",
                column: "Telefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Celular4",
                table: "usuario",
                column: "Celular",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "CPF3",
                table: "usuario",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Email4",
                table: "usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Telefone4",
                table: "usuario",
                column: "Telefone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "User_name",
                table: "usuario",
                column: "User_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Cod_CIOT",
                table: "veiculo",
                column: "Cod_CIOT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Cod_RENAVAM",
                table: "veiculo",
                column: "Cod_RENAVAM",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Cod_RNTRC",
                table: "veiculo",
                column: "Cod_RNTRC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_marca",
                table: "veiculo",
                column: "ID_for_marca");

            migrationBuilder.CreateIndex(
                name: "Placa",
                table: "veiculo",
                column: "Placa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Cod_CIOT1",
                table: "veiculoterceiro",
                column: "Cod_CIOT",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Cod_RENAVAM1",
                table: "veiculoterceiro",
                column: "Cod_RENAVAM",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Cod_RNTRC1",
                table: "veiculoterceiro",
                column: "Cod_RNTRC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "FK_terceiro2",
                table: "veiculoterceiro",
                column: "ID_for_motorista");

            migrationBuilder.CreateIndex(
                name: "Placa1",
                table: "veiculoterceiro",
                column: "Placa",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carroceria");

            migrationBuilder.DropTable(
                name: "celularcliente");

            migrationBuilder.DropTable(
                name: "celularfuncionario");

            migrationBuilder.DropTable(
                name: "celularmotoristaterceiro");

            migrationBuilder.DropTable(
                name: "clientefisico");

            migrationBuilder.DropTable(
                name: "clientejuridico");

            migrationBuilder.DropTable(
                name: "contratomotoristaterceiro");

            migrationBuilder.DropTable(
                name: "emailcliente");

            migrationBuilder.DropTable(
                name: "emailfuncionario");

            migrationBuilder.DropTable(
                name: "emailmotoristaterceiro");

            migrationBuilder.DropTable(
                name: "mercadoria");

            migrationBuilder.DropTable(
                name: "notafiscal");

            migrationBuilder.DropTable(
                name: "pessoajuridica");

            migrationBuilder.DropTable(
                name: "processopedido");

            migrationBuilder.DropTable(
                name: "redetransporte");

            migrationBuilder.DropTable(
                name: "rota");

            migrationBuilder.DropTable(
                name: "sinistro");

            migrationBuilder.DropTable(
                name: "tarifasetaxas");

            migrationBuilder.DropTable(
                name: "telefonecliente");

            migrationBuilder.DropTable(
                name: "telefonefuncionario");

            migrationBuilder.DropTable(
                name: "telefonemotoristaterceiro");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "veiculoterceiro");

            migrationBuilder.DropTable(
                name: "modelo");

            migrationBuilder.DropTable(
                name: "rotaretorno");

            migrationBuilder.DropTable(
                name: "veiculo");

            migrationBuilder.DropTable(
                name: "motorista");

            migrationBuilder.DropTable(
                name: "motoristaterceiro");

            migrationBuilder.DropTable(
                name: "pedidocliente");

            migrationBuilder.DropTable(
                name: "marca");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
