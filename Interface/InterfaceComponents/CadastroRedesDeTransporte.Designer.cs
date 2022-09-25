namespace Interface
{
    partial class CadastroRedesDeTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroRedesDeTransporte));
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panelSerch = new Interface.TemplateComponents.PanelBorderRoundedOnLeft();
            this.typeData = new System.Windows.Forms.Label();
            this.maskRedeID = new Interface.TemplateComponents.TextBoxOnlyNum_Letters();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contentRedes = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.comboCategoriaCNH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.comboTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBorderRoundedID = new Interface.TemplateComponents.PanelBorderRounded();
            this.numID = new Interface.TemplateComponents.TextBoxOnlyNum_Letters();
            this.labelId = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelBorderRounded3 = new Interface.TemplateComponents.PanelBorderRounded();
            this.tbTipoRede = new Interface.TemplateComponents.TextBoxOnlyNum_Letters();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelBorderRounded4 = new Interface.TemplateComponents.PanelBorderRounded();
            this.tbDescricaoRede = new Interface.TemplateComponents.TextBoxOnlyNum_Letters();
            this.label3 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buscarNumId = new System.Windows.Forms.Button();
            this.cadastrarRede = new System.Windows.Forms.Button();
            this.panel51 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.searchPanel.SuspendLayout();
            this.panelSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contentRedes.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelBorderRoundedID.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelBorderRounded3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelBorderRounded4.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panel51.SuspendLayout();
            this.SuspendLayout();
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
            this.searchPanel.TabIndex = 13;
            // 
            // panelSerch
            // 
            this.panelSerch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.typeData);
            this.panelSerch.Controls.Add(this.maskRedeID);
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Location = new System.Drawing.Point(314, 13);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(347, 36);
            this.panelSerch.TabIndex = 2;
            this.panelSerch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSerch_Paint);
            // 
            // typeData
            // 
            this.typeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeData.AutoSize = true;
            this.typeData.BackColor = System.Drawing.Color.Transparent;
            this.typeData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.typeData.Location = new System.Drawing.Point(35, 7);
            this.typeData.Margin = new System.Windows.Forms.Padding(10, 7, 0, 6);
            this.typeData.Name = "typeData";
            this.typeData.Size = new System.Drawing.Size(67, 21);
            this.typeData.TabIndex = 4;
            this.typeData.Text = "ID_Rede";
            this.typeData.Click += new System.EventHandler(this.typeData_Click);
            // 
            // maskRedeID
            // 
            this.maskRedeID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskRedeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.maskRedeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskRedeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskRedeID.ForeColor = System.Drawing.Color.White;
            this.maskRedeID.Location = new System.Drawing.Point(112, 7);
            this.maskRedeID.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.maskRedeID.Name = "maskRedeID";
            this.maskRedeID.Size = new System.Drawing.Size(225, 22);
            this.maskRedeID.TabIndex = 2;
            this.maskRedeID.TextChanged += new System.EventHandler(this.numId_TextChanged);
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
            // contentRedes
            // 
            this.contentRedes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentRedes.AutoScroll = true;
            this.contentRedes.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.contentRedes.BackColor = System.Drawing.Color.Transparent;
            this.contentRedes.Controls.Add(this.label18);
            this.contentRedes.Controls.Add(this.label5);
            this.contentRedes.Controls.Add(this.tableLayoutPanel2);
            this.contentRedes.Controls.Add(this.tableLayoutPanel1);
            this.contentRedes.Controls.Add(this.panelButton);
            this.contentRedes.Location = new System.Drawing.Point(0, 62);
            this.contentRedes.Margin = new System.Windows.Forms.Padding(0);
            this.contentRedes.Name = "contentRedes";
            this.contentRedes.Padding = new System.Windows.Forms.Padding(40);
            this.contentRedes.Size = new System.Drawing.Size(975, 526);
            this.contentRedes.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(40, 40);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 17);
            this.label18.TabIndex = 16;
            this.label18.Text = "Informações da Rede";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Informações do Motorista";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.panel25, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel27, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(40, 234);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(895, 100);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.Transparent;
            this.panel25.Controls.Add(this.panel26);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(0, 0);
            this.panel25.Margin = new System.Windows.Forms.Padding(0);
            this.panel25.Name = "panel25";
            this.panel25.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel25.Size = new System.Drawing.Size(298, 100);
            this.panel25.TabIndex = 0;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.Transparent;
            this.panel26.Controls.Add(this.comboCategoriaCNH);
            this.panel26.Controls.Add(this.label7);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(20, 20);
            this.panel26.Margin = new System.Windows.Forms.Padding(0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(258, 70);
            this.panel26.TabIndex = 7;
            // 
            // comboCategoriaCNH
            // 
            this.comboCategoriaCNH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCategoriaCNH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.comboCategoriaCNH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoriaCNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboCategoriaCNH.ForeColor = System.Drawing.SystemColors.Window;
            this.comboCategoriaCNH.FormattingEnabled = true;
            this.comboCategoriaCNH.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "A/B",
            "A/C",
            "A/D",
            "A/E"});
            this.comboCategoriaCNH.Location = new System.Drawing.Point(5, 37);
            this.comboCategoriaCNH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comboCategoriaCNH.Name = "comboCategoriaCNH";
            this.comboCategoriaCNH.Size = new System.Drawing.Size(248, 29);
            this.comboCategoriaCNH.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Categoria da CNH";
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.Transparent;
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(298, 0);
            this.panel27.Margin = new System.Windows.Forms.Padding(0);
            this.panel27.Name = "panel27";
            this.panel27.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel27.Size = new System.Drawing.Size(298, 100);
            this.panel27.TabIndex = 1;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.Transparent;
            this.panel28.Controls.Add(this.comboTipoVeiculo);
            this.panel28.Controls.Add(this.label10);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(20, 20);
            this.panel28.Margin = new System.Windows.Forms.Padding(0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(258, 70);
            this.panel28.TabIndex = 8;
            // 
            // comboTipoVeiculo
            // 
            this.comboTipoVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTipoVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.comboTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoVeiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboTipoVeiculo.ForeColor = System.Drawing.Color.White;
            this.comboTipoVeiculo.FormattingEnabled = true;
            this.comboTipoVeiculo.Items.AddRange(new object[] {
            "Moto",
            "Vans (VUC)",
            "Furgões",
            "Caminhão Toco",
            "Toco/Caminhão Semipesado",
            "Truck/Caminhão Pesado",
            "Bi-truck",
            "Caminhão Trator",
            "Carreta com dois eixos",
            "Carreta com três eixos",
            "Bitrem Articulado",
            "Rodotrem",
            "Outros"});
            this.comboTipoVeiculo.Location = new System.Drawing.Point(5, 37);
            this.comboTipoVeiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comboTipoVeiculo.Name = "comboTipoVeiculo";
            this.comboTipoVeiculo.Size = new System.Drawing.Size(248, 29);
            this.comboTipoVeiculo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tipo de Veiculo";
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
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 72);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 100);
            this.tableLayoutPanel1.TabIndex = 14;
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
            this.panel3.Size = new System.Drawing.Size(298, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panelBorderRoundedID);
            this.panel4.Controls.Add(this.labelId);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(20, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 70);
            this.panel4.TabIndex = 7;
            // 
            // panelBorderRoundedID
            // 
            this.panelBorderRoundedID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRoundedID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRoundedID.Controls.Add(this.numID);
            this.panelBorderRoundedID.Location = new System.Drawing.Point(5, 37);
            this.panelBorderRoundedID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRoundedID.Name = "panelBorderRoundedID";
            this.panelBorderRoundedID.Size = new System.Drawing.Size(248, 33);
            this.panelBorderRoundedID.TabIndex = 2;
            // 
            // numID
            // 
            this.numID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.numID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numID.Cursor = System.Windows.Forms.Cursors.No;
            this.numID.Enabled = false;
            this.numID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numID.ForeColor = System.Drawing.Color.White;
            this.numID.Location = new System.Drawing.Point(7, 5);
            this.numID.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(231, 22);
            this.numID.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(5, 5);
            this.labelId.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(54, 17);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Num ID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(298, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel5.Size = new System.Drawing.Size(298, 100);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panelBorderRounded3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(20, 20);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 70);
            this.panel6.TabIndex = 8;
            // 
            // panelBorderRounded3
            // 
            this.panelBorderRounded3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRounded3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRounded3.Controls.Add(this.tbTipoRede);
            this.panelBorderRounded3.Location = new System.Drawing.Point(5, 37);
            this.panelBorderRounded3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRounded3.Name = "panelBorderRounded3";
            this.panelBorderRounded3.Size = new System.Drawing.Size(248, 33);
            this.panelBorderRounded3.TabIndex = 1;
            // 
            // tbTipoRede
            // 
            this.tbTipoRede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTipoRede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.tbTipoRede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTipoRede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTipoRede.ForeColor = System.Drawing.Color.White;
            this.tbTipoRede.Location = new System.Drawing.Point(6, 5);
            this.tbTipoRede.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.tbTipoRede.Name = "tbTipoRede";
            this.tbTipoRede.Size = new System.Drawing.Size(232, 22);
            this.tbTipoRede.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de Rede";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(596, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel7.Size = new System.Drawing.Size(299, 100);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.panelBorderRounded4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(20, 20);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(259, 70);
            this.panel8.TabIndex = 9;
            // 
            // panelBorderRounded4
            // 
            this.panelBorderRounded4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBorderRounded4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelBorderRounded4.Controls.Add(this.tbDescricaoRede);
            this.panelBorderRounded4.Location = new System.Drawing.Point(5, 37);
            this.panelBorderRounded4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelBorderRounded4.Name = "panelBorderRounded4";
            this.panelBorderRounded4.Size = new System.Drawing.Size(249, 33);
            this.panelBorderRounded4.TabIndex = 2;
            // 
            // tbDescricaoRede
            // 
            this.tbDescricaoRede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescricaoRede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.tbDescricaoRede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescricaoRede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescricaoRede.ForeColor = System.Drawing.Color.White;
            this.tbDescricaoRede.Location = new System.Drawing.Point(7, 5);
            this.tbDescricaoRede.Margin = new System.Windows.Forms.Padding(10, 6, 10, 5);
            this.tbDescricaoRede.Name = "tbDescricaoRede";
            this.tbDescricaoRede.Size = new System.Drawing.Size(232, 22);
            this.tbDescricaoRede.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descrição da Rede";
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.buscarNumId);
            this.panelButton.Controls.Add(this.cadastrarRede);
            this.panelButton.Controls.Add(this.panel51);
            this.panelButton.Location = new System.Drawing.Point(0, 391);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.panelButton.Size = new System.Drawing.Size(975, 50);
            this.panelButton.TabIndex = 7;
            // 
            // buscarNumId
            // 
            this.buscarNumId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buscarNumId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.buscarNumId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarNumId.FlatAppearance.BorderSize = 0;
            this.buscarNumId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarNumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.buscarNumId.ForeColor = System.Drawing.Color.White;
            this.buscarNumId.Location = new System.Drawing.Point(535, 0);
            this.buscarNumId.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.buscarNumId.Name = "buscarNumId";
            this.buscarNumId.Size = new System.Drawing.Size(180, 50);
            this.buscarNumId.TabIndex = 15;
            this.buscarNumId.Text = "Buscar Rede ID";
            this.buscarNumId.UseVisualStyleBackColor = false;
            this.buscarNumId.Visible = false;
            this.buscarNumId.Click += new System.EventHandler(this.buscarNumId_Click);
            this.buscarNumId.Paint += new System.Windows.Forms.PaintEventHandler(this.buscarNumId_Paint);
            // 
            // cadastrarRede
            // 
            this.cadastrarRede.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cadastrarRede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.cadastrarRede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarRede.FlatAppearance.BorderSize = 0;
            this.cadastrarRede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarRede.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cadastrarRede.ForeColor = System.Drawing.Color.White;
            this.cadastrarRede.Location = new System.Drawing.Point(755, 0);
            this.cadastrarRede.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.cadastrarRede.Name = "cadastrarRede";
            this.cadastrarRede.Size = new System.Drawing.Size(180, 50);
            this.cadastrarRede.TabIndex = 14;
            this.cadastrarRede.Text = "Cadastrar";
            this.cadastrarRede.UseVisualStyleBackColor = false;
            this.cadastrarRede.Click += new System.EventHandler(this.cadastrarRede_Click);
            this.cadastrarRede.Paint += new System.Windows.Forms.PaintEventHandler(this.cadastrarRede_Paint);
            // 
            // panel51
            // 
            this.panel51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel51.Controls.Add(this.button10);
            this.panel51.Location = new System.Drawing.Point(9486, 0);
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
            // CadastroRedesDeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.contentRedes);
            this.Controls.Add(this.searchPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CadastroRedesDeTransporte";
            this.Size = new System.Drawing.Size(975, 514);
            this.Resize += new System.EventHandler(this.CadastroRedesDeTransporte_Resize);
            this.searchPanel.ResumeLayout(false);
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contentRedes.ResumeLayout(false);
            this.contentRedes.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelBorderRoundedID.ResumeLayout(false);
            this.panelBorderRoundedID.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelBorderRounded3.ResumeLayout(false);
            this.panelBorderRounded3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelBorderRounded4.ResumeLayout(false);
            this.panelBorderRounded4.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel searchPanel;
        private TemplateComponents.PanelBorderRoundedOnLeft panelSerch;
        private PictureBox pictureBox3;
        private Panel contentRedes;
        private Label label18;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel25;
        private Panel panel26;
        private Label label7;
        private Panel panel27;
        private Panel panel28;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private TemplateComponents.PanelBorderRounded panelBorderRoundedID;
        private Label labelId;
        private Panel panel5;
        private Panel panel6;
        private TemplateComponents.PanelBorderRounded panelBorderRounded3;
        private Label label2;
        private Panel panel7;
        private Panel panel8;
        private TemplateComponents.PanelBorderRounded panelBorderRounded4;
        private Label label3;
        private Panel panelButton;
        private Panel panel51;
        private Button button10;
        private Button cadastrarRede;
        private TemplateComponents.TextBoxOnlyNum_Letters numID;
        private TemplateComponents.TextBoxOnlyNum_Letters tbTipoRede;
        private TemplateComponents.TextBoxOnlyNum_Letters tbDescricaoRede;
        private ComboBox comboCategoriaCNH;
        private ComboBox comboTipoVeiculo;
        private TemplateComponents.TextBoxOnlyNum_Letters maskRedeID;
        private Label typeData;
        private Button buscarNumId;
    }
}
