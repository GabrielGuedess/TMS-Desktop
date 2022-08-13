using System.Drawing;
using System.Drawing.Drawing2D;

namespace Interface
{
    partial class Dash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.containerDash = new System.Windows.Forms.FlowLayoutPanel();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.lineClientes = new System.Windows.Forms.Panel();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panelEx = new System.Windows.Forms.Panel();
            this.lineEx = new System.Windows.Forms.Panel();
            this.buttonEx = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelPrices = new System.Windows.Forms.Panel();
            this.linePrice = new System.Windows.Forms.Panel();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.panelSerch = new Interface.Properties.PanelBorderRoundedOnLeft();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.containerOverview = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lineOver = new System.Windows.Forms.Panel();
            this.buttonOver = new System.Windows.Forms.Button();
            this.containerCadastro = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCa = new System.Windows.Forms.Button();
            this.lineCa = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.containerUpdate = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonUp = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lineUp = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.containerDelete = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.lineDel = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.cadastroClientes1 = new Interface.CadastroClientes();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.containerDash.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelEx.SuspendLayout();
            this.panelPrices.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSerch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.containerOverview.SuspendLayout();
            this.panel1.SuspendLayout();
            this.containerCadastro.SuspendLayout();
            this.panel3.SuspendLayout();
            this.containerUpdate.SuspendLayout();
            this.panel14.SuspendLayout();
            this.containerDelete.SuspendLayout();
            this.panel16.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(60, 20, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(288, 69);
            this.flowLayoutPanel2.TabIndex = 4;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // containerDash
            // 
            this.containerDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(11)))));
            this.containerDash.Controls.Add(this.panelClientes);
            this.containerDash.Controls.Add(this.panelEx);
            this.containerDash.Controls.Add(this.panelPrices);
            this.containerDash.Dock = System.Windows.Forms.DockStyle.Left;
            this.containerDash.Location = new System.Drawing.Point(0, 70);
            this.containerDash.Margin = new System.Windows.Forms.Padding(0);
            this.containerDash.Name = "containerDash";
            this.containerDash.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.containerDash.Size = new System.Drawing.Size(288, 561);
            this.containerDash.TabIndex = 0;
            // 
            // panelClientes
            // 
            this.panelClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClientes.Controls.Add(this.lineClientes);
            this.panelClientes.Controls.Add(this.buttonClientes);
            this.panelClientes.Controls.Add(this.panel11);
            this.panelClientes.Controls.Add(this.button4);
            this.panelClientes.Controls.Add(this.panel12);
            this.panelClientes.Controls.Add(this.button5);
            this.panelClientes.Location = new System.Drawing.Point(0, 50);
            this.panelClientes.Margin = new System.Windows.Forms.Padding(0, 0, 20, 25);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(288, 37);
            this.panelClientes.TabIndex = 4;
            // 
            // lineClientes
            // 
            this.lineClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineClientes.BackColor = System.Drawing.Color.Transparent;
            this.lineClientes.Location = new System.Drawing.Point(286, 0);
            this.lineClientes.Margin = new System.Windows.Forms.Padding(0);
            this.lineClientes.Name = "lineClientes";
            this.lineClientes.Size = new System.Drawing.Size(2, 37);
            this.lineClientes.TabIndex = 5;
            // 
            // buttonClientes
            // 
            this.buttonClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClientes.BackColor = System.Drawing.Color.Transparent;
            this.buttonClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClientes.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonClientes.Image")));
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.Location = new System.Drawing.Point(0, 0);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.buttonClientes.Size = new System.Drawing.Size(288, 37);
            this.buttonClientes.TabIndex = 4;
            this.buttonClientes.Text = "        Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            this.buttonClientes.MouseLeave += new System.EventHandler(this.buttonClientes_MouseLeave);
            this.buttonClientes.MouseHover += new System.EventHandler(this.buttonClientes_MouseHover);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Location = new System.Drawing.Point(374, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 0);
            this.panel11.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-2, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.button4.Size = new System.Drawing.Size(219, 0);
            this.button4.TabIndex = 2;
            this.button4.Text = "        Exchange";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Location = new System.Drawing.Point(460, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(2, 0);
            this.panel12.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-2, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.button5.Size = new System.Drawing.Size(219, 0);
            this.button5.TabIndex = 1;
            this.button5.Text = "        Dashboard";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panelEx
            // 
            this.panelEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx.Controls.Add(this.lineEx);
            this.panelEx.Controls.Add(this.buttonEx);
            this.panelEx.Controls.Add(this.panel5);
            this.panelEx.Controls.Add(this.button3);
            this.panelEx.Location = new System.Drawing.Point(0, 112);
            this.panelEx.Margin = new System.Windows.Forms.Padding(0, 0, 20, 25);
            this.panelEx.Name = "panelEx";
            this.panelEx.Size = new System.Drawing.Size(288, 37);
            this.panelEx.TabIndex = 1;
            // 
            // lineEx
            // 
            this.lineEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineEx.BackColor = System.Drawing.Color.Transparent;
            this.lineEx.Location = new System.Drawing.Point(286, 0);
            this.lineEx.Margin = new System.Windows.Forms.Padding(0);
            this.lineEx.Name = "lineEx";
            this.lineEx.Size = new System.Drawing.Size(2, 37);
            this.lineEx.TabIndex = 3;
            // 
            // buttonEx
            // 
            this.buttonEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEx.BackColor = System.Drawing.Color.Transparent;
            this.buttonEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEx.FlatAppearance.BorderSize = 0;
            this.buttonEx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEx.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEx.Image = ((System.Drawing.Image)(resources.GetObject("buttonEx.Image")));
            this.buttonEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEx.Location = new System.Drawing.Point(-2, 0);
            this.buttonEx.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.buttonEx.Size = new System.Drawing.Size(290, 37);
            this.buttonEx.TabIndex = 2;
            this.buttonEx.Text = "        Exchange";
            this.buttonEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(372, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 0);
            this.panel5.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-2, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.button3.Size = new System.Drawing.Size(219, 0);
            this.button3.TabIndex = 1;
            this.button3.Text = "        Dashboard";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panelPrices
            // 
            this.panelPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrices.Controls.Add(this.linePrice);
            this.panelPrices.Controls.Add(this.buttonPrice);
            this.panelPrices.Controls.Add(this.panel4);
            this.panelPrices.Controls.Add(this.button1);
            this.panelPrices.Controls.Add(this.panel9);
            this.panelPrices.Controls.Add(this.button2);
            this.panelPrices.Location = new System.Drawing.Point(0, 174);
            this.panelPrices.Margin = new System.Windows.Forms.Padding(0, 0, 20, 25);
            this.panelPrices.Name = "panelPrices";
            this.panelPrices.Size = new System.Drawing.Size(288, 37);
            this.panelPrices.TabIndex = 4;
            this.panelPrices.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrices_Paint);
            // 
            // linePrice
            // 
            this.linePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linePrice.BackColor = System.Drawing.Color.Transparent;
            this.linePrice.Location = new System.Drawing.Point(286, 0);
            this.linePrice.Margin = new System.Windows.Forms.Padding(0);
            this.linePrice.Name = "linePrice";
            this.linePrice.Size = new System.Drawing.Size(2, 37);
            this.linePrice.TabIndex = 4;
            // 
            // buttonPrice
            // 
            this.buttonPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrice.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrice.FlatAppearance.BorderSize = 0;
            this.buttonPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrice.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPrice.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrice.Image")));
            this.buttonPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrice.Location = new System.Drawing.Point(0, 236);
            this.buttonPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.buttonPrice.Size = new System.Drawing.Size(290, 0);
            this.buttonPrice.TabIndex = 4;
            this.buttonPrice.Text = "        Prices";
            this.buttonPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrice.UseVisualStyleBackColor = false;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(374, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 0);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.button1.Size = new System.Drawing.Size(219, 0);
            this.button1.TabIndex = 2;
            this.button1.Text = "        Exchange";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(460, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 0);
            this.panel9.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-2, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.button2.Size = new System.Drawing.Size(219, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "        Dashboard";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1313, 70);
            this.panel2.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.tableLayoutPanel1);
            this.panel8.Location = new System.Drawing.Point(288, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.panel8.Size = new System.Drawing.Size(1025, 70);
            this.panel8.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.Controls.Add(this.panel18, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSerch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.containerOverview, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.containerCadastro, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.containerUpdate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.containerDelete, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 70);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel18
            // 
            this.panel18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.button15);
            this.panel18.Location = new System.Drawing.Point(721, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(254, 67);
            this.panel18.TabIndex = 0;
            // 
            // panel19
            // 
            this.panel19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel19.Controls.Add(this.label2);
            this.panel19.Controls.Add(this.pictureBox2);
            this.panel19.Controls.Add(this.label1);
            this.panel19.Location = new System.Drawing.Point(84, 14);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(170, 38);
            this.panel19.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(48, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Design";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gabriel Guedes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(32, 21);
            this.button15.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(22, 23);
            this.button15.TabIndex = 0;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // panelSerch
            // 
            this.panelSerch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Controls.Add(this.textSearch);
            this.panelSerch.Location = new System.Drawing.Point(5, 17);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(243, 36);
            this.panelSerch.TabIndex = 1;
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
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textSearch.ForeColor = System.Drawing.Color.White;
            this.textSearch.Location = new System.Drawing.Point(52, 8);
            this.textSearch.Margin = new System.Windows.Forms.Padding(10, 8, 10, 0);
            this.textSearch.Name = "textSearch";
            this.textSearch.PlaceholderText = "Search";
            this.textSearch.Size = new System.Drawing.Size(181, 19);
            this.textSearch.TabIndex = 6;
            // 
            // containerOverview
            // 
            this.containerOverview.BackColor = System.Drawing.Color.Transparent;
            this.containerOverview.Controls.Add(this.panel1);
            this.containerOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerOverview.Location = new System.Drawing.Point(253, 0);
            this.containerOverview.Margin = new System.Windows.Forms.Padding(0);
            this.containerOverview.Name = "containerOverview";
            this.containerOverview.Size = new System.Drawing.Size(117, 70);
            this.containerOverview.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lineOver);
            this.panel1.Controls.Add(this.buttonOver);
            this.panel1.Location = new System.Drawing.Point(13, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 47);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lineOver
            // 
            this.lineOver.BackColor = System.Drawing.Color.Transparent;
            this.lineOver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lineOver.Location = new System.Drawing.Point(0, 45);
            this.lineOver.Margin = new System.Windows.Forms.Padding(0);
            this.lineOver.Name = "lineOver";
            this.lineOver.Size = new System.Drawing.Size(90, 2);
            this.lineOver.TabIndex = 1;
            // 
            // buttonOver
            // 
            this.buttonOver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOver.BackColor = System.Drawing.Color.Transparent;
            this.buttonOver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOver.FlatAppearance.BorderSize = 0;
            this.buttonOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOver.ForeColor = System.Drawing.Color.White;
            this.buttonOver.Location = new System.Drawing.Point(0, 0);
            this.buttonOver.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOver.Name = "buttonOver";
            this.buttonOver.Size = new System.Drawing.Size(90, 23);
            this.buttonOver.TabIndex = 1;
            this.buttonOver.Text = "Overview";
            this.buttonOver.UseVisualStyleBackColor = false;
            this.buttonOver.Click += new System.EventHandler(this.buttonOver_Click);
            this.buttonOver.MouseLeave += new System.EventHandler(this.buttonOver_MouseLeave);
            this.buttonOver.MouseHover += new System.EventHandler(this.buttonOver_MouseHover);
            // 
            // containerCadastro
            // 
            this.containerCadastro.BackColor = System.Drawing.Color.Transparent;
            this.containerCadastro.Controls.Add(this.panel3);
            this.containerCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerCadastro.Location = new System.Drawing.Point(370, 0);
            this.containerCadastro.Margin = new System.Windows.Forms.Padding(0);
            this.containerCadastro.Name = "containerCadastro";
            this.containerCadastro.Size = new System.Drawing.Size(117, 70);
            this.containerCadastro.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonCa);
            this.panel3.Controls.Add(this.lineCa);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(13, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 47);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonCa
            // 
            this.buttonCa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCa.BackColor = System.Drawing.Color.Transparent;
            this.buttonCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCa.FlatAppearance.BorderSize = 0;
            this.buttonCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCa.ForeColor = System.Drawing.Color.White;
            this.buttonCa.Location = new System.Drawing.Point(0, -2);
            this.buttonCa.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCa.Name = "buttonCa";
            this.buttonCa.Size = new System.Drawing.Size(90, 23);
            this.buttonCa.TabIndex = 2;
            this.buttonCa.Text = "Cadastro";
            this.buttonCa.UseVisualStyleBackColor = false;
            this.buttonCa.Click += new System.EventHandler(this.buttonCa_Click);
            // 
            // lineCa
            // 
            this.lineCa.BackColor = System.Drawing.Color.Transparent;
            this.lineCa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lineCa.Location = new System.Drawing.Point(0, 45);
            this.lineCa.Margin = new System.Windows.Forms.Padding(0);
            this.lineCa.Name = "lineCa";
            this.lineCa.Size = new System.Drawing.Size(90, 2);
            this.lineCa.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Overview";
            // 
            // containerUpdate
            // 
            this.containerUpdate.BackColor = System.Drawing.Color.Transparent;
            this.containerUpdate.Controls.Add(this.panel14);
            this.containerUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerUpdate.Location = new System.Drawing.Point(487, 0);
            this.containerUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.containerUpdate.Name = "containerUpdate";
            this.containerUpdate.Size = new System.Drawing.Size(117, 70);
            this.containerUpdate.TabIndex = 7;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.buttonUp);
            this.panel14.Controls.Add(this.button8);
            this.panel14.Controls.Add(this.lineUp);
            this.panel14.Controls.Add(this.button9);
            this.panel14.Location = new System.Drawing.Point(13, 20);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(90, 47);
            this.panel14.TabIndex = 3;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackColor = System.Drawing.Color.Transparent;
            this.buttonUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.ForeColor = System.Drawing.Color.White;
            this.buttonUp.Location = new System.Drawing.Point(0, 0);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(90, 23);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.Text = "Update";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 1);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Overview";
            // 
            // lineUp
            // 
            this.lineUp.BackColor = System.Drawing.Color.Transparent;
            this.lineUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lineUp.Location = new System.Drawing.Point(0, 45);
            this.lineUp.Margin = new System.Windows.Forms.Padding(0);
            this.lineUp.Name = "lineUp";
            this.lineUp.Size = new System.Drawing.Size(90, 2);
            this.lineUp.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(47, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Overview";
            // 
            // containerDelete
            // 
            this.containerDelete.BackColor = System.Drawing.Color.Transparent;
            this.containerDelete.Controls.Add(this.panel16);
            this.containerDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerDelete.Location = new System.Drawing.Point(604, 0);
            this.containerDelete.Margin = new System.Windows.Forms.Padding(0);
            this.containerDelete.Name = "containerDelete";
            this.containerDelete.Size = new System.Drawing.Size(117, 70);
            this.containerDelete.TabIndex = 8;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.Controls.Add(this.buttonDel);
            this.panel16.Controls.Add(this.button11);
            this.panel16.Controls.Add(this.button12);
            this.panel16.Controls.Add(this.lineDel);
            this.panel16.Controls.Add(this.button13);
            this.panel16.Location = new System.Drawing.Point(14, 21);
            this.panel16.Margin = new System.Windows.Forms.Padding(0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(90, 47);
            this.panel16.TabIndex = 4;
            this.panel16.Paint += new System.Windows.Forms.PaintEventHandler(this.panel16_Paint);
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.BackColor = System.Drawing.Color.Transparent;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.ForeColor = System.Drawing.Color.White;
            this.buttonDel.Location = new System.Drawing.Point(0, 0);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(90, 23);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(47, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Overview";
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(0, 1);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(47, 23);
            this.button12.TabIndex = 2;
            this.button12.Text = "Overview";
            // 
            // lineDel
            // 
            this.lineDel.BackColor = System.Drawing.Color.Transparent;
            this.lineDel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lineDel.Location = new System.Drawing.Point(0, 45);
            this.lineDel.Margin = new System.Windows.Forms.Padding(0);
            this.lineDel.Name = "lineDel";
            this.lineDel.Size = new System.Drawing.Size(90, 2);
            this.lineDel.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(47, 23);
            this.button13.TabIndex = 1;
            this.button13.Text = "Overview";
            // 
            // body
            // 
            this.body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.body.AutoScroll = true;
            this.body.BackColor = System.Drawing.Color.Black;
            this.body.Controls.Add(this.cadastroClientes1);
            this.body.Location = new System.Drawing.Point(288, 68);
            this.body.Margin = new System.Windows.Forms.Padding(0);
            this.body.Name = "body";
            this.body.Padding = new System.Windows.Forms.Padding(25);
            this.body.Size = new System.Drawing.Size(1025, 563);
            this.body.TabIndex = 7;
            this.body.Paint += new System.Windows.Forms.PaintEventHandler(this.body_Paint);
            // 
            // cadastroClientes1
            // 
            this.cadastroClientes1.BackColor = System.Drawing.Color.Transparent;
            this.cadastroClientes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastroClientes1.Location = new System.Drawing.Point(25, 25);
            this.cadastroClientes1.Margin = new System.Windows.Forms.Padding(0);
            this.cadastroClientes1.Name = "cadastroClientes1";
            this.cadastroClientes1.Size = new System.Drawing.Size(975, 513);
            this.cadastroClientes1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1313, 631);
            this.Controls.Add(this.body);
            this.Controls.Add(this.containerDash);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1000, 0);
            this.Name = "Form1";
            this.Text = "i";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.containerDash.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelEx.ResumeLayout(false);
            this.panelPrices.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.containerOverview.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.containerCadastro.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.containerUpdate.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.containerDelete.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel containerDash;
        private Panel panelEx;
        private Button buttonEx;
        private Panel panel5;
        private Button button3;
        private Panel lineEx;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button buttonOver;
        private TextBox textSearch;
        private Panel panel8;
        private Panel body;
        private Panel panelPrices;
        private Button buttonPrice;
        private Panel panel4;
        private Button button1;
        private Panel panel9;
        private Button button2;
        private Panel linePrice;
        private Panel panelClientes;
        private Panel lineClientes;
        private Button buttonClientes;
        private Panel panel11;
        private Button button4;
        private Panel panel12;
        private Button button5;
        private Panel panel16;
        private Button buttonDel;
        private Button button11;
        private Button button12;
        private Panel lineDel;
        private Button button13;
        private Panel panel14;
        private Button buttonUp;
        private Button button8;
        private Panel lineUp;
        private Button button9;
        private Panel panel3;
        private Button buttonCa;
        private Panel lineCa;
        private Button button6;
        private Panel lineOver;
        private Panel panel18;
        private Button button15;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Panel panel19;
        private PictureBox pictureBox3;
        private Properties.PanelBorderRoundedOnLeft panelSerch;
        private Panel containerOverview;
        private Panel containerCadastro;
        private Panel containerUpdate;
        private Panel containerDelete;
        private CadastroClientes cadastroClientes1;
    }
}