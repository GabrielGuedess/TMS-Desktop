﻿namespace Interface
{
    partial class CadastroRotas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroRotas));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.SubpanelCPF = new System.Windows.Forms.Panel();
            this.panelTextCPFClient = new Interface.Properties.PanelBorderRounded();
            this.labelCPFClient = new System.Windows.Forms.Label();
            this.panelNomeClient = new System.Windows.Forms.Panel();
            this.subpanelNomeClient = new System.Windows.Forms.Panel();
            this.panelTextNomeClient = new Interface.Properties.PanelBorderRounded();
            this.labelNomeClient = new System.Windows.Forms.Label();
            this.contentUsuario = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBorderRoundedNome = new Interface.Properties.PanelBorderRounded();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBorderRounded2 = new Interface.Properties.PanelBorderRounded();
            this.label1 = new System.Windows.Forms.Label();
            this.contentRotas = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelBorderRounded1 = new Interface.Properties.PanelBorderRounded();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelBorderRounded3 = new Interface.Properties.PanelBorderRounded();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelEmail = new Interface.Properties.PanelBorderRounded();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelDtNascClient = new System.Windows.Forms.Panel();
            this.subpanelDtNascClient = new System.Windows.Forms.Panel();
            this.panelDateTimerClient = new Interface.Properties.PanelBorderRounded();
            this.labelCPF = new System.Windows.Forms.Label();
            this.panelGeneroClient = new System.Windows.Forms.Panel();
            this.subpanelGeneroClient = new System.Windows.Forms.Panel();
            this.panelBorderRoundedCelular = new Interface.Properties.PanelBorderRounded();
            this.labelCelular = new System.Windows.Forms.Label();
            this.panelRGClient = new System.Windows.Forms.Panel();
            this.subpanelRGClient = new System.Windows.Forms.Panel();
            this.panelTextRGClient = new Interface.Properties.PanelBorderRounded();
            this.label7 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.calcularRota = new System.Windows.Forms.Button();
            this.cadastrarRota = new System.Windows.Forms.Button();
            this.cadastrarUsuario = new System.Windows.Forms.Button();
            this.cadastrarCNPJ = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.panel51 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panelSerch = new Interface.Properties.PanelBorderRoundedOnLeft();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.panelMap = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelCPF.SuspendLayout();
            this.SubpanelCPF.SuspendLayout();
            this.panelNomeClient.SuspendLayout();
            this.subpanelNomeClient.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contentRotas.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panelDtNascClient.SuspendLayout();
            this.subpanelDtNascClient.SuspendLayout();
            this.panelGeneroClient.SuspendLayout();
            this.subpanelGeneroClient.SuspendLayout();
            this.panelRGClient.SuspendLayout();
            this.subpanelRGClient.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panel51.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panelSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 2);
            this.map.Margin = new System.Windows.Forms.Padding(0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(975, 402);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.panelCPF, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panelCPF
            // 
            this.panelCPF.BackColor = System.Drawing.Color.Transparent;
            this.panelCPF.Controls.Add(this.SubpanelCPF);
            this.panelCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCPF.Location = new System.Drawing.Point(0, 0);
            this.panelCPF.Margin = new System.Windows.Forms.Padding(0);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelCPF.Size = new System.Drawing.Size(66, 100);
            this.panelCPF.TabIndex = 0;
            // 
            // SubpanelCPF
            // 
            this.SubpanelCPF.BackColor = System.Drawing.Color.Transparent;
            this.SubpanelCPF.Controls.Add(this.panelTextCPFClient);
            this.SubpanelCPF.Controls.Add(this.labelCPFClient);
            this.SubpanelCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubpanelCPF.Location = new System.Drawing.Point(20, 20);
            this.SubpanelCPF.Margin = new System.Windows.Forms.Padding(0);
            this.SubpanelCPF.Name = "SubpanelCPF";
            this.SubpanelCPF.Size = new System.Drawing.Size(26, 70);
            this.SubpanelCPF.TabIndex = 7;
            // 
            // panelTextCPFClient
            // 
            this.panelTextCPFClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTextCPFClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextCPFClient.Location = new System.Drawing.Point(5, 22);
            this.panelTextCPFClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextCPFClient.Name = "panelTextCPFClient";
            this.panelTextCPFClient.Size = new System.Drawing.Size(74, 33);
            this.panelTextCPFClient.TabIndex = 2;
            // 
            // labelCPFClient
            // 
            this.labelCPFClient.AutoSize = true;
            this.labelCPFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCPFClient.ForeColor = System.Drawing.Color.White;
            this.labelCPFClient.Location = new System.Drawing.Point(5, 5);
            this.labelCPFClient.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelCPFClient.Name = "labelCPFClient";
            this.labelCPFClient.Size = new System.Drawing.Size(34, 17);
            this.labelCPFClient.TabIndex = 0;
            this.labelCPFClient.Text = "CPF";
            // 
            // panelNomeClient
            // 
            this.panelNomeClient.BackColor = System.Drawing.Color.Transparent;
            this.panelNomeClient.Controls.Add(this.subpanelNomeClient);
            this.panelNomeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNomeClient.Location = new System.Drawing.Point(66, 0);
            this.panelNomeClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelNomeClient.Name = "panelNomeClient";
            this.panelNomeClient.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelNomeClient.Size = new System.Drawing.Size(66, 100);
            this.panelNomeClient.TabIndex = 1;
            // 
            // subpanelNomeClient
            // 
            this.subpanelNomeClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelNomeClient.Controls.Add(this.panelTextNomeClient);
            this.subpanelNomeClient.Controls.Add(this.labelNomeClient);
            this.subpanelNomeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subpanelNomeClient.Location = new System.Drawing.Point(20, 20);
            this.subpanelNomeClient.Margin = new System.Windows.Forms.Padding(0);
            this.subpanelNomeClient.Name = "subpanelNomeClient";
            this.subpanelNomeClient.Size = new System.Drawing.Size(26, 70);
            this.subpanelNomeClient.TabIndex = 8;
            // 
            // panelTextNomeClient
            // 
            this.panelTextNomeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTextNomeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextNomeClient.Location = new System.Drawing.Point(5, 22);
            this.panelTextNomeClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextNomeClient.Name = "panelTextNomeClient";
            this.panelTextNomeClient.Size = new System.Drawing.Size(74, 33);
            this.panelTextNomeClient.TabIndex = 1;
            // 
            // labelNomeClient
            // 
            this.labelNomeClient.AutoSize = true;
            this.labelNomeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNomeClient.ForeColor = System.Drawing.Color.White;
            this.labelNomeClient.Location = new System.Drawing.Point(5, 5);
            this.labelNomeClient.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelNomeClient.Name = "labelNomeClient";
            this.labelNomeClient.Size = new System.Drawing.Size(45, 17);
            this.labelNomeClient.TabIndex = 0;
            this.labelNomeClient.Text = "Nome";
            // 
            // contentUsuario
            // 
            this.contentUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentUsuario.AutoScroll = true;
            this.contentUsuario.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.contentUsuario.BackColor = System.Drawing.Color.Transparent;
            this.contentUsuario.Location = new System.Drawing.Point(0, 0);
            this.contentUsuario.Name = "contentUsuario";
            this.contentUsuario.Size = new System.Drawing.Size(200, 100);
            this.contentUsuario.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel3.Size = new System.Drawing.Size(66, 100);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panelBorderRoundedNome);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 70);
            this.panel4.TabIndex = 8;
            // 
            // panelBorderRoundedNome
            // 
            this.panelBorderRoundedNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRoundedNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRoundedNome.Location = new System.Drawing.Point(5, 22);
            this.panelBorderRoundedNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRoundedNome.Name = "panelBorderRoundedNome";
            this.panelBorderRoundedNome.Size = new System.Drawing.Size(74, 33);
            this.panelBorderRoundedNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel1.Size = new System.Drawing.Size(66, 100);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panelBorderRounded2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 70);
            this.panel2.TabIndex = 8;
            // 
            // panelBorderRounded2
            // 
            this.panelBorderRounded2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRounded2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRounded2.Location = new System.Drawing.Point(5, 21);
            this.panelBorderRounded2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRounded2.Name = "panelBorderRounded2";
            this.panelBorderRounded2.Size = new System.Drawing.Size(73, 33);
            this.panelBorderRounded2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha";
            // 
            // contentRotas
            // 
            this.contentRotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentRotas.AutoScroll = true;
            this.contentRotas.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.contentRotas.BackColor = System.Drawing.Color.Transparent;
            this.contentRotas.Controls.Add(this.tableLayoutPanel2);
            this.contentRotas.Controls.Add(this.panelButton);
            this.contentRotas.Location = new System.Drawing.Point(0, 562);
            this.contentRotas.Margin = new System.Windows.Forms.Padding(0);
            this.contentRotas.Name = "contentRotas";
            this.contentRotas.Padding = new System.Windows.Forms.Padding(40);
            this.contentRotas.Size = new System.Drawing.Size(975, 426);
            this.contentRotas.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelDtNascClient, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelGeneroClient, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelRGClient, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(40, 40);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(895, 200);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel6.Size = new System.Drawing.Size(298, 100);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.panelBorderRounded1);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(20, 20);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 70);
            this.panel7.TabIndex = 8;
            // 
            // panelBorderRounded1
            // 
            this.panelBorderRounded1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRounded1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRounded1.Location = new System.Drawing.Point(5, 37);
            this.panelBorderRounded1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRounded1.Name = "panelBorderRounded1";
            this.panelBorderRounded1.Size = new System.Drawing.Size(248, 33);
            this.panelBorderRounded1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(298, 100);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel8.Size = new System.Drawing.Size(298, 100);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.panelBorderRounded3);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(20, 20);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(258, 70);
            this.panel9.TabIndex = 8;
            // 
            // panelBorderRounded3
            // 
            this.panelBorderRounded3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRounded3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRounded3.Location = new System.Drawing.Point(5, 37);
            this.panelBorderRounded3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRounded3.Name = "panelBorderRounded3";
            this.panelBorderRounded3.Size = new System.Drawing.Size(248, 33);
            this.panelBorderRounded3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Senha";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(298, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel10.Size = new System.Drawing.Size(298, 100);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.panelEmail);
            this.panel11.Controls.Add(this.labelEmail);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(20, 20);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(258, 70);
            this.panel11.TabIndex = 8;
            // 
            // panelEmail
            // 
            this.panelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelEmail.Location = new System.Drawing.Point(5, 37);
            this.panelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(248, 33);
            this.panelEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(5, 5);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // panelDtNascClient
            // 
            this.panelDtNascClient.Controls.Add(this.subpanelDtNascClient);
            this.panelDtNascClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDtNascClient.Location = new System.Drawing.Point(596, 0);
            this.panelDtNascClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelDtNascClient.Name = "panelDtNascClient";
            this.panelDtNascClient.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelDtNascClient.Size = new System.Drawing.Size(299, 100);
            this.panelDtNascClient.TabIndex = 2;
            // 
            // subpanelDtNascClient
            // 
            this.subpanelDtNascClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelDtNascClient.Controls.Add(this.panelDateTimerClient);
            this.subpanelDtNascClient.Controls.Add(this.labelCPF);
            this.subpanelDtNascClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subpanelDtNascClient.Location = new System.Drawing.Point(20, 20);
            this.subpanelDtNascClient.Margin = new System.Windows.Forms.Padding(0);
            this.subpanelDtNascClient.Name = "subpanelDtNascClient";
            this.subpanelDtNascClient.Size = new System.Drawing.Size(259, 70);
            this.subpanelDtNascClient.TabIndex = 9;
            // 
            // panelDateTimerClient
            // 
            this.panelDateTimerClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDateTimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelDateTimerClient.Location = new System.Drawing.Point(5, 37);
            this.panelDateTimerClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelDateTimerClient.Name = "panelDateTimerClient";
            this.panelDateTimerClient.Size = new System.Drawing.Size(249, 33);
            this.panelDateTimerClient.TabIndex = 2;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCPF.ForeColor = System.Drawing.Color.White;
            this.labelCPF.Location = new System.Drawing.Point(5, 5);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(34, 17);
            this.labelCPF.TabIndex = 0;
            this.labelCPF.Text = "CPF";
            // 
            // panelGeneroClient
            // 
            this.panelGeneroClient.Controls.Add(this.subpanelGeneroClient);
            this.panelGeneroClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneroClient.Location = new System.Drawing.Point(0, 100);
            this.panelGeneroClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelGeneroClient.Name = "panelGeneroClient";
            this.panelGeneroClient.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelGeneroClient.Size = new System.Drawing.Size(298, 100);
            this.panelGeneroClient.TabIndex = 3;
            // 
            // subpanelGeneroClient
            // 
            this.subpanelGeneroClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelGeneroClient.Controls.Add(this.panelBorderRoundedCelular);
            this.subpanelGeneroClient.Controls.Add(this.labelCelular);
            this.subpanelGeneroClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subpanelGeneroClient.Location = new System.Drawing.Point(20, 20);
            this.subpanelGeneroClient.Margin = new System.Windows.Forms.Padding(0);
            this.subpanelGeneroClient.Name = "subpanelGeneroClient";
            this.subpanelGeneroClient.Size = new System.Drawing.Size(258, 70);
            this.subpanelGeneroClient.TabIndex = 9;
            // 
            // panelBorderRoundedCelular
            // 
            this.panelBorderRoundedCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRoundedCelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRoundedCelular.Location = new System.Drawing.Point(5, 37);
            this.panelBorderRoundedCelular.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRoundedCelular.Name = "panelBorderRoundedCelular";
            this.panelBorderRoundedCelular.Size = new System.Drawing.Size(248, 33);
            this.panelBorderRoundedCelular.TabIndex = 2;
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCelular.ForeColor = System.Drawing.Color.White;
            this.labelCelular.Location = new System.Drawing.Point(5, 5);
            this.labelCelular.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(52, 17);
            this.labelCelular.TabIndex = 0;
            this.labelCelular.Text = "Celular";
            // 
            // panelRGClient
            // 
            this.panelRGClient.Controls.Add(this.subpanelRGClient);
            this.panelRGClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRGClient.Location = new System.Drawing.Point(596, 100);
            this.panelRGClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelRGClient.Name = "panelRGClient";
            this.panelRGClient.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelRGClient.Size = new System.Drawing.Size(299, 100);
            this.panelRGClient.TabIndex = 4;
            // 
            // subpanelRGClient
            // 
            this.subpanelRGClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelRGClient.Controls.Add(this.panelTextRGClient);
            this.subpanelRGClient.Controls.Add(this.label7);
            this.subpanelRGClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subpanelRGClient.Location = new System.Drawing.Point(20, 20);
            this.subpanelRGClient.Margin = new System.Windows.Forms.Padding(0);
            this.subpanelRGClient.Name = "subpanelRGClient";
            this.subpanelRGClient.Size = new System.Drawing.Size(259, 70);
            this.subpanelRGClient.TabIndex = 8;
            // 
            // panelTextRGClient
            // 
            this.panelTextRGClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTextRGClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextRGClient.Location = new System.Drawing.Point(5, 37);
            this.panelTextRGClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextRGClient.Name = "panelTextRGClient";
            this.panelTextRGClient.Size = new System.Drawing.Size(249, 33);
            this.panelTextRGClient.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Confirmar Senha";
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.calcularRota);
            this.panelButton.Controls.Add(this.cadastrarRota);
            this.panelButton.Controls.Add(this.cadastrarUsuario);
            this.panelButton.Controls.Add(this.cadastrarCNPJ);
            this.panelButton.Controls.Add(this.cadastrar);
            this.panelButton.Controls.Add(this.panel51);
            this.panelButton.Location = new System.Drawing.Point(0, 340);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.panelButton.Size = new System.Drawing.Size(975, 50);
            this.panelButton.TabIndex = 7;
            // 
            // calcularRota
            // 
            this.calcularRota.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.calcularRota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.calcularRota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcularRota.FlatAppearance.BorderSize = 0;
            this.calcularRota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcularRota.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.calcularRota.ForeColor = System.Drawing.Color.White;
            this.calcularRota.Location = new System.Drawing.Point(535, 0);
            this.calcularRota.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.calcularRota.Name = "calcularRota";
            this.calcularRota.Size = new System.Drawing.Size(180, 50);
            this.calcularRota.TabIndex = 15;
            this.calcularRota.Text = "Calcular Rota";
            this.calcularRota.UseVisualStyleBackColor = false;
            this.calcularRota.Paint += new System.Windows.Forms.PaintEventHandler(this.calcularRota_Paint);
            // 
            // cadastrarRota
            // 
            this.cadastrarRota.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cadastrarRota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.cadastrarRota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarRota.FlatAppearance.BorderSize = 0;
            this.cadastrarRota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarRota.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cadastrarRota.ForeColor = System.Drawing.Color.White;
            this.cadastrarRota.Location = new System.Drawing.Point(755, 0);
            this.cadastrarRota.Margin = new System.Windows.Forms.Padding(0);
            this.cadastrarRota.Name = "cadastrarRota";
            this.cadastrarRota.Size = new System.Drawing.Size(180, 50);
            this.cadastrarRota.TabIndex = 14;
            this.cadastrarRota.Text = "Cadastrar";
            this.cadastrarRota.UseVisualStyleBackColor = false;
            this.cadastrarRota.Paint += new System.Windows.Forms.PaintEventHandler(this.cadastrarRota_Paint);
            // 
            // cadastrarUsuario
            // 
            this.cadastrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cadastrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.cadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarUsuario.FlatAppearance.BorderSize = 0;
            this.cadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarUsuario.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.cadastrarUsuario.Location = new System.Drawing.Point(1490, -25);
            this.cadastrarUsuario.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.cadastrarUsuario.Name = "cadastrarUsuario";
            this.cadastrarUsuario.Size = new System.Drawing.Size(180, 50);
            this.cadastrarUsuario.TabIndex = 13;
            this.cadastrarUsuario.Text = "Cadastrar";
            this.cadastrarUsuario.UseVisualStyleBackColor = false;
            // 
            // cadastrarCNPJ
            // 
            this.cadastrarCNPJ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cadastrarCNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.cadastrarCNPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarCNPJ.FlatAppearance.BorderSize = 0;
            this.cadastrarCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarCNPJ.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cadastrarCNPJ.ForeColor = System.Drawing.Color.White;
            this.cadastrarCNPJ.Location = new System.Drawing.Point(2242, -50);
            this.cadastrarCNPJ.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.cadastrarCNPJ.Name = "cadastrarCNPJ";
            this.cadastrarCNPJ.Size = new System.Drawing.Size(180, 50);
            this.cadastrarCNPJ.TabIndex = 12;
            this.cadastrarCNPJ.Text = "Cadastrar";
            this.cadastrarCNPJ.UseVisualStyleBackColor = false;
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrar.FlatAppearance.BorderSize = 0;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cadastrar.ForeColor = System.Drawing.Color.White;
            this.cadastrar.Location = new System.Drawing.Point(2977, -75);
            this.cadastrar.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(180, 50);
            this.cadastrar.TabIndex = 11;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            // 
            // panel51
            // 
            this.panel51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel51.Controls.Add(this.button10);
            this.panel51.Location = new System.Drawing.Point(9489, 0);
            this.panel51.Margin = new System.Windows.Forms.Padding(0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(200, 0);
            this.panel51.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 0);
            this.button10.TabIndex = 1;
            this.button10.Text = "Salvar";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel.Controls.Add(this.panelSerch);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.searchPanel.Size = new System.Drawing.Size(975, 62);
            this.searchPanel.TabIndex = 14;
            // 
            // panelSerch
            // 
            this.panelSerch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Controls.Add(this.textSearch);
            this.panelSerch.Location = new System.Drawing.Point(323, 13);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(347, 36);
            this.panelSerch.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textSearch.ForeColor = System.Drawing.Color.White;
            this.textSearch.Location = new System.Drawing.Point(35, 8);
            this.textSearch.Margin = new System.Windows.Forms.Padding(10, 8, 10, 0);
            this.textSearch.Name = "textSearch";
            this.textSearch.PlaceholderText = "Search";
            this.textSearch.Size = new System.Drawing.Size(302, 19);
            this.textSearch.TabIndex = 6;
            // 
            // panelMap
            // 
            this.panelMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMap.BackColor = System.Drawing.Color.RosyBrown;
            this.panelMap.Controls.Add(this.map);
            this.panelMap.Location = new System.Drawing.Point(0, 62);
            this.panelMap.Margin = new System.Windows.Forms.Padding(0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(975, 500);
            this.panelMap.TabIndex = 15;
            // 
            // Rotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.contentRotas);
            this.Controls.Add(this.searchPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Rotas";
            this.Size = new System.Drawing.Size(975, 1032);
            this.Load += new System.EventHandler(this.Rotas_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelCPF.ResumeLayout(false);
            this.SubpanelCPF.ResumeLayout(false);
            this.SubpanelCPF.PerformLayout();
            this.panelNomeClient.ResumeLayout(false);
            this.subpanelNomeClient.ResumeLayout(false);
            this.subpanelNomeClient.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contentRotas.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panelDtNascClient.ResumeLayout(false);
            this.subpanelDtNascClient.ResumeLayout(false);
            this.subpanelDtNascClient.PerformLayout();
            this.panelGeneroClient.ResumeLayout(false);
            this.subpanelGeneroClient.ResumeLayout(false);
            this.subpanelGeneroClient.PerformLayout();
            this.panelRGClient.ResumeLayout(false);
            this.subpanelRGClient.ResumeLayout(false);
            this.subpanelRGClient.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panelCPF;
        private Panel SubpanelCPF;
        private Properties.PanelBorderRounded panelTextCPFClient;
        private Label labelCPFClient;
        private Panel panelNomeClient;
        private Panel subpanelNomeClient;
        private Properties.PanelBorderRounded panelTextNomeClient;
        private Label labelNomeClient;
        private Panel contentUsuario;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Properties.PanelBorderRounded panelBorderRoundedNome;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Properties.PanelBorderRounded panelBorderRounded2;
        private Label label1;
        private Panel contentRotas;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Panel panel7;
        private Properties.PanelBorderRounded panelBorderRounded1;
        private Label label3;
        private Panel panel8;
        private Panel panel9;
        private Properties.PanelBorderRounded panelBorderRounded3;
        private Label label4;
        private Panel panel10;
        private Panel panel11;
        private Properties.PanelBorderRounded panelEmail;
        private Label labelEmail;
        private Panel panelDtNascClient;
        private Panel subpanelDtNascClient;
        private Properties.PanelBorderRounded panelDateTimerClient;
        private Label labelCPF;
        private Panel panelGeneroClient;
        private Panel subpanelGeneroClient;
        private Properties.PanelBorderRounded panelBorderRoundedCelular;
        private Label labelCelular;
        private Panel panelRGClient;
        private Panel subpanelRGClient;
        private Properties.PanelBorderRounded panelTextRGClient;
        private Label label7;
        private Panel panelButton;
        private Button cadastrarUsuario;
        private Button cadastrarCNPJ;
        private Button cadastrar;
        private Panel panel51;
        private Button button10;
        private Panel searchPanel;
        private Properties.PanelBorderRoundedOnLeft panelSerch;
        private PictureBox pictureBox3;
        private TextBox textSearch;
        private Button cadastrarRota;
        private Button calcularRota;
        private Panel panelMap;
    }
}
