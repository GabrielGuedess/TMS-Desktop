
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Diagnostics;

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

        public virtual DbSet<Carroceria> carroceria { get; set; } = null!;
        public virtual DbSet<Celularcliente> celularcliente { get; set; } = null!;
        public virtual DbSet<Celularfuncionario> Celularfuncionario { get; set; } = null!;
        public virtual DbSet<Celularmotoristaterceiro> Celularmotoristaterceiro { get; set; } = null!;
        public virtual DbSet<Cliente> cliente { get; set; } = null!;
        public virtual DbSet<Clientefisico> Clientefisico { get; set; } = null!;
        public virtual DbSet<Clientejuridico> Clientejuridico { get; set; } = null!;
        public virtual DbSet<Contratomotoristaterceiro> Contratomotoristaterceiro { get; set; } = null!;
        public virtual DbSet<Emailcliente> Emailcliente { get; set; } = null!;
        public virtual DbSet<Emailfuncionario> Emailfuncionario { get; set; } = null!;
        public virtual DbSet<Emailmotoristaterceiro> Emailmotoristaterceiro { get; set; } = null!;
        public virtual DbSet<Marca> Marca { get; set; } = null!;
        public virtual DbSet<Mercadoria> Mercadoria { get; set; } = null!;
        public virtual DbSet<Modelo> Modelo { get; set; } = null!;
        public virtual DbSet<Motorista> Motorista { get; set; } = null!;
        public virtual DbSet<Motoristaterceiro> Motoristaterceiro { get; set; } = null!;
        public virtual DbSet<Notafiscal> Notafiscal { get; set; } = null!;
        public virtual DbSet<Pedidocliente> Pedidocliente { get; set; } = null!;
        public virtual DbSet<Pessoajuridica> Pessoajuridica { get; set; } = null!;
        public virtual DbSet<Processopedido> Processopedido { get; set; } = null!;
        public virtual DbSet<Redetransporte> Redetransporte { get; set; } = null!;
        public virtual DbSet<Rota> Rota { get; set; } = null!;
        public virtual DbSet<Rotaretorno> Rotaretorno { get; set; } = null!;
        public virtual DbSet<Sinistro> Sinistro { get; set; } = null!;
        public virtual DbSet<Tarifasetaxas> Tarifasetaxas { get; set; } = null!;
        public virtual DbSet<Telefonecliente> Telefonecliente { get; set; } = null!;
        public virtual DbSet<Telefonefuncionario> Telefonefuncionario { get; set; } = null!;
        public virtual DbSet<Telefonemotoristaterceiro> Telefonemotoristaterceiro { get; set; } = null!;
        public virtual DbSet<Usuario> Usuario { get; set; } = null!;
        public virtual DbSet<Veiculo> Veiculo { get; set; } = null!;
        public virtual DbSet<Veiculoterceiro> Veiculoterceiro { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(ConfigurationManager.ConnectionStrings["ConnectionStringDBTMS"].ConnectionString, ServerVersion.Parse("10.4.22-mariadb"));
            }
            optionsBuilder.LogTo(message => Debug.WriteLine(message)).EnableSensitiveDataLogging().EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Carroceria>(entity =>
            {
                entity.HasKey(e => e.ID_carroceira)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_modelo, "FK_modelo");

                entity.Property(e => e.ID_carroceira).HasColumnType("int(11)");

                entity.Property(e => e.Capacidade_KG).HasColumnType("double(6,3) unsigned");

                entity.Property(e => e.Capacidade_volumetrica).HasColumnType("double(6,3) unsigned");

                entity.Property(e => e.Descricao_carroceira).HasMaxLength(30);

                entity.Property(e => e.Eixo_carroceria).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ID_for_modelo).HasColumnType("int(11)");

                entity.Property(e => e.Massa_carroceria).HasColumnType("double(6,3) unsigned");

                entity.HasOne(d => d.ID_for_modeloNavigation)
                    .WithMany(p => p.Carroceria)
                    .HasForeignKey(d => d.ID_for_modelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_modelo");
            });

            modelBuilder.Entity<Celularcliente>(entity =>
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
                    .WithMany(p => p.Celularcliente)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente4");
            });

            modelBuilder.Entity<Celularfuncionario>(entity =>
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
                    .WithMany(p => p.Celularfuncionario)
                    .HasForeignKey(d => d.ID_for_funcionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_funcionario2");
            });

            modelBuilder.Entity<Celularmotoristaterceiro>(entity =>
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
                    .WithMany(p => p.Celularmotoristaterceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
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

                entity.Property(e => e.UF).HasMaxLength(2);
            });

            modelBuilder.Entity<Clientefisico>(entity =>
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

                entity.Property(e => e.Genero)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.RG).HasMaxLength(15);

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithOne(p => p.Clientefisico)
                    .HasForeignKey<Clientefisico>(d => d.ID_for_cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente2");
            });

            modelBuilder.Entity<Clientejuridico>(entity =>
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

                entity.Property(e => e.Razao_social).HasMaxLength(40);

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithOne(p => p.clientejuridico)
                    .HasForeignKey<Clientejuridico>(d => d.ID_for_cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente");
            });

            modelBuilder.Entity<Contratomotoristaterceiro>(entity =>
            {
                entity.HasKey(e => e.ID_contrato)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_motorista, "FK_terceiro");

                entity.Property(e => e.ID_contrato).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.Property(e => e.Situacao_contrato).HasMaxLength(20);

                entity.Property(e => e.Tipo_contrato).HasMaxLength(20);

                entity.Property(e => e.Veiculo_proprio).HasMaxLength(3);

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.Contratomotoristaterceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_terceiro");
            });

            modelBuilder.Entity<Emailcliente>(entity =>
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
                    .WithMany(p => p.Emailcliente)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente5");
            });

            modelBuilder.Entity<Emailfuncionario>(entity =>
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
                    .WithMany(p => p.Emailfuncionario)
                    .HasForeignKey(d => d.ID_for_funcionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_funcionario3");
            });

            modelBuilder.Entity<Emailmotoristaterceiro>(entity =>
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
                    .WithMany(p => p.Emailmotoristaterceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_terceiro3");
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

                entity.Property(e => e.Massa).HasColumnType("double(6,3) unsigned");

                entity.Property(e => e.Valor).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.Volume).HasColumnType("double(6,3) unsigned");

                entity.HasOne(d => d.ID_for_clienteNavigation)
                    .WithMany(p => p.Mercadoria)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mercadoria2");

                entity.HasOne(d => d.ID_for_pedidoNavigation)
                    .WithMany(p => p.Mercadoria)
                    .HasForeignKey(d => d.ID_for_pedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mercadoria");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasKey(e => e.ID_modelo)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_marca, "FK_marca2");

                entity.Property(e => e.ID_modelo).HasColumnType("int(11)");

                entity.Property(e => e.Eixo_modelo).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ID_for_marca).HasColumnType("int(11)");

                entity.Property(e => e.Massa_modelo).HasColumnType("double(6,3) unsigned");

                entity.Property(e => e.Nome).HasMaxLength(30);

                entity.HasOne(d => d.ID_for_marcaNavigation)
                    .WithMany(p => p.Modelo)
                    .HasForeignKey(d => d.ID_for_marca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_marca2");
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

                entity.Property(e => e.Disponibilidade)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Genero)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Logradouro).HasMaxLength(40);

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.Numero_CNH).HasMaxLength(11);

                entity.Property(e => e.Numero_endereco).HasMaxLength(10);

                entity.Property(e => e.RG).HasMaxLength(15);

                entity.Property(e => e.UF).HasMaxLength(2);
            });

            modelBuilder.Entity<Motoristaterceiro>(entity =>
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

                entity.Property(e => e.Disponibilidade)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Genero)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Logradouro).HasMaxLength(40);

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.Numero_CNH).HasMaxLength(11);

                entity.Property(e => e.Numero_endereco).HasMaxLength(10);

                entity.Property(e => e.RG).HasMaxLength(15);

                entity.Property(e => e.UF).HasMaxLength(2);
            });

            modelBuilder.Entity<Notafiscal>(entity =>
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

            modelBuilder.Entity<Pedidocliente>(entity =>
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
                    .WithMany(p => p.Pedidocliente)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pedido");
            });

            modelBuilder.Entity<Pessoajuridica>(entity =>
            {
                entity.HasKey(e => e.ID_usuario)
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

                entity.Property(e => e.ID_usuario).HasColumnType("int(11)");

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

                entity.Property(e => e.Razao_social).HasMaxLength(40);

                entity.Property(e => e.Telefone).HasMaxLength(10);

                entity.Property(e => e.UF).HasMaxLength(2);
            });

            modelBuilder.Entity<Processopedido>(entity =>
            {
                entity.HasKey(e => e.ID_processo)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_rota, "FK_processo");

                entity.HasIndex(e => e.ID_for_retorno, "FK_processo2");

                entity.HasIndex(e => e.ID_for_veiculo, "FK_processo3");

                entity.HasIndex(e => e.ID_for_motorista, "FK_processo4");

                entity.Property(e => e.ID_processo).HasColumnType("int(11)");

                entity.Property(e => e.Gasto_total).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_retorno).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_rota).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_veiculo).HasColumnType("int(11)");

                entity.Property(e => e.KM_total).HasColumnType("double(6,3) unsigned");

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.Processopedido)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_processo4");

                entity.HasOne(d => d.ID_for_retornoNavigation)
                    .WithMany(p => p.Processopedido)
                    .HasForeignKey(d => d.ID_for_retorno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_processo2");

                entity.HasOne(d => d.ID_for_veiculoNavigation)
                    .WithMany(p => p.Processopedido)
                    .HasForeignKey(d => d.ID_for_veiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_processo3");
            });

            modelBuilder.Entity<Redetransporte>(entity =>
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

                entity.Property(e => e.Distancia_KM).HasColumnType("double(6,3) unsigned");

                entity.Property(e => e.Gasto_combustivel_reais).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.Gasto_pedagio_reais).HasColumnType("double(6,2) unsigned");

                entity.Property(e => e.Logradouro_partida).HasMaxLength(40);

                entity.Property(e => e.Numero_partida).HasMaxLength(10);

                entity.Property(e => e.UF_partida).HasMaxLength(2);

                entity.HasOne(d => d.ID_for_pedidoNavigation)
                    .WithMany(p => p.Rota)
                    .HasForeignKey(d => d.ID_for_pedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rota");
            });

            modelBuilder.Entity<Rotaretorno>(entity =>
            {
                entity.HasKey(e => e.ID_retorno)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ID_for_rota, "FK_retorno");

                entity.HasIndex(e => e.ID_for_pedido, "FK_retorno2");

                entity.Property(e => e.ID_retorno).HasColumnType("int(11)");

                entity.Property(e => e.Distancia_KM).HasColumnType("double(6,3) unsigned");

                entity.Property(e => e.Gasto_combustivel_reais).HasColumnType("double(9,2) unsigned");

                entity.Property(e => e.Gasto_pedagio_reais).HasColumnType("double(6,2) unsigned");

                entity.Property(e => e.ID_for_pedido).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_rota).HasColumnType("int(11)");

                entity.HasOne(d => d.ID_for_pedidoNavigation)
                    .WithMany(p => p.Rotaretorno)
                    .HasForeignKey(d => d.ID_for_pedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
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

            modelBuilder.Entity<Tarifasetaxas>(entity =>
            {
                entity.HasKey(e => e.ID_ta)
                    .HasName("PRIMARY");

                entity.Property(e => e.ID_ta).HasColumnType("int(11)");

                entity.Property(e => e.Descricao).HasMaxLength(30);

                entity.Property(e => e.Nome_empresa).HasMaxLength(30);

                entity.Property(e => e.Tarifa_ou_taxa).HasMaxLength(8);
            });

            modelBuilder.Entity<Telefonecliente>(entity =>
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
                    .WithMany(p => p.Telefonecliente)
                    .HasForeignKey(d => d.ID_for_cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cliente3");
            });

            modelBuilder.Entity<Telefonefuncionario>(entity =>
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
                    .WithMany(p => p.Telefonefuncionario)
                    .HasForeignKey(d => d.ID_for_funcionario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_funcionario");
            });

            modelBuilder.Entity<Telefonemotoristaterceiro>(entity =>
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
                    .WithMany(p => p.Telefonemotoristaterceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_terceiro5");
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

                entity.HasIndex(e => e.Telefone, "Telefone")
                    .IsUnique();

                entity.HasIndex(e => e.User_name, "User_name")
                    .IsUnique();

                entity.Property(e => e.ID_usuario).HasColumnType("int(11)");

                entity.Property(e => e.CPF).HasMaxLength(11);

                entity.Property(e => e.Celular).HasMaxLength(11);

                entity.Property(e => e.Email).HasMaxLength(35);

                entity.Property(e => e.Nome).HasMaxLength(30);

                entity.Property(e => e.Telefone).HasMaxLength(10);

                entity.Property(e => e.User_name).HasMaxLength(20);
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

                entity.HasIndex(e => e.Placa, "Placa")
                    .IsUnique();

                entity.Property(e => e.ID_veiculo).HasColumnType("int(11)");

                entity.Property(e => e.Ano_fabricacao).HasColumnType("year(4)");

                entity.Property(e => e.Cod_CIOT).HasMaxLength(16);

                entity.Property(e => e.Cod_RENAVAM).HasMaxLength(11);

                entity.Property(e => e.Cod_RNTRC).HasMaxLength(14);

                entity.Property(e => e.Cor).HasMaxLength(15);

                entity.Property(e => e.Disponibilidade)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.ID_for_marca).HasColumnType("int(11)");

                entity.Property(e => e.Placa).HasMaxLength(7);

                entity.HasOne(d => d.ID_for_marcaNavigation)
                    .WithMany(p => p.Veiculo)
                    .HasForeignKey(d => d.ID_for_marca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_marca");
            });

            modelBuilder.Entity<Veiculoterceiro>(entity =>
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

                entity.Property(e => e.Capacidade_KG).HasColumnType("double(6,3)");

                entity.Property(e => e.Capacidade_volumetrican).HasColumnType("double(6,3)");

                entity.Property(e => e.Carroceria).HasMaxLength(30);

                entity.Property(e => e.Cod_CIOT).HasMaxLength(16);

                entity.Property(e => e.Cod_RENAVAM).HasMaxLength(11);

                entity.Property(e => e.Cod_RNTRC).HasMaxLength(14);

                entity.Property(e => e.Eixo_carroceria).HasColumnType("int(11)");

                entity.Property(e => e.Eixo_modelo).HasColumnType("int(11)");

                entity.Property(e => e.ID_for_motorista).HasColumnType("int(11)");

                entity.Property(e => e.Marca).HasMaxLength(25);

                entity.Property(e => e.Massa_carroceria).HasColumnType("double(6,3)");

                entity.Property(e => e.Massa_modelo).HasColumnType("double(6,3)");

                entity.Property(e => e.Modelo).HasMaxLength(30);

                entity.Property(e => e.Placa).HasMaxLength(7);

                entity.HasOne(d => d.ID_for_motoristaNavigation)
                    .WithMany(p => p.Veiculoterceiro)
                    .HasForeignKey(d => d.ID_for_motorista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_terceiro2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
