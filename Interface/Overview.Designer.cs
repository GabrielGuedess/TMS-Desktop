namespace Interface
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelSerch = new Interface.Properties.PanelBorderRoundedOnLeft();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.contentCPF = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buscar = new System.Windows.Forms.Button();
            this.panel51 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelSerch.SuspendLayout();
            this.panel17.SuspendLayout();
            this.contentCPF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panel51.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panelSerch
            // 
            this.panelSerch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Controls.Add(this.textSearch);
            this.panelSerch.Location = new System.Drawing.Point(326, 13);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(316, 36);
            this.panelSerch.TabIndex = 2;
            this.panelSerch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSerch_Paint);
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textSearch.ForeColor = System.Drawing.Color.White;
            this.textSearch.Location = new System.Drawing.Point(35, 8);
            this.textSearch.Margin = new System.Windows.Forms.Padding(10, 8, 10, 0);
            this.textSearch.Name = "textSearch";
            this.textSearch.PlaceholderText = "Search";
            this.textSearch.Size = new System.Drawing.Size(271, 19);
            this.textSearch.TabIndex = 6;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.panelSerch);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.panel17.Size = new System.Drawing.Size(975, 62);
            this.panel17.TabIndex = 6;
            this.panel17.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // contentCPF
            // 
            this.contentCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentCPF.AutoScroll = true;
            this.contentCPF.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.contentCPF.BackColor = System.Drawing.Color.Transparent;
            this.contentCPF.Controls.Add(this.dataGridView1);
            this.contentCPF.Controls.Add(this.panelButton);
            this.contentCPF.Location = new System.Drawing.Point(0, 62);
            this.contentCPF.Margin = new System.Windows.Forms.Padding(0);
            this.contentCPF.Name = "contentCPF";
            this.contentCPF.Padding = new System.Windows.Forms.Padding(40);
            this.contentCPF.Size = new System.Drawing.Size(975, 451);
            this.contentCPF.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(861, 426);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Resize += new System.EventHandler(this.dataGridView1_Resize);
            // 
            // panelButton
            // 
            this.panelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.buscar);
            this.panelButton.Controls.Add(this.panel51);
            this.panelButton.Location = new System.Drawing.Point(0, 564);
            this.panelButton.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.panelButton.Size = new System.Drawing.Size(958, 50);
            this.panelButton.TabIndex = 5;
            // 
            // buscar
            // 
            this.buscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(199)))));
            this.buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.buscar.ForeColor = System.Drawing.Color.White;
            this.buscar.Location = new System.Drawing.Point(721, 0);
            this.buscar.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(180, 50);
            this.buscar.TabIndex = 9;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Paint += new System.Windows.Forms.PaintEventHandler(this.buscar_Paint);
            // 
            // panel51
            // 
            this.panel51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel51.Controls.Add(this.button10);
            this.panel51.Location = new System.Drawing.Point(8008, 0);
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
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.contentCPF);
            this.Controls.Add(this.panel17);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(975, 513);
            this.Resize += new System.EventHandler(this.Overview_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.contentCPF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox3;
        private Properties.PanelBorderRoundedOnLeft panelSerch;
        private TextBox textSearch;
        private Panel panel17;
        private Panel contentCPF;
        private DataGridView dataGridView1;
        private Panel panelButton;
        private Panel panel51;
        private Button button10;
        private Button buscar;
    }
}
