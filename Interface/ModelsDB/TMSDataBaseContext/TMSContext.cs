using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Interface.ModelsDB.TMSDataBaseContext
{
    public partial class TMSContext : DbContext
    {
        public TMSContext()
        {
        }

        public TMSContext(DbContextOptions<TMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carroceria> Carroceria { get; set; } = null!;
        public virtual DbSet<CelularCliente> CelularCliente { get; set; } = null!;
        public virtual DbSet<CelularFuncionario> CelularFuncionario { get; set; } = null!;
        public virtual DbSet<CelularMotoristaTerceiro> CelularMotoristaTerceiro { get; set; } = null!;
        public virtual DbSet<Cliente> Cliente { get; set; } = null!;
        public virtual DbSet<ClienteFisico> ClienteFisico { get; set; } = null!;
        public virtual DbSet<ClienteJuridico> ClienteJuridico { get; set; } = null!;
        public virtual DbSet<ContratoMotoristaTerceiro> ContratoMotoristaTerceiro { get; set; } = null!;
        public virtual DbSet<EmailCliente> EmailCliente { get; set; } = null!;
        public virtual DbSet<EmailFuncionario> EmailFuncionario { get; set; } = null!;
        public virtual DbSet<EmailMotoristaTerceiro> EmailMotoristaTerceiro { get; set; } = null!;
        public virtual DbSet<Manutencao> Manutencao { get; set; } = null!;
        public virtual DbSet<Marca> Marca { get; set; } = null!;
        public virtual DbSet<Mercadoria> Mercadoria { get; set; } = null!;
        public virtual DbSet<Modelo> Modelo { get; set; } = null!;
        public virtual DbSet<Motorista> Motorista { get; set; } = null!;
        public virtual DbSet<MotoristaTerceiro> MotoristaTerceiro { get; set; } = null!;
        public virtual DbSet<NotaFiscal> NotaFiscal { get; set; } = null!;
        public virtual DbSet<PedidoCliente> PedidoCliente { get; set; } = null!;
        public virtual DbSet<PessoaJuridica> PessoaJuridica { get; set; } = null!;
        public virtual DbSet<ProcessoManutencao> ProcessoManutencao { get; set; } = null!;
        public virtual DbSet<ProcessoPedido> ProcessoPedido { get; set; } = null!;
        public virtual DbSet<RedeTransporte> RedeTransporte { get; set; } = null!;
        public virtual DbSet<Rota> Rota { get; set; } = null!;
        public virtual DbSet<RotaRetorno> RotaRetorno { get; set; } = null!;
        public virtual DbSet<Sinistro> Sinistro { get; set; } = null!;
        public virtual DbSet<TarifasETaxas> TarifasETaxas { get; set; } = null!;
        public virtual DbSet<TelefoneCliente> TelefoneCliente { get; set; } = null!;
        public virtual DbSet<TelefoneFuncionario> TelefoneFuncionario { get; set; } = null!;
        public virtual DbSet<TelefoneMotoristaTerceiro> TelefoneMotoristaTerceiro { get; set; } = null!;
        public virtual DbSet<TipoVeiculo> TipoVeiculo { get; set; } = null!;
        public virtual DbSet<Usuario> Usuario { get; set; } = null!;
        public virtual DbSet<Veiculo> Veiculo { get; set; } = null!;
        public virtual DbSet<VeiculoTerceiro> VeiculoTerceiro { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;database=tms", ServerVersion.Parse("10.4.22-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Carroceria>(entity =>
            {
                entity.HasKey(e => e.ID_carroceria)
                    .HasName("PRIMARY");

                entity.Property(e => e.ID_carroceria).HasColumnType("int(11)");

                entity.Property(e => e.Capacidade_volumetrica).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Descricao_carroceira).HasMaxLength(30);

                entity.Property(e => e.Eixo_carroceria).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Massa_carroceria).HasColumnType("double(9,3) unsigned");
            });

            modelBuilder.Entity<CelularCliente>(entity =>
            {
                entity.HasKey(e => e.ID_celular)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Celular, "Celular")
                    .IsUnique();

                entity.HasIndex(e => e.ID_for_cliente, "FK_cliente4");

                entity.Property(e => e.ID_celular).HasColumnType("int(11)");

                entity.Property(e => e.Celular).HasMaxLength(11);

                entity.Property(e => e.ID_for_cliente).HasColumnType("int(11)");

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithMany(p => p.CelularCliente)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .HasConstraintName("FK_cliente4");
            });

            modelBuilder.Entity<CelularFuncionario>(entity =>
            {
                entity.HasKey(e => e.ID_celular)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Celular, "Celular")
                    .IsUnique();

                entity.HasIndex(e => e.ID_for_funcionario, "FK_funcionario2");

                entity.Property(e => e.ID_celular).HasColumnType("int(11)");

                entity.Property(e => e.Celular).HasMaxLength(11);

                entity.Property(e => e.ID_for_funcionario).HasColumnType("int(11)");

                entity.HasOne(d => d.ID_for_funcionarioNavigation)
                    .WithMany(p => p.CelularFuncionario)
                    .HasForeignKey(d => d.ID_for_funcionario)
                    .HasConstraintName("FK_funcionario2");
            });

            modelBuilder.Entity<CelularMotoristaTerceiro>(entity =>
            {
                entity.HasKey(e => e.ID_celular)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Celular, "Celular")
                    .IsUnique();

                entity.HasIndex(e => e.ID_for_motorista, "FK_terceiro4");

                entity.Property(e => e.ID_celular).HasColumnType("int(11)");

                entity.Property(e => e.Celular).HasMaxLength(11);

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.CelularMotoristaTerceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .HasConstraintName("FK_terceiro4");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.ID_cliente)
                    .HasName("PRIMARY");

                entity.Property(e => e.ID_cliente).HasColumnType("int(11)");

                entity.Property(e => e.Bairro).HasMaxLength(40);

                entity.Property(e => e.CEP).HasMaxLength(8);

                entity.Property(e => e.Cidade).HasMaxLength(40);

                entity.Property(e => e.Complemento_endereco).HasMaxLength(40);

                entity.Property(e => e.Logradouro).HasMaxLength(40);

                entity.Property(e => e.Numero_endereco).HasMaxLength(10);

                entity.Property(e => e.Tipo_cliente)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UF).HasMaxLength(2);
            });

            modelBuilder.Entity<ClienteFisico>(entity =>
            {
                entity.HasKey(e => e.ID_for_cliente)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CPF, "CPF")
                    .IsUnique();

                entity.HasIndex(e => e.RG, "RG")
                    .IsUnique();

                entity.Property(e => e.ID_for_cliente)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CPF).HasMaxLength(11);

                entity.Property(e => e.Genero).HasMaxLength(9);

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.RG).HasMaxLength(15);

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithOne(p => p.ClienteFisico)
                    .HasForeignKey<ClienteFisico>(d => d.ID_for_cliente)
                    .HasConstraintName("FK_cliente2");
            });

            modelBuilder.Entity<ClienteJuridico>(entity =>
            {
                entity.HasKey(e => e.ID_for_cliente)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CNPJ, "CNPJ")
                    .IsUnique();

                entity.HasIndex(e => e.Inscricao_estadual, "Inscricao_estadual")
                    .IsUnique();

                entity.HasIndex(e => e.Nome_fantasia, "Nome_fantasia")
                    .IsUnique();

                entity.HasIndex(e => e.Razao_social, "Razao_social")
                    .IsUnique();

                entity.Property(e => e.ID_for_cliente)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CNPJ).HasMaxLength(14);

                entity.Property(e => e.Inscricao_estadual).HasMaxLength(9);

                entity.Property(e => e.Nome_fantasia).HasMaxLength(40);

                entity.Property(e => e.Razao_social).HasMaxLength(70);

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithOne(p => p.ClienteJuridico)
                    .HasForeignKey<ClienteJuridico>(d => d.ID_for_cliente)
                    .HasConstraintName("FK_cliente");
            });

            modelBuilder.Entity<ContratoMotoristaTerceiro>(entity =>
            {
                entity.HasKey(e => e.ID_contrato)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_motorista, "FK_terceiro");

                entity.Property(e => e.ID_contrato).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.Property(e => e.Situacao_contrato).HasMaxLength(50);

                entity.Property(e => e.Tipo_contrato).HasMaxLength(50);

                entity.Property(e => e.Veiculo_proprio).HasMaxLength(3);

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.ContratoMotoristaTerceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .HasConstraintName("FK_terceiro");
            });

            modelBuilder.Entity<EmailCliente>(entity =>
            {
                entity.HasKey(e => e.ID_email)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Email, "Email")
                    .IsUnique();

                entity.HasIndex(e => e.ID_for_cliente, "FK_cliente5");

                entity.Property(e => e.ID_email).HasColumnType("int(11)");

                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.ID_for_cliente).HasColumnType("int(11)");

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithMany(p => p.EmailCliente)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .HasConstraintName("FK_cliente5");
            });

            modelBuilder.Entity<EmailFuncionario>(entity =>
            {
                entity.HasKey(e => e.ID_email)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Email, "Email")
                    .IsUnique();

                entity.HasIndex(e => e.ID_for_funcionario, "FK_funcionario3");

                entity.Property(e => e.ID_email).HasColumnType("int(11)");

                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.ID_for_funcionario).HasColumnType("int(11)");

                entity.HasOne(d => d.ID_for_funcionarioNavigation)
                    .WithMany(p => p.EmailFuncionario)
                    .HasForeignKey(d => d.ID_for_funcionario)
                    .HasConstraintName("FK_funcionario3");
            });

            modelBuilder.Entity<EmailMotoristaTerceiro>(entity =>
            {
                entity.HasKey(e => e.ID_email)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Email, "Email")
                    .IsUnique();

                entity.HasIndex(e => e.ID_for_motorista, "FK_terceiro3");

                entity.Property(e => e.ID_email).HasColumnType("int(11)");

                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.EmailMotoristaTerceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .HasConstraintName("FK_terceiro3");
            });

            modelBuilder.Entity<Manutencao>(entity =>
            {
                entity.HasKey(e => e.ID_manutencao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_empresa, "FK_manutencao");

                entity.HasIndex(e => e.ID_for_processo_manutencao, "FK_manutencao2");

                entity.HasIndex(e => e.ID_for_veiculo, "FK_manutencao3");

                entity.Property(e => e.ID_manutencao).HasColumnType("int(11)");

                entity.Property(e => e.Detalhamento).HasMaxLength(60);

                entity.Property(e => e.ID_for_empresa).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_processo_manutencao).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_veiculo).HasColumnType("int(11)");

                entity.Property(e => e.Tipo_manutencao)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Valor_reais).HasColumnType("double(9,2) unsigned");

                entity.HasOne(d => d.ID_for_empresaNavigation)
                    .WithMany(p => p.Manutencao)
                    .HasForeignKey(d => d.ID_for_empresa)
                    .HasConstraintName("FK_manutencao");

                entity.HasOne(d => d.ID_for_processo_manutencaoNavigation)
                    .WithMany(p => p.Manutencao)
                    .HasForeignKey(d => d.ID_for_processo_manutencao)
                    .HasConstraintName("FK_manutencao2");

                entity.HasOne(d => d.ID_for_veiculoNavigation)
                    .WithMany(p => p.Manutencao)
                    .HasForeignKey(d => d.ID_for_veiculo)
                    .HasConstraintName("FK_manutencao3");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.ID_marca)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Nome_marca, "Nome_marca")
                    .IsUnique();

                entity.Property(e => e.ID_marca).HasColumnType("int(11)");

                entity.Property(e => e.Nome_marca).HasMaxLength(25);
            });

            modelBuilder.Entity<Mercadoria>(entity =>
            {
                entity.HasKey(e => e.ID_mercadoria)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_pedido, "FK_mercadoria");

                entity.HasIndex(e => e.ID_for_cliente, "FK_mercadoria2");

                entity.Property(e => e.ID_mercadoria).HasColumnType("int(11)");

                entity.Property(e => e.Descricao).HasMaxLength(40);

                entity.Property(e => e.ID_for_cliente).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_pedido).HasColumnType("int(11)");

                entity.Property(e => e.Massa).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Valor).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.Volume).HasColumnType("double(9,3) unsigned");

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithMany(p => p.Mercadoria)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .HasConstraintName("FK_mercadoria2");

                entity.HasOne(d => d.ID_for_pedidoNavigation)
                    .WithMany(p => p.Mercadoria)
                    .HasForeignKey(d => d.ID_for_pedido)
                    .HasConstraintName("FK_mercadoria");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasKey(e => e.ID_modelo)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_marca, "FK_marca2");

                entity.HasIndex(e => e.ID_for_tipo_veiculo, "FK_tipoVeiculo2");

                entity.Property(e => e.ID_modelo).HasColumnType("int(11)");

                entity.Property(e => e.Capacidade_KG).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Capacidade_volumetrica).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Eixo_modelo).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ID_for_marca).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_tipo_veiculo).HasColumnType("int(11)");

                entity.Property(e => e.Massa_modelo).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Nome).HasMaxLength(50);

                entity.HasOne(d => d.ID_for_marcaNavigation)
                    .WithMany(p => p.Modelo)
                    .HasForeignKey(d => d.ID_for_marca)
                    .HasConstraintName("FK_marca2");

                entity.HasOne(d => d.ID_for_tipo_veiculoNavigation)
                    .WithMany(p => p.Modelo)
                    .HasForeignKey(d => d.ID_for_tipo_veiculo)
                    .HasConstraintName("FK_tipoVeiculo2");
            });

            modelBuilder.Entity<Motorista>(entity =>
            {
                entity.HasKey(e => e.ID_motorista)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CPF, "CPF")
                    .IsUnique();

                entity.HasIndex(e => e.Numero_CNH, "Numero_CNH")
                    .IsUnique();

                entity.HasIndex(e => e.RG, "RG")
                    .IsUnique();

                entity.Property(e => e.ID_motorista).HasColumnType("int(11)");

                entity.Property(e => e.Bairro).HasMaxLength(40);

                entity.Property(e => e.CEP).HasMaxLength(8);

                entity.Property(e => e.CPF).HasMaxLength(11);

                entity.Property(e => e.Categoria_CNH)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Cidade).HasMaxLength(40);

                entity.Property(e => e.Complemento_endereco).HasMaxLength(40);

                entity.Property(e => e.Curso_MOPP).HasMaxLength(3);

                entity.Property(e => e.Genero).HasMaxLength(9);

                entity.Property(e => e.Logradouro).HasMaxLength(40);

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.Numero_CNH).HasMaxLength(11);

                entity.Property(e => e.Numero_endereco).HasMaxLength(10);

                entity.Property(e => e.RG).HasMaxLength(15);

                entity.Property(e => e.UF).HasMaxLength(2);
            });

            modelBuilder.Entity<MotoristaTerceiro>(entity =>
            {
                entity.HasKey(e => e.ID_motorista_terceiro)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CPF, "CPF")
                    .IsUnique();

                entity.HasIndex(e => e.Numero_CNH, "Numero_CNH")
                    .IsUnique();

                entity.HasIndex(e => e.RG, "RG")
                    .IsUnique();

                entity.Property(e => e.ID_motorista_terceiro).HasColumnType("int(11)");

                entity.Property(e => e.Bairro).HasMaxLength(40);

                entity.Property(e => e.CEP).HasMaxLength(8);

                entity.Property(e => e.CPF).HasMaxLength(11);

                entity.Property(e => e.Categoria_CNH)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Cidade).HasMaxLength(40);

                entity.Property(e => e.Complemento_endereco).HasMaxLength(40);

                entity.Property(e => e.Curso_MOPP).HasMaxLength(3);

                entity.Property(e => e.Genero).HasMaxLength(9);

                entity.Property(e => e.Logradouro).HasMaxLength(40);

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.Numero_CNH).HasMaxLength(11);

                entity.Property(e => e.Numero_endereco).HasMaxLength(10);

                entity.Property(e => e.RG).HasMaxLength(15);

                entity.Property(e => e.UF).HasMaxLength(2);
            });

            modelBuilder.Entity<NotaFiscal>(entity =>
            {
                entity.HasKey(e => e.ID_nota_fiscal)
                    .HasName("PRIMARY");

                entity.Property(e => e.ID_nota_fiscal).HasColumnType("int(11)");

                entity.Property(e => e.Chave_acesso).HasMaxLength(50);

                entity.Property(e => e.Descricao).HasMaxLength(30);

                entity.Property(e => e.Numero).HasMaxLength(50);

                entity.Property(e => e.Serie).HasMaxLength(50);

                entity.Property(e => e.Tipo).HasMaxLength(50);
            });

            modelBuilder.Entity<PedidoCliente>(entity =>
            {
                entity.HasKey(e => e.ID_pedido)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_cliente, "FK_pedido");

                entity.Property(e => e.ID_pedido).HasColumnType("int(11)");

                entity.Property(e => e.Bairro_destino).HasMaxLength(40);

                entity.Property(e => e.CEP_destino).HasMaxLength(8);

                entity.Property(e => e.Cidade_destino).HasMaxLength(40);

                entity.Property(e => e.Complemento_endereco).HasMaxLength(40);

                entity.Property(e => e.ID_for_cliente).HasColumnType("int(11)");

                entity.Property(e => e.Logradouro_destino).HasMaxLength(40);

                entity.Property(e => e.Numero_destino).HasMaxLength(10);

                entity.Property(e => e.UF_destino).HasMaxLength(2);

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithMany(p => p.PedidoCliente)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .HasConstraintName("FK_pedido");
            });

            modelBuilder.Entity<PessoaJuridica>(entity =>
            {
                entity.HasKey(e => e.ID_pessoa_juridica)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CNPJ, "CNPJ")
                    .IsUnique();

                entity.HasIndex(e => e.Celular, "Celular")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "Email")
                    .IsUnique();

                entity.HasIndex(e => e.Inscricao_estadual, "Inscricao_estadual")
                    .IsUnique();

                entity.HasIndex(e => e.Nome_fantasia, "Nome_fantasia")
                    .IsUnique();

                entity.HasIndex(e => e.Razao_social, "Razao_social")
                    .IsUnique();

                entity.HasIndex(e => e.Telefone, "Telefone")
                    .IsUnique();

                entity.Property(e => e.ID_pessoa_juridica).HasColumnType("int(11)");

                entity.Property(e => e.Area_atuacao).HasMaxLength(30);

                entity.Property(e => e.Bairro).HasMaxLength(40);

                entity.Property(e => e.CEP).HasMaxLength(8);

                entity.Property(e => e.CNPJ).HasMaxLength(14);

                entity.Property(e => e.Celular).HasMaxLength(11);

                entity.Property(e => e.Cidade).HasMaxLength(40);

                entity.Property(e => e.Complemento_endereco).HasMaxLength(40);

                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.Inscricao_estadual).HasMaxLength(9);

                entity.Property(e => e.Logradouro).HasMaxLength(40);

                entity.Property(e => e.Nome_fantasia).HasMaxLength(40);

                entity.Property(e => e.Numero_endereco).HasMaxLength(10);

                entity.Property(e => e.Razao_social).HasMaxLength(70);

                entity.Property(e => e.Telefone).HasMaxLength(10);

                entity.Property(e => e.UF).HasMaxLength(2);
            });

            modelBuilder.Entity<ProcessoManutencao>(entity =>
            {
                entity.HasKey(e => e.ID_processo_manutencao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Descricao, "Descricao")
                    .IsUnique();

                entity.Property(e => e.ID_processo_manutencao).HasColumnType("int(11)");

                entity.Property(e => e.Classificacao).HasMaxLength(9);

                entity.Property(e => e.Corretivo)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Descricao).HasMaxLength(60);

                entity.Property(e => e.Preventivo)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ProcessoPedido>(entity =>
            {
                entity.HasKey(e => e.ID_processo)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_rota, "FK_processo");

                entity.HasIndex(e => e.ID_for_retorno, "FK_processo2");

                entity.HasIndex(e => e.ID_for_veiculo, "FK_processo3");

                entity.HasIndex(e => e.ID_for_motorista, "FK_processo4");

                entity.Property(e => e.ID_processo).HasColumnType("int(11)");

                entity.Property(e => e.Gasto_total_litros).HasColumnType("double(15,3) unsigned");

                entity.Property(e => e.Gasto_total_reais).HasColumnType("double(15,2) unsigned");

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_retorno).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_rota).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_veiculo).HasColumnType("int(11)");

                entity.Property(e => e.KM_total).HasColumnType("double(15,3) unsigned");

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.ProcessoPedido)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .HasConstraintName("FK_processo4");

                entity.HasOne(d => d.ID_for_retornoNavigation)
                    .WithMany(p => p.ProcessoPedido)
                    .HasForeignKey(d => d.ID_for_retorno)
                    .HasConstraintName("FK_processo2");

                entity.HasOne(d => d.ID_for_veiculoNavigation)
                    .WithMany(p => p.ProcessoPedido)
                    .HasForeignKey(d => d.ID_for_veiculo)
                    .HasConstraintName("FK_processo3");
            });

            modelBuilder.Entity<RedeTransporte>(entity =>
            {
                entity.HasKey(e => e.ID_rede)
                    .HasName("PRIMARY");

                entity.Property(e => e.ID_rede).HasColumnType("int(11)");

                entity.Property(e => e.Categoria_CNH)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Descricao).HasMaxLength(30);

                entity.Property(e => e.Tipo_rede).HasMaxLength(50);

                entity.Property(e => e.Tipo_veiculo).HasMaxLength(30);
            });

            modelBuilder.Entity<Rota>(entity =>
            {
                entity.HasKey(e => new { e.ID_rota, e.ID_for_pedido })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasIndex(e => e.ID_for_pedido, "FK_rota");

                entity.Property(e => e.ID_rota)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ID_for_pedido).HasColumnType("int(11)");

                entity.Property(e => e.Bairro_partida).HasMaxLength(40);

                entity.Property(e => e.CEP_partida).HasMaxLength(8);

                entity.Property(e => e.Cidade_partida).HasMaxLength(40);

                entity.Property(e => e.Complemento_partida).HasMaxLength(40);

                entity.Property(e => e.Distancia_KM).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Gasto_combustivel_litros).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Gasto_combustivel_reais).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.Gasto_pedagio_reais).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.Logradouro_partida).HasMaxLength(40);

                entity.Property(e => e.Numero_partida).HasMaxLength(10);

                entity.Property(e => e.UF_partida).HasMaxLength(2);

                entity.HasOne(d => d.ID_for_pedidoNavigation)
                    .WithMany(p => p.Rota)
                    .HasForeignKey(d => d.ID_for_pedido)
                    .HasConstraintName("FK_rota");
            });

            modelBuilder.Entity<RotaRetorno>(entity =>
            {
                entity.HasKey(e => e.ID_retorno)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_rota, "FK_retorno");

                entity.HasIndex(e => e.ID_for_pedido, "FK_retorno2");

                entity.Property(e => e.ID_retorno).HasColumnType("int(11)");

                entity.Property(e => e.Distancia_KM).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Gasto_combustivel_litros).HasColumnType("double(9,3) unsigned");

                entity.Property(e => e.Gasto_combustivel_reais).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.Gasto_pedagio_reais).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.ID_for_pedido).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_rota).HasColumnType("int(11)");

                entity.HasOne(d => d.ID_for_pedidoNavigation)
                    .WithMany(p => p.RotaRetorno)
                    .HasForeignKey(d => d.ID_for_pedido)
                    .HasConstraintName("FK_retorno2");
            });

            modelBuilder.Entity<Sinistro>(entity =>
            {
                entity.HasKey(e => e.ID_Sinistro)
                    .HasName("PRIMARY");

                entity.Property(e => e.ID_Sinistro).HasColumnType("int(11)");

                entity.Property(e => e.Descricao).HasMaxLength(30);

                entity.Property(e => e.Tipo_sinistro).HasMaxLength(30);
            });

            modelBuilder.Entity<TarifasETaxas>(entity =>
            {
                entity.HasKey(e => e.ID_ta)
                    .HasName("PRIMARY");

                entity.Property(e => e.ID_ta).HasColumnType("int(11)");

                entity.Property(e => e.Descricao).HasMaxLength(30);

                entity.Property(e => e.Nome_empresa).HasMaxLength(30);

                entity.Property(e => e.Tarifa_ou_taxa).HasMaxLength(8);
            });

            modelBuilder.Entity<TelefoneCliente>(entity =>
            {
                entity.HasKey(e => e.ID_telefone)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_cliente, "FK_cliente3");

                entity.HasIndex(e => e.Telefone, "Telefone")
                    .IsUnique();

                entity.Property(e => e.ID_telefone).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_cliente).HasColumnType("int(11)");

                entity.Property(e => e.Telefone).HasMaxLength(10);

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithMany(p => p.TelefoneCliente)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .HasConstraintName("FK_cliente3");
            });

            modelBuilder.Entity<TelefoneFuncionario>(entity =>
            {
                entity.HasKey(e => e.ID_telefone)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_funcionario, "FK_funcionario");

                entity.HasIndex(e => e.Telefone, "Telefone")
                    .IsUnique();

                entity.Property(e => e.ID_telefone).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_funcionario).HasColumnType("int(11)");

                entity.Property(e => e.Telefone).HasMaxLength(10);

                entity.HasOne(d => d.ID_for_funcionarioNavigation)
                    .WithMany(p => p.TelefoneFuncionario)
                    .HasForeignKey(d => d.ID_for_funcionario)
                    .HasConstraintName("FK_funcionario");
            });

            modelBuilder.Entity<TelefoneMotoristaTerceiro>(entity =>
            {
                entity.HasKey(e => e.ID_telefone)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_motorista, "FK_terceiro5");

                entity.HasIndex(e => e.Telefone, "Telefone")
                    .IsUnique();

                entity.Property(e => e.ID_telefone).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.Property(e => e.Telefone).HasMaxLength(10);

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.TelefoneMotoristaTerceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .HasConstraintName("FK_terceiro5");
            });

            modelBuilder.Entity<TipoVeiculo>(entity =>
            {
                entity.HasKey(e => e.ID_tipo_veiculo)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Descricao, "Descricao")
                    .IsUnique();

                entity.Property(e => e.ID_tipo_veiculo).HasColumnType("int(11)");

                entity.Property(e => e.Descricao).HasMaxLength(50);

                entity.Property(e => e.Possui_carroceria).HasColumnType("tinyint(3) unsigned");

                entity.HasMany(d => d.ID_for_carroceria)
                    .WithMany(p => p.ID_for_tipo_veiculo)
                    .UsingEntity<Dictionary<string, object>>(
                        "TipoVContemCarroceria",
                        l => l.HasOne<Carroceria>().WithMany().HasForeignKey("ID_for_carroceria").HasConstraintName("FK_carroceria"),
                        r => r.HasOne<TipoVeiculo>().WithMany().HasForeignKey("ID_for_tipo_veiculo").HasConstraintName("FK_tipoVeiculo3"),
                        j =>
                        {
                            j.HasKey("ID_for_tipo_veiculo", "ID_for_carroceria").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("TipoVContemCarroceria");

                            j.HasIndex(new[] { "ID_for_carroceria" }, "FK_carroceria");

                            j.IndexerProperty<int>("ID_for_tipo_veiculo").HasColumnType("int(11)");

                            j.IndexerProperty<int>("ID_for_carroceria").HasColumnType("int(11)");
                        });
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.ID_usuario)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CPF, "CPF")
                    .IsUnique();

                entity.HasIndex(e => e.Celular, "Celular")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "Email")
                    .IsUnique();

                entity.Property(e => e.ID_usuario).HasColumnType("int(11)");

                entity.Property(e => e.CPF).HasMaxLength(11);

                entity.Property(e => e.Celular).HasMaxLength(11);

                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.Nome).HasMaxLength(30);

                entity.Property(e => e.Senha).HasMaxLength(30);
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.HasKey(e => e.ID_veiculo)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Cod_CIOT, "Cod_CIOT")
                    .IsUnique();

                entity.HasIndex(e => e.Cod_RENAVAM, "Cod_RENAVAM")
                    .IsUnique();

                entity.HasIndex(e => e.Cod_RNTRC, "Cod_RNTRC")
                    .IsUnique();

                entity.HasIndex(e => e.ID_for_marca, "FK_marca");

                entity.HasIndex(e => e.ID_for_modelo, "FK_modelo");

                entity.HasIndex(e => e.ID_for_tipo_veiculo, "FK_tipoVeiculo");

                entity.HasIndex(e => e.Placa, "Placa")
                    .IsUnique();

                entity.Property(e => e.ID_veiculo).HasColumnType("int(11)");

                entity.Property(e => e.Ano_fabricacao).HasColumnType("year(4)");

                entity.Property(e => e.Cod_CIOT).HasMaxLength(16);

                entity.Property(e => e.Cod_RENAVAM).HasMaxLength(11);

                entity.Property(e => e.Cod_RNTRC).HasMaxLength(14);

                entity.Property(e => e.Cor).HasMaxLength(15);

                entity.Property(e => e.ID_for_marca).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_modelo).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_tipo_veiculo).HasColumnType("int(11)");

                entity.Property(e => e.Placa).HasMaxLength(7);

                entity.HasOne(d => d.ID_for_marcaNavigation)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => d.ID_for_marca)
                    .HasConstraintName("FK_marca");

                entity.HasOne(d => d.ID_for_modeloNavigation)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => d.ID_for_modelo)
                    .HasConstraintName("FK_modelo");

                entity.HasOne(d => d.ID_for_tipo_veiculoNavigation)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => d.ID_for_tipo_veiculo)
                    .HasConstraintName("FK_tipoVeiculo");

                entity.HasMany(d => d.ID_for_carroceria)
                    .WithMany(p => p.ID_for_veiculo)
                    .UsingEntity<Dictionary<string, object>>(
                        "VeiculoContem",
                        l => l.HasOne<Carroceria>().WithMany().HasForeignKey("ID_for_carroceria").HasConstraintName("FK_carroceria2"),
                        r => r.HasOne<Veiculo>().WithMany().HasForeignKey("ID_for_veiculo").HasConstraintName("FK_veiculo2"),
                        j =>
                        {
                            j.HasKey("ID_for_veiculo", "ID_for_carroceria").HasName("PRIMARY").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                            j.ToTable("VeiculoContem");

                            j.HasIndex(new[] { "ID_for_carroceria" }, "FK_carroceria2");

                            j.IndexerProperty<int>("ID_for_veiculo").HasColumnType("int(11)");

                            j.IndexerProperty<int>("ID_for_carroceria").HasColumnType("int(11)");
                        });
            });

            modelBuilder.Entity<VeiculoTerceiro>(entity =>
            {
                entity.HasKey(e => e.ID_veiculo_terceiro)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.Cod_CIOT, "Cod_CIOT")
                    .IsUnique();

                entity.HasIndex(e => e.Cod_RENAVAM, "Cod_RENAVAM")
                    .IsUnique();

                entity.HasIndex(e => e.Cod_RNTRC, "Cod_RNTRC")
                    .IsUnique();

                entity.HasIndex(e => e.ID_for_motorista, "FK_terceiro2");

                entity.HasIndex(e => e.Placa, "Placa")
                    .IsUnique();

                entity.Property(e => e.ID_veiculo_terceiro).HasColumnType("int(11)");

                entity.Property(e => e.Ano_fabricao).HasColumnType("year(4)");

                entity.Property(e => e.Capacidade_KG).HasColumnType("double(9,3)");

                entity.Property(e => e.Capacidade_volumetrica).HasColumnType("double(9,3)");

                entity.Property(e => e.Carroceria).HasMaxLength(30);

                entity.Property(e => e.Cod_CIOT).HasMaxLength(16);

                entity.Property(e => e.Cod_RENAVAM).HasMaxLength(11);

                entity.Property(e => e.Cod_RNTRC).HasMaxLength(14);

                entity.Property(e => e.Eixo_carroceria).HasColumnType("tinyint(4)");

                entity.Property(e => e.Eixo_modelo).HasColumnType("tinyint(4)");

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.Property(e => e.Marca).HasMaxLength(25);

                entity.Property(e => e.Massa_carroceria).HasColumnType("double(9,3)");

                entity.Property(e => e.Massa_modelo).HasColumnType("double(9,3)");

                entity.Property(e => e.Modelo).HasMaxLength(30);

                entity.Property(e => e.Placa).HasMaxLength(7);

                entity.Property(e => e.Tipo_veiculo).HasMaxLength(50);

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.VeiculoTerceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .HasConstraintName("FK_terceiro2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
