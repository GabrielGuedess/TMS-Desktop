﻿namespace Interface
{
    partial class CadastroSinistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroSinistros));
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panelSerch = new Interface.Properties.PanelBorderRoundedOnLeft();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.contentSinistros = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.SubpanelCPF = new System.Windows.Forms.Panel();
            this.panelSinistro = new Interface.Properties.PanelBorderRounded();
            this.labelCPFClient = new System.Windows.Forms.Label();
            this.panelNomeClient = new System.Windows.Forms.Panel();
            this.subpanelNomeClient = new System.Windows.Forms.Panel();
            this.panelTextNomeClient = new Interface.Properties.PanelBorderRounded();
            this.labelNomeClient = new System.Windows.Forms.Label();
            this.panelDtNascClient = new System.Windows.Forms.Panel();
            this.subpanelDtNascClient = new System.Windows.Forms.Panel();
            this.panelDateTimerClient = new Interface.Properties.PanelBorderRounded();
            this.label5 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.cadastrarSinistro = new System.Windows.Forms.Button();
            this.panel51 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.searchPanel.SuspendLayout();
            this.panelSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contentSinistros.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelCPF.SuspendLayout();
            this.SubpanelCPF.SuspendLayout();
            this.panelNomeClient.SuspendLayout();
            this.subpanelNomeClient.SuspendLayout();
            this.panelDtNascClient.SuspendLayout();
            this.subpanelDtNascClient.SuspendLayout();
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
            this.searchPanel.TabIndex = 14;
            // 
            // panelSerch
            // 
            this.panelSerch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Controls.Add(this.textSearch);
            this.panelSerch.Location = new System.Drawing.Point(311, 13);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(347, 36);
            this.panelSerch.TabIndex = 2;
            this.panelSerch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSerch_Paint);
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
            // contentSinistros
            // 
            this.contentSinistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentSinistros.AutoScroll = true;
            this.contentSinistros.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.contentSinistros.BackColor = System.Drawing.Color.Transparent;
            this.contentSinistros.Controls.Add(this.tableLayoutPanel3);
            this.contentSinistros.Controls.Add(this.panelButton);
            this.contentSinistros.Location = new System.Drawing.Point(0, 62);
            this.contentSinistros.Margin = new System.Windows.Forms.Padding(0);
            this.contentSinistros.Name = "contentSinistros";
            this.contentSinistros.Padding = new System.Windows.Forms.Padding(40);
            this.contentSinistros.Size = new System.Drawing.Size(975, 312);
            this.contentSinistros.TabIndex = 15;
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
            this.tableLayoutPanel3.Controls.Add(this.panelNomeClient, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelDtNascClient, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(40, 40);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(895, 100);
            this.tableLayoutPanel3.TabIndex = 12;
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
            this.panelCPF.Size = new System.Drawing.Size(298, 100);
            this.panelCPF.TabIndex = 0;
            // 
            // SubpanelCPF
            // 
            this.SubpanelCPF.BackColor = System.Drawing.Color.Transparent;
            this.SubpanelCPF.Controls.Add(this.panelSinistro);
            this.SubpanelCPF.Controls.Add(this.labelCPFClient);
            this.SubpanelCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubpanelCPF.Location = new System.Drawing.Point(20, 20);
            this.SubpanelCPF.Margin = new System.Windows.Forms.Padding(0);
            this.SubpanelCPF.Name = "SubpanelCPF";
            this.SubpanelCPF.Size = new System.Drawing.Size(258, 70);
            this.SubpanelCPF.TabIndex = 7;
            // 
            // panelSinistro
            // 
            this.panelSinistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSinistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSinistro.Location = new System.Drawing.Point(5, 37);
            this.panelSinistro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSinistro.Name = "panelSinistro";
            this.panelSinistro.Size = new System.Drawing.Size(248, 33);
            this.panelSinistro.TabIndex = 2;
            // 
            // labelCPFClient
            // 
            this.labelCPFClient.AutoSize = true;
            this.labelCPFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCPFClient.ForeColor = System.Drawing.Color.White;
            this.labelCPFClient.Location = new System.Drawing.Point(5, 5);
            this.labelCPFClient.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.labelCPFClient.Name = "labelCPFClient";
            this.labelCPFClient.Size = new System.Drawing.Size(107, 17);
            this.labelCPFClient.TabIndex = 0;
            this.labelCPFClient.Text = "Tipo de Sinistro";
            // 
            // panelNomeClient
            // 
            this.panelNomeClient.BackColor = System.Drawing.Color.Transparent;
            this.panelNomeClient.Controls.Add(this.subpanelNomeClient);
            this.panelNomeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNomeClient.Location = new System.Drawing.Point(298, 0);
            this.panelNomeClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelNomeClient.Name = "panelNomeClient";
            this.panelNomeClient.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panelNomeClient.Size = new System.Drawing.Size(298, 100);
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
            this.subpanelNomeClient.Size = new System.Drawing.Size(258, 70);
            this.subpanelNomeClient.TabIndex = 8;
            // 
            // panelTextNomeClient
            // 
            this.panelTextNomeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTextNomeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextNomeClient.Location = new System.Drawing.Point(5, 37);
            this.panelTextNomeClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextNomeClient.Name = "panelTextNomeClient";
            this.panelTextNomeClient.Size = new System.Drawing.Size(248, 33);
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
            this.labelNomeClient.Size = new System.Drawing.Size(123, 17);
            this.labelNomeClient.TabIndex = 0;
            this.labelNomeClient.Text = "Código do Sinistro";
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
            this.subpanelDtNascClient.Controls.Add(this.label5);
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
            this.panelDateTimerClient.Location = new System.Drawing.Point(6, 37);
            this.panelDateTimerClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelDateTimerClient.Name = "panelDateTimerClient";
            this.panelDateTimerClient.Size = new System.Drawing.Size(248, 33);
            this.panelDateTimerClient.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 0, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descrição do Sinistro";
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.cadastrarSinistro);
            this.panelButton.Controls.Add(this.panel51);
            this.panelButton.Location = new System.Drawing.Point(0, 240);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.panelButton.Size = new System.Drawing.Size(975, 50);
            this.panelButton.TabIndex = 5;
            // 
            // cadastrarSinistro
            // 
            this.cadastrarSinistro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cadastrarSinistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.cadastrarSinistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarSinistro.FlatAppearance.BorderSize = 0;
            this.cadastrarSinistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarSinistro.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cadastrarSinistro.ForeColor = System.Drawing.Color.White;
            this.cadastrarSinistro.Location = new System.Drawing.Point(755, 0);
            this.cadastrarSinistro.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.cadastrarSinistro.Name = "cadastrarSinistro";
            this.cadastrarSinistro.Size = new System.Drawing.Size(180, 50);
            this.cadastrarSinistro.TabIndex = 12;
            this.cadastrarSinistro.Text = "Cadastrar";
            this.cadastrarSinistro.UseVisualStyleBackColor = false;
            this.cadastrarSinistro.Paint += new System.Windows.Forms.PaintEventHandler(this.cadastrarSinistro_Paint);
            // 
            // panel51
            // 
            this.panel51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel51.Controls.Add(this.button10);
            this.panel51.Location = new System.Drawing.Point(8002, 0);
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
            // CadastroSinistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.contentSinistros);
            this.Controls.Add(this.searchPanel);
            this.Name = "CadastroSinistros";
            this.Size = new System.Drawing.Size(975, 385);
            this.Resize += new System.EventHandler(this.CadastroSinistros_Resize);
            this.searchPanel.ResumeLayout(false);
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contentSinistros.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelCPF.ResumeLayout(false);
            this.SubpanelCPF.ResumeLayout(false);
            this.SubpanelCPF.PerformLayout();
            this.panelNomeClient.ResumeLayout(false);
            this.subpanelNomeClient.ResumeLayout(false);
            this.subpanelNomeClient.PerformLayout();
            this.panelDtNascClient.ResumeLayout(false);
            this.subpanelDtNascClient.ResumeLayout(false);
            this.subpanelDtNascClient.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel searchPanel;
        private Properties.PanelBorderRoundedOnLeft panelSerch;
        private PictureBox pictureBox3;
        private TextBox textSearch;
        private Panel contentSinistros;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panelCPF;
        private Panel SubpanelCPF;
        private Properties.PanelBorderRounded panelSinistro;
        private Label labelCPFClient;
        private Panel panelNomeClient;
        private Panel subpanelNomeClient;
        private Properties.PanelBorderRounded panelTextNomeClient;
        private Label labelNomeClient;
        private Panel panelDtNascClient;
        private Panel subpanelDtNascClient;
        private Properties.PanelBorderRounded panelDateTimerClient;
        private Label label5;
        private Panel panelButton;
        private Panel panel51;
        private Button button10;
        private Button cadastrarSinistro;
    }
}
