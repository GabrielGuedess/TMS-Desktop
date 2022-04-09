using System.Drawing;
using System.Drawing.Drawing2D;

namespace Interface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.lineDash = new System.Windows.Forms.Panel();
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.lineDel = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonUp = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lineUp = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCa = new System.Windows.Forms.Button();
            this.lineCa = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lineOver = new System.Windows.Forms.Panel();
            this.buttonOver = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.contentCliente = new System.Windows.Forms.Panel();
            this.contentCPF = new System.Windows.Forms.Panel();
            this.panel50 = new System.Windows.Forms.Panel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelCPF = new System.Windows.Forms.Panel();
            this.SubpanelCPF = new System.Windows.Forms.Panel();
            this.panelTextCPFClient = new Interface.Properties.PanelBorderRounded();
            this.textCPFClient = new Interface.Properties.masckedboxTemplete();
            this.labelCPFClient = new System.Windows.Forms.Label();
            this.panelNomeClient = new System.Windows.Forms.Panel();
            this.subpanelNomeClient = new System.Windows.Forms.Panel();
            this.panelTextNomeClient = new Interface.Properties.PanelBorderRounded();
            this.textNomeClient = new Interface.Properties.textBoxOnlyLetters();
            this.labelNomeClient = new System.Windows.Forms.Label();
            this.panelDtNascClient = new System.Windows.Forms.Panel();
            this.subpanelDtNascClient = new System.Windows.Forms.Panel();
            this.panelDateTimerClient = new Interface.Properties.PanelBorderRounded();
            this.dateDTNascClient = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panelGeneroClient = new System.Windows.Forms.Panel();
            this.subpanelGeneroClient = new System.Windows.Forms.Panel();
            this.comboGemeroClient = new System.Windows.Forms.ComboBox();
            this.labelGeneroClient = new System.Windows.Forms.Label();
            this.panelRGClient = new System.Windows.Forms.Panel();
            this.subpanelRGClient = new System.Windows.Forms.Panel();
            this.panelTextRGClient = new Interface.Properties.PanelBorderRounded();
            this.textRGClient = new Interface.Properties.masckedboxTemplete();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTelefoneClient = new System.Windows.Forms.Panel();
            this.subpanelTelefoneClient = new System.Windows.Forms.Panel();
            this.panelTextTelefoneCLient = new Interface.Properties.PanelBorderRounded();
            this.textTelefoneClient = new Interface.Properties.masckedboxTemplete();
            this.labelTelefoneClient = new System.Windows.Forms.Label();
            this.panelEmailClient = new System.Windows.Forms.Panel();
            this.subpanelEmailClient = new System.Windows.Forms.Panel();
            this.panelTextEmailClient = new Interface.Properties.PanelBorderRounded();
            this.textEmailClient = new Interface.Properties.textBoxTemplete();
            this.labelEmailClient = new System.Windows.Forms.Label();
            this.panelCEP = new System.Windows.Forms.Panel();
            this.subpanelCEPClient = new System.Windows.Forms.Panel();
            this.panelTextCEPClient = new Interface.Properties.PanelBorderRounded();
            this.buttonPesquisaCEP = new System.Windows.Forms.Button();
            this.textCEPClient = new Interface.Properties.masckedboxTemplete();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCidadeUFClient = new System.Windows.Forms.Panel();
            this.subpanelCidadeUFClient = new System.Windows.Forms.Panel();
            this.labelCidadeClient = new System.Windows.Forms.Label();
            this.comboCidadeClient = new System.Windows.Forms.ComboBox();
            this.comboUFClient = new System.Windows.Forms.ComboBox();
            this.labelUFClient = new System.Windows.Forms.Label();
            this.panelEndereco = new System.Windows.Forms.Panel();
            this.subpanelEndereco = new System.Windows.Forms.Panel();
            this.panelTextNumHomeClient = new Interface.Properties.PanelBorderRounded();
            this.textNumHomeClient = new Interface.Properties.textBoxOnlyNum_Letters();
            this.panelTextEnderecoClient = new Interface.Properties.PanelBorderRounded();
            this.textEndecoClient = new Interface.Properties.textBoxOnlyNum_Letters();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPessoaJuridica = new System.Windows.Forms.Panel();
            this.pessoaJuridica = new System.Windows.Forms.RadioButton();
            this.panelPessoaFisica = new System.Windows.Forms.Panel();
            this.pessoaFisica = new System.Windows.Forms.RadioButton();
            this.panelSerch = new Interface.Properties.PanelBorderRounded();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelEx.SuspendLayout();
            this.panelPrices.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.body.SuspendLayout();
            this.contentCliente.SuspendLayout();
            this.contentCPF.SuspendLayout();
            this.panel50.SuspendLayout();
            this.panel51.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelCPF.SuspendLayout();
            this.SubpanelCPF.SuspendLayout();
            this.panelTextCPFClient.SuspendLayout();
            this.panelNomeClient.SuspendLayout();
            this.subpanelNomeClient.SuspendLayout();
            this.panelTextNomeClient.SuspendLayout();
            this.panelDtNascClient.SuspendLayout();
            this.subpanelDtNascClient.SuspendLayout();
            this.panelDateTimerClient.SuspendLayout();
            this.panelGeneroClient.SuspendLayout();
            this.subpanelGeneroClient.SuspendLayout();
            this.panelRGClient.SuspendLayout();
            this.subpanelRGClient.SuspendLayout();
            this.panelTextRGClient.SuspendLayout();
            this.panelTelefoneClient.SuspendLayout();
            this.subpanelTelefoneClient.SuspendLayout();
            this.panelTextTelefoneCLient.SuspendLayout();
            this.panelEmailClient.SuspendLayout();
            this.subpanelEmailClient.SuspendLayout();
            this.panelTextEmailClient.SuspendLayout();
            this.panelCEP.SuspendLayout();
            this.subpanelCEPClient.SuspendLayout();
            this.panelTextCEPClient.SuspendLayout();
            this.panelCidadeUFClient.SuspendLayout();
            this.subpanelCidadeUFClient.SuspendLayout();
            this.panelEndereco.SuspendLayout();
            this.subpanelEndereco.SuspendLayout();
            this.panelTextNumHomeClient.SuspendLayout();
            this.panelTextEnderecoClient.SuspendLayout();
            this.panel17.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelPessoaJuridica.SuspendLayout();
            this.panelPessoaFisica.SuspendLayout();
            this.panelSerch.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(11)))));
            this.flowLayoutPanel1.Controls.Add(this.panelClientes);
            this.flowLayoutPanel1.Controls.Add(this.panelEx);
            this.flowLayoutPanel1.Controls.Add(this.panelPrices);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 561);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelClientes
            // 
            this.panelClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClientes.Controls.Add(this.lineDash);
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
            // lineDash
            // 
            this.lineDash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineDash.BackColor = System.Drawing.Color.Transparent;
            this.lineDash.Location = new System.Drawing.Point(286, 0);
            this.lineDash.Margin = new System.Windows.Forms.Padding(0);
            this.lineDash.Name = "lineDash";
            this.lineDash.Size = new System.Drawing.Size(2, 37);
            this.lineDash.TabIndex = 5;
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
            this.buttonClientes.Size = new System.Drawing.Size(217, 37);
            this.buttonClientes.TabIndex = 4;
            this.buttonClientes.Text = "        Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonDash_Click_1);
            this.buttonClientes.MouseLeave += new System.EventHandler(this.buttonOver_MouseHover);
            this.buttonClientes.MouseHover += new System.EventHandler(this.button1_MouseHover_2);
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
            this.buttonEx.Size = new System.Drawing.Size(219, 37);
            this.buttonEx.TabIndex = 2;
            this.buttonEx.Text = "        Exchange";
            this.buttonEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.button4_Click);
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
            this.buttonPrice.Location = new System.Drawing.Point(-2, 0);
            this.buttonPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.buttonPrice.Size = new System.Drawing.Size(219, 37);
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
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textSearch.ForeColor = System.Drawing.Color.White;
            this.textSearch.Location = new System.Drawing.Point(62, 10);
            this.textSearch.Margin = new System.Windows.Forms.Padding(10, 21, 0, 0);
            this.textSearch.Name = "textSearch";
            this.textSearch.PlaceholderText = "Search";
            this.textSearch.Size = new System.Drawing.Size(144, 19);
            this.textSearch.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
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
            this.tableLayoutPanel1.Controls.Add(this.panel16, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSerch, 0, 0);
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
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.Controls.Add(this.buttonDel);
            this.panel16.Controls.Add(this.button11);
            this.panel16.Controls.Add(this.button12);
            this.panel16.Controls.Add(this.lineDel);
            this.panel16.Controls.Add(this.button13);
            this.panel16.Location = new System.Drawing.Point(609, 20);
            this.panel16.Margin = new System.Windows.Forms.Padding(5, 20, 5, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(90, 47);
            this.panel16.TabIndex = 4;
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.BackColor = System.Drawing.Color.Black;
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
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.buttonUp);
            this.panel14.Controls.Add(this.button8);
            this.panel14.Controls.Add(this.lineUp);
            this.panel14.Controls.Add(this.button9);
            this.panel14.Location = new System.Drawing.Point(492, 20);
            this.panel14.Margin = new System.Windows.Forms.Padding(5, 20, 5, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(90, 47);
            this.panel14.TabIndex = 3;
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackColor = System.Drawing.Color.Black;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonCa);
            this.panel3.Controls.Add(this.lineCa);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(375, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 20, 5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 47);
            this.panel3.TabIndex = 2;
            // 
            // buttonCa
            // 
            this.buttonCa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCa.BackColor = System.Drawing.Color.Black;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lineOver);
            this.panel1.Controls.Add(this.buttonOver);
            this.panel1.Location = new System.Drawing.Point(258, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 20, 5, 0);
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
            this.buttonOver.BackColor = System.Drawing.Color.Black;
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
            // body
            // 
            this.body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.body.AutoScroll = true;
            this.body.BackColor = System.Drawing.Color.Black;
            this.body.Controls.Add(this.contentCliente);
            this.body.Location = new System.Drawing.Point(288, 68);
            this.body.Margin = new System.Windows.Forms.Padding(0);
            this.body.Name = "body";
            this.body.Padding = new System.Windows.Forms.Padding(25);
            this.body.Size = new System.Drawing.Size(1025, 563);
            this.body.TabIndex = 7;
            this.body.Paint += new System.Windows.Forms.PaintEventHandler(this.body_Paint);
            // 
            // contentCliente
            // 
            this.contentCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentCliente.AutoScroll = true;
            this.contentCliente.BackColor = System.Drawing.Color.Transparent;
            this.contentCliente.Controls.Add(this.contentCPF);
            this.contentCliente.Controls.Add(this.panel17);
            this.contentCliente.Location = new System.Drawing.Point(25, 25);
            this.contentCliente.Margin = new System.Windows.Forms.Padding(0);
            this.contentCliente.Name = "contentCliente";
            this.contentCliente.Size = new System.Drawing.Size(975, 538);
            this.contentCliente.TabIndex = 0;
            this.contentCliente.Visible = false;
            // 
            // contentCPF
            // 
            this.contentCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentCPF.AutoScroll = true;
            this.contentCPF.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.contentCPF.BackColor = System.Drawing.Color.Transparent;
            this.contentCPF.Controls.Add(this.panel50);
            this.contentCPF.Controls.Add(this.tableLayoutPanel3);
            this.contentCPF.Location = new System.Drawing.Point(0, 62);
            this.contentCPF.Margin = new System.Windows.Forms.Padding(0);
            this.contentCPF.Name = "contentCPF";
            this.contentCPF.Padding = new System.Windows.Forms.Padding(40);
            this.contentCPF.Size = new System.Drawing.Size(975, 476);
            this.contentCPF.TabIndex = 5;
            // 
            // panel50
            // 
            this.panel50.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel50.BackColor = System.Drawing.Color.Transparent;
            this.panel50.Controls.Add(this.panel51);
            this.panel50.Location = new System.Drawing.Point(40, 501);
            this.panel50.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(708, 50);
            this.panel50.TabIndex = 5;
            // 
            // panel51
            // 
            this.panel51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.panel51.Controls.Add(this.button10);
            this.panel51.Location = new System.Drawing.Point(508, 0);
            this.panel51.Margin = new System.Windows.Forms.Padding(0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(200, 50);
            this.panel51.TabIndex = 1;
            this.panel51.Paint += new System.Windows.Forms.PaintEventHandler(this.panel51_Paint);
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
            this.button10.Size = new System.Drawing.Size(200, 50);
            this.button10.TabIndex = 1;
            this.button10.Text = "Salvar";
            this.button10.UseVisualStyleBackColor = false;
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
            this.tableLayoutPanel3.Controls.Add(this.panelGeneroClient, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panelRGClient, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panelTelefoneClient, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.panelEmailClient, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panelCEP, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.panelCidadeUFClient, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.panelEndereco, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(40, 43);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(878, 408);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // panelCPF
            // 
            this.panelCPF.BackColor = System.Drawing.Color.Transparent;
            this.panelCPF.Controls.Add(this.SubpanelCPF);
            this.panelCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCPF.Location = new System.Drawing.Point(0, 0);
            this.panelCPF.Margin = new System.Windows.Forms.Padding(0);
            this.panelCPF.Name = "panelCPF";
            this.panelCPF.Size = new System.Drawing.Size(292, 100);
            this.panelCPF.TabIndex = 0;
            // 
            // SubpanelCPF
            // 
            this.SubpanelCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubpanelCPF.BackColor = System.Drawing.Color.Transparent;
            this.SubpanelCPF.Controls.Add(this.panelTextCPFClient);
            this.SubpanelCPF.Controls.Add(this.labelCPFClient);
            this.SubpanelCPF.Location = new System.Drawing.Point(17, 21);
            this.SubpanelCPF.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.SubpanelCPF.Name = "SubpanelCPF";
            this.SubpanelCPF.Size = new System.Drawing.Size(255, 69);
            this.SubpanelCPF.TabIndex = 7;
            // 
            // panelTextCPFClient
            // 
            this.panelTextCPFClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextCPFClient.Controls.Add(this.textCPFClient);
            this.panelTextCPFClient.Location = new System.Drawing.Point(5, 33);
            this.panelTextCPFClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextCPFClient.Name = "panelTextCPFClient";
            this.panelTextCPFClient.Size = new System.Drawing.Size(245, 36);
            this.panelTextCPFClient.TabIndex = 1;
            // 
            // textCPFClient
            // 
            this.textCPFClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textCPFClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCPFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCPFClient.ForeColor = System.Drawing.Color.White;
            this.textCPFClient.Location = new System.Drawing.Point(10, 10);
            this.textCPFClient.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.textCPFClient.Mask = "000.000.000-00";
            this.textCPFClient.Name = "textCPFClient";
            this.textCPFClient.Size = new System.Drawing.Size(225, 19);
            this.textCPFClient.TabIndex = 6;
            // 
            // labelCPFClient
            // 
            this.labelCPFClient.AutoSize = true;
            this.labelCPFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCPFClient.ForeColor = System.Drawing.Color.White;
            this.labelCPFClient.Location = new System.Drawing.Point(0, 4);
            this.labelCPFClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
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
            this.panelNomeClient.Location = new System.Drawing.Point(292, 0);
            this.panelNomeClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelNomeClient.Name = "panelNomeClient";
            this.panelNomeClient.Size = new System.Drawing.Size(292, 100);
            this.panelNomeClient.TabIndex = 1;
            // 
            // subpanelNomeClient
            // 
            this.subpanelNomeClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelNomeClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelNomeClient.Controls.Add(this.panelTextNomeClient);
            this.subpanelNomeClient.Controls.Add(this.labelNomeClient);
            this.subpanelNomeClient.Location = new System.Drawing.Point(17, 21);
            this.subpanelNomeClient.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelNomeClient.Name = "subpanelNomeClient";
            this.subpanelNomeClient.Size = new System.Drawing.Size(255, 69);
            this.subpanelNomeClient.TabIndex = 8;
            // 
            // panelTextNomeClient
            // 
            this.panelTextNomeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextNomeClient.Controls.Add(this.textNomeClient);
            this.panelTextNomeClient.Location = new System.Drawing.Point(5, 33);
            this.panelTextNomeClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextNomeClient.Name = "panelTextNomeClient";
            this.panelTextNomeClient.Size = new System.Drawing.Size(245, 36);
            this.panelTextNomeClient.TabIndex = 1;
            // 
            // textNomeClient
            // 
            this.textNomeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textNomeClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNomeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNomeClient.ForeColor = System.Drawing.Color.White;
            this.textNomeClient.Location = new System.Drawing.Point(10, 10);
            this.textNomeClient.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.textNomeClient.Name = "textNomeClient";
            this.textNomeClient.Size = new System.Drawing.Size(225, 19);
            this.textNomeClient.TabIndex = 0;
            // 
            // labelNomeClient
            // 
            this.labelNomeClient.AutoSize = true;
            this.labelNomeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNomeClient.ForeColor = System.Drawing.Color.White;
            this.labelNomeClient.Location = new System.Drawing.Point(0, 4);
            this.labelNomeClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelNomeClient.Name = "labelNomeClient";
            this.labelNomeClient.Size = new System.Drawing.Size(45, 17);
            this.labelNomeClient.TabIndex = 0;
            this.labelNomeClient.Text = "Nome";
            // 
            // panelDtNascClient
            // 
            this.panelDtNascClient.Controls.Add(this.subpanelDtNascClient);
            this.panelDtNascClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDtNascClient.Location = new System.Drawing.Point(584, 0);
            this.panelDtNascClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelDtNascClient.Name = "panelDtNascClient";
            this.panelDtNascClient.Size = new System.Drawing.Size(294, 100);
            this.panelDtNascClient.TabIndex = 2;
            // 
            // subpanelDtNascClient
            // 
            this.subpanelDtNascClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelDtNascClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelDtNascClient.Controls.Add(this.panelDateTimerClient);
            this.subpanelDtNascClient.Controls.Add(this.label5);
            this.subpanelDtNascClient.Location = new System.Drawing.Point(20, 21);
            this.subpanelDtNascClient.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelDtNascClient.Name = "subpanelDtNascClient";
            this.subpanelDtNascClient.Size = new System.Drawing.Size(254, 69);
            this.subpanelDtNascClient.TabIndex = 9;
            // 
            // panelDateTimerClient
            // 
            this.panelDateTimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelDateTimerClient.Controls.Add(this.dateDTNascClient);
            this.panelDateTimerClient.Location = new System.Drawing.Point(5, 33);
            this.panelDateTimerClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelDateTimerClient.Name = "panelDateTimerClient";
            this.panelDateTimerClient.Size = new System.Drawing.Size(245, 36);
            this.panelDateTimerClient.TabIndex = 2;
            // 
            // dateDTNascClient
            // 
            this.dateDTNascClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDTNascClient.CalendarForeColor = System.Drawing.Color.White;
            this.dateDTNascClient.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateDTNascClient.CalendarTrailingForeColor = System.Drawing.Color.Snow;
            this.dateDTNascClient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDTNascClient.Location = new System.Drawing.Point(10, 10);
            this.dateDTNascClient.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.dateDTNascClient.MaxDate = new System.DateTime(2022, 3, 17, 1, 2, 53, 0);
            this.dateDTNascClient.Name = "dateDTNascClient";
            this.dateDTNascClient.Size = new System.Drawing.Size(225, 21);
            this.dateDTNascClient.TabIndex = 3;
            this.dateDTNascClient.Value = new System.DateTime(2022, 3, 17, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data de Nascimento";
            // 
            // panelGeneroClient
            // 
            this.panelGeneroClient.Controls.Add(this.subpanelGeneroClient);
            this.panelGeneroClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneroClient.Location = new System.Drawing.Point(0, 100);
            this.panelGeneroClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelGeneroClient.Name = "panelGeneroClient";
            this.panelGeneroClient.Size = new System.Drawing.Size(292, 100);
            this.panelGeneroClient.TabIndex = 3;
            // 
            // subpanelGeneroClient
            // 
            this.subpanelGeneroClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelGeneroClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelGeneroClient.Controls.Add(this.comboGemeroClient);
            this.subpanelGeneroClient.Controls.Add(this.labelGeneroClient);
            this.subpanelGeneroClient.Location = new System.Drawing.Point(17, 21);
            this.subpanelGeneroClient.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelGeneroClient.Name = "subpanelGeneroClient";
            this.subpanelGeneroClient.Size = new System.Drawing.Size(255, 69);
            this.subpanelGeneroClient.TabIndex = 9;
            // 
            // comboGemeroClient
            // 
            this.comboGemeroClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboGemeroClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.comboGemeroClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboGemeroClient.ForeColor = System.Drawing.Color.White;
            this.comboGemeroClient.FormattingEnabled = true;
            this.comboGemeroClient.Location = new System.Drawing.Point(0, 36);
            this.comboGemeroClient.Margin = new System.Windows.Forms.Padding(0);
            this.comboGemeroClient.Name = "comboGemeroClient";
            this.comboGemeroClient.Size = new System.Drawing.Size(255, 33);
            this.comboGemeroClient.TabIndex = 4;
            // 
            // labelGeneroClient
            // 
            this.labelGeneroClient.AutoSize = true;
            this.labelGeneroClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelGeneroClient.ForeColor = System.Drawing.Color.White;
            this.labelGeneroClient.Location = new System.Drawing.Point(0, 4);
            this.labelGeneroClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelGeneroClient.Name = "labelGeneroClient";
            this.labelGeneroClient.Size = new System.Drawing.Size(56, 17);
            this.labelGeneroClient.TabIndex = 0;
            this.labelGeneroClient.Text = "Genêro";
            // 
            // panelRGClient
            // 
            this.panelRGClient.Controls.Add(this.subpanelRGClient);
            this.panelRGClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRGClient.Location = new System.Drawing.Point(292, 100);
            this.panelRGClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelRGClient.Name = "panelRGClient";
            this.panelRGClient.Size = new System.Drawing.Size(292, 100);
            this.panelRGClient.TabIndex = 4;
            // 
            // subpanelRGClient
            // 
            this.subpanelRGClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelRGClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelRGClient.Controls.Add(this.panelTextRGClient);
            this.subpanelRGClient.Controls.Add(this.label7);
            this.subpanelRGClient.Location = new System.Drawing.Point(17, 21);
            this.subpanelRGClient.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelRGClient.Name = "subpanelRGClient";
            this.subpanelRGClient.Size = new System.Drawing.Size(255, 69);
            this.subpanelRGClient.TabIndex = 8;
            // 
            // panelTextRGClient
            // 
            this.panelTextRGClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextRGClient.Controls.Add(this.textRGClient);
            this.panelTextRGClient.Location = new System.Drawing.Point(5, 32);
            this.panelTextRGClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextRGClient.Name = "panelTextRGClient";
            this.panelTextRGClient.Size = new System.Drawing.Size(245, 36);
            this.panelTextRGClient.TabIndex = 1;
            // 
            // textRGClient
            // 
            this.textRGClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textRGClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRGClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textRGClient.ForeColor = System.Drawing.Color.White;
            this.textRGClient.Location = new System.Drawing.Point(10, 10);
            this.textRGClient.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.textRGClient.Mask = "00.000.000-0";
            this.textRGClient.Name = "textRGClient";
            this.textRGClient.Size = new System.Drawing.Size(225, 19);
            this.textRGClient.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "RG";
            // 
            // panelTelefoneClient
            // 
            this.panelTelefoneClient.Controls.Add(this.subpanelTelefoneClient);
            this.panelTelefoneClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTelefoneClient.Location = new System.Drawing.Point(584, 100);
            this.panelTelefoneClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelTelefoneClient.Name = "panelTelefoneClient";
            this.panelTelefoneClient.Size = new System.Drawing.Size(294, 100);
            this.panelTelefoneClient.TabIndex = 5;
            // 
            // subpanelTelefoneClient
            // 
            this.subpanelTelefoneClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelTelefoneClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelTelefoneClient.Controls.Add(this.panelTextTelefoneCLient);
            this.subpanelTelefoneClient.Controls.Add(this.labelTelefoneClient);
            this.subpanelTelefoneClient.Location = new System.Drawing.Point(20, 21);
            this.subpanelTelefoneClient.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelTelefoneClient.Name = "subpanelTelefoneClient";
            this.subpanelTelefoneClient.Size = new System.Drawing.Size(254, 69);
            this.subpanelTelefoneClient.TabIndex = 9;
            // 
            // panelTextTelefoneCLient
            // 
            this.panelTextTelefoneCLient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextTelefoneCLient.Controls.Add(this.textTelefoneClient);
            this.panelTextTelefoneCLient.Location = new System.Drawing.Point(5, 32);
            this.panelTextTelefoneCLient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextTelefoneCLient.Name = "panelTextTelefoneCLient";
            this.panelTextTelefoneCLient.Size = new System.Drawing.Size(245, 36);
            this.panelTextTelefoneCLient.TabIndex = 1;
            // 
            // textTelefoneClient
            // 
            this.textTelefoneClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textTelefoneClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefoneClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTelefoneClient.ForeColor = System.Drawing.Color.White;
            this.textTelefoneClient.Location = new System.Drawing.Point(10, 10);
            this.textTelefoneClient.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.textTelefoneClient.Mask = "(00) 00000-0000";
            this.textTelefoneClient.Name = "textTelefoneClient";
            this.textTelefoneClient.Size = new System.Drawing.Size(225, 19);
            this.textTelefoneClient.TabIndex = 0;
            // 
            // labelTelefoneClient
            // 
            this.labelTelefoneClient.AutoSize = true;
            this.labelTelefoneClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTelefoneClient.ForeColor = System.Drawing.Color.White;
            this.labelTelefoneClient.Location = new System.Drawing.Point(0, 4);
            this.labelTelefoneClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelTelefoneClient.Name = "labelTelefoneClient";
            this.labelTelefoneClient.Size = new System.Drawing.Size(64, 17);
            this.labelTelefoneClient.TabIndex = 0;
            this.labelTelefoneClient.Text = "Telefone";
            // 
            // panelEmailClient
            // 
            this.panelEmailClient.Controls.Add(this.subpanelEmailClient);
            this.panelEmailClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmailClient.Location = new System.Drawing.Point(0, 200);
            this.panelEmailClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelEmailClient.Name = "panelEmailClient";
            this.panelEmailClient.Size = new System.Drawing.Size(292, 100);
            this.panelEmailClient.TabIndex = 6;
            // 
            // subpanelEmailClient
            // 
            this.subpanelEmailClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelEmailClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelEmailClient.Controls.Add(this.panelTextEmailClient);
            this.subpanelEmailClient.Controls.Add(this.labelEmailClient);
            this.subpanelEmailClient.Location = new System.Drawing.Point(17, 21);
            this.subpanelEmailClient.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelEmailClient.Name = "subpanelEmailClient";
            this.subpanelEmailClient.Size = new System.Drawing.Size(255, 69);
            this.subpanelEmailClient.TabIndex = 10;
            // 
            // panelTextEmailClient
            // 
            this.panelTextEmailClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextEmailClient.Controls.Add(this.textEmailClient);
            this.panelTextEmailClient.Location = new System.Drawing.Point(5, 33);
            this.panelTextEmailClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextEmailClient.Name = "panelTextEmailClient";
            this.panelTextEmailClient.Size = new System.Drawing.Size(245, 36);
            this.panelTextEmailClient.TabIndex = 1;
            // 
            // textEmailClient
            // 
            this.textEmailClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textEmailClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEmailClient.ForeColor = System.Drawing.Color.White;
            this.textEmailClient.Location = new System.Drawing.Point(10, 10);
            this.textEmailClient.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.textEmailClient.Name = "textEmailClient";
            this.textEmailClient.Size = new System.Drawing.Size(225, 19);
            this.textEmailClient.TabIndex = 0;
            // 
            // labelEmailClient
            // 
            this.labelEmailClient.AutoSize = true;
            this.labelEmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelEmailClient.ForeColor = System.Drawing.Color.White;
            this.labelEmailClient.Location = new System.Drawing.Point(0, 4);
            this.labelEmailClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelEmailClient.Name = "labelEmailClient";
            this.labelEmailClient.Size = new System.Drawing.Size(47, 17);
            this.labelEmailClient.TabIndex = 0;
            this.labelEmailClient.Text = "E-mail";
            // 
            // panelCEP
            // 
            this.panelCEP.Controls.Add(this.subpanelCEPClient);
            this.panelCEP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCEP.Location = new System.Drawing.Point(292, 200);
            this.panelCEP.Margin = new System.Windows.Forms.Padding(0);
            this.panelCEP.Name = "panelCEP";
            this.panelCEP.Size = new System.Drawing.Size(292, 100);
            this.panelCEP.TabIndex = 7;
            // 
            // subpanelCEPClient
            // 
            this.subpanelCEPClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelCEPClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelCEPClient.Controls.Add(this.panelTextCEPClient);
            this.subpanelCEPClient.Controls.Add(this.label10);
            this.subpanelCEPClient.Location = new System.Drawing.Point(17, 21);
            this.subpanelCEPClient.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelCEPClient.Name = "subpanelCEPClient";
            this.subpanelCEPClient.Size = new System.Drawing.Size(255, 69);
            this.subpanelCEPClient.TabIndex = 11;
            // 
            // panelTextCEPClient
            // 
            this.panelTextCEPClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextCEPClient.Controls.Add(this.buttonPesquisaCEP);
            this.panelTextCEPClient.Controls.Add(this.textCEPClient);
            this.panelTextCEPClient.Location = new System.Drawing.Point(5, 33);
            this.panelTextCEPClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextCEPClient.Name = "panelTextCEPClient";
            this.panelTextCEPClient.Size = new System.Drawing.Size(245, 36);
            this.panelTextCEPClient.TabIndex = 1;
            // 
            // buttonPesquisaCEP
            // 
            this.buttonPesquisaCEP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPesquisaCEP.BackColor = System.Drawing.Color.Transparent;
            this.buttonPesquisaCEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisaCEP.FlatAppearance.BorderSize = 0;
            this.buttonPesquisaCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisaCEP.Image = ((System.Drawing.Image)(resources.GetObject("buttonPesquisaCEP.Image")));
            this.buttonPesquisaCEP.Location = new System.Drawing.Point(207, 0);
            this.buttonPesquisaCEP.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPesquisaCEP.Name = "buttonPesquisaCEP";
            this.buttonPesquisaCEP.Size = new System.Drawing.Size(28, 37);
            this.buttonPesquisaCEP.TabIndex = 8;
            this.buttonPesquisaCEP.UseVisualStyleBackColor = false;
            // 
            // textCEPClient
            // 
            this.textCEPClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textCEPClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCEPClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCEPClient.ForeColor = System.Drawing.Color.White;
            this.textCEPClient.Location = new System.Drawing.Point(10, 10);
            this.textCEPClient.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.textCEPClient.Mask = "000000-000";
            this.textCEPClient.Name = "textCEPClient";
            this.textCEPClient.Size = new System.Drawing.Size(225, 19);
            this.textCEPClient.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "CEP";
            // 
            // panelCidadeUFClient
            // 
            this.panelCidadeUFClient.Controls.Add(this.subpanelCidadeUFClient);
            this.panelCidadeUFClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCidadeUFClient.Location = new System.Drawing.Point(584, 200);
            this.panelCidadeUFClient.Margin = new System.Windows.Forms.Padding(0);
            this.panelCidadeUFClient.Name = "panelCidadeUFClient";
            this.panelCidadeUFClient.Size = new System.Drawing.Size(294, 100);
            this.panelCidadeUFClient.TabIndex = 8;
            // 
            // subpanelCidadeUFClient
            // 
            this.subpanelCidadeUFClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelCidadeUFClient.BackColor = System.Drawing.Color.Transparent;
            this.subpanelCidadeUFClient.Controls.Add(this.labelCidadeClient);
            this.subpanelCidadeUFClient.Controls.Add(this.comboCidadeClient);
            this.subpanelCidadeUFClient.Controls.Add(this.comboUFClient);
            this.subpanelCidadeUFClient.Controls.Add(this.labelUFClient);
            this.subpanelCidadeUFClient.Location = new System.Drawing.Point(20, 21);
            this.subpanelCidadeUFClient.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelCidadeUFClient.Name = "subpanelCidadeUFClient";
            this.subpanelCidadeUFClient.Size = new System.Drawing.Size(254, 69);
            this.subpanelCidadeUFClient.TabIndex = 12;
            // 
            // labelCidadeClient
            // 
            this.labelCidadeClient.AutoSize = true;
            this.labelCidadeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCidadeClient.ForeColor = System.Drawing.Color.White;
            this.labelCidadeClient.Location = new System.Drawing.Point(130, 3);
            this.labelCidadeClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelCidadeClient.Name = "labelCidadeClient";
            this.labelCidadeClient.Size = new System.Drawing.Size(52, 17);
            this.labelCidadeClient.TabIndex = 7;
            this.labelCidadeClient.Text = "Cidade";
            // 
            // comboCidadeClient
            // 
            this.comboCidadeClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCidadeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.comboCidadeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboCidadeClient.ForeColor = System.Drawing.Color.White;
            this.comboCidadeClient.FormattingEnabled = true;
            this.comboCidadeClient.Location = new System.Drawing.Point(130, 36);
            this.comboCidadeClient.Margin = new System.Windows.Forms.Padding(0);
            this.comboCidadeClient.Name = "comboCidadeClient";
            this.comboCidadeClient.Size = new System.Drawing.Size(124, 33);
            this.comboCidadeClient.TabIndex = 6;
            // 
            // comboUFClient
            // 
            this.comboUFClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboUFClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.comboUFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboUFClient.ForeColor = System.Drawing.Color.White;
            this.comboUFClient.FormattingEnabled = true;
            this.comboUFClient.Location = new System.Drawing.Point(0, 37);
            this.comboUFClient.Margin = new System.Windows.Forms.Padding(0);
            this.comboUFClient.Name = "comboUFClient";
            this.comboUFClient.Size = new System.Drawing.Size(72, 33);
            this.comboUFClient.TabIndex = 5;
            // 
            // labelUFClient
            // 
            this.labelUFClient.AutoSize = true;
            this.labelUFClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelUFClient.ForeColor = System.Drawing.Color.White;
            this.labelUFClient.Location = new System.Drawing.Point(0, 4);
            this.labelUFClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelUFClient.Name = "labelUFClient";
            this.labelUFClient.Size = new System.Drawing.Size(26, 17);
            this.labelUFClient.TabIndex = 0;
            this.labelUFClient.Text = "UF";
            // 
            // panelEndereco
            // 
            this.panelEndereco.Controls.Add(this.subpanelEndereco);
            this.panelEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEndereco.Location = new System.Drawing.Point(0, 300);
            this.panelEndereco.Margin = new System.Windows.Forms.Padding(0);
            this.panelEndereco.Name = "panelEndereco";
            this.panelEndereco.Size = new System.Drawing.Size(292, 108);
            this.panelEndereco.TabIndex = 9;
            // 
            // subpanelEndereco
            // 
            this.subpanelEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpanelEndereco.BackColor = System.Drawing.Color.Transparent;
            this.subpanelEndereco.Controls.Add(this.panelTextNumHomeClient);
            this.subpanelEndereco.Controls.Add(this.panelTextEnderecoClient);
            this.subpanelEndereco.Controls.Add(this.label14);
            this.subpanelEndereco.Controls.Add(this.label13);
            this.subpanelEndereco.Location = new System.Drawing.Point(17, 26);
            this.subpanelEndereco.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.subpanelEndereco.Name = "subpanelEndereco";
            this.subpanelEndereco.Size = new System.Drawing.Size(231, 69);
            this.subpanelEndereco.TabIndex = 12;
            // 
            // panelTextNumHomeClient
            // 
            this.panelTextNumHomeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextNumHomeClient.Controls.Add(this.textNumHomeClient);
            this.panelTextNumHomeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelTextNumHomeClient.Location = new System.Drawing.Point(159, 33);
            this.panelTextNumHomeClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextNumHomeClient.Name = "panelTextNumHomeClient";
            this.panelTextNumHomeClient.Size = new System.Drawing.Size(67, 36);
            this.panelTextNumHomeClient.TabIndex = 10;
            // 
            // textNumHomeClient
            // 
            this.textNumHomeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textNumHomeClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumHomeClient.ForeColor = System.Drawing.Color.White;
            this.textNumHomeClient.Location = new System.Drawing.Point(5, 10);
            this.textNumHomeClient.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.textNumHomeClient.Name = "textNumHomeClient";
            this.textNumHomeClient.Size = new System.Drawing.Size(50, 19);
            this.textNumHomeClient.TabIndex = 0;
            // 
            // panelTextEnderecoClient
            // 
            this.panelTextEnderecoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelTextEnderecoClient.Controls.Add(this.textEndecoClient);
            this.panelTextEnderecoClient.Location = new System.Drawing.Point(5, 33);
            this.panelTextEnderecoClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTextEnderecoClient.Name = "panelTextEnderecoClient";
            this.panelTextEnderecoClient.Size = new System.Drawing.Size(144, 36);
            this.panelTextEnderecoClient.TabIndex = 9;
            // 
            // textEndecoClient
            // 
            this.textEndecoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.textEndecoClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEndecoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEndecoClient.ForeColor = System.Drawing.Color.White;
            this.textEndecoClient.Location = new System.Drawing.Point(5, 10);
            this.textEndecoClient.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.textEndecoClient.Name = "textEndecoClient";
            this.textEndecoClient.Size = new System.Drawing.Size(130, 19);
            this.textEndecoClient.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(159, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "N°";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Endereço";
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.tableLayoutPanel2);
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(975, 62);
            this.panel17.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelPessoaJuridica, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelPessoaFisica, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(975, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelPessoaJuridica
            // 
            this.panelPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoaJuridica.BackColor = System.Drawing.Color.Transparent;
            this.panelPessoaJuridica.Controls.Add(this.pessoaJuridica);
            this.panelPessoaJuridica.Location = new System.Drawing.Point(487, 0);
            this.panelPessoaJuridica.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoaJuridica.Name = "panelPessoaJuridica";
            this.panelPessoaJuridica.Size = new System.Drawing.Size(488, 62);
            this.panelPessoaJuridica.TabIndex = 4;
            this.panelPessoaJuridica.Paint += new System.Windows.Forms.PaintEventHandler(this.panel20_Paint);
            // 
            // pessoaJuridica
            // 
            this.pessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoaJuridica.AutoSize = true;
            this.pessoaJuridica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pessoaJuridica.ForeColor = System.Drawing.Color.White;
            this.pessoaJuridica.Location = new System.Drawing.Point(186, 19);
            this.pessoaJuridica.Margin = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.pessoaJuridica.Name = "pessoaJuridica";
            this.pessoaJuridica.Size = new System.Drawing.Size(138, 24);
            this.pessoaJuridica.TabIndex = 3;
            this.pessoaJuridica.Text = "Pessoa Juridica";
            this.pessoaJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // panelPessoaFisica
            // 
            this.panelPessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoaFisica.BackColor = System.Drawing.Color.Transparent;
            this.panelPessoaFisica.Controls.Add(this.pessoaFisica);
            this.panelPessoaFisica.Location = new System.Drawing.Point(0, 0);
            this.panelPessoaFisica.Margin = new System.Windows.Forms.Padding(0);
            this.panelPessoaFisica.Name = "panelPessoaFisica";
            this.panelPessoaFisica.Size = new System.Drawing.Size(487, 62);
            this.panelPessoaFisica.TabIndex = 3;
            this.panelPessoaFisica.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // pessoaFisica
            // 
            this.pessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pessoaFisica.AutoSize = true;
            this.pessoaFisica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pessoaFisica.ForeColor = System.Drawing.Color.White;
            this.pessoaFisica.Location = new System.Drawing.Point(173, 19);
            this.pessoaFisica.Margin = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.pessoaFisica.Name = "pessoaFisica";
            this.pessoaFisica.Size = new System.Drawing.Size(125, 24);
            this.pessoaFisica.TabIndex = 2;
            this.pessoaFisica.Text = "Pessoa Fisica";
            this.pessoaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pessoaFisica.UseVisualStyleBackColor = true;
            // 
            // panelSerch
            // 
            this.panelSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.panelSerch.Controls.Add(this.pictureBox3);
            this.panelSerch.Controls.Add(this.textSearch);
            this.panelSerch.Location = new System.Drawing.Point(5, 0);
            this.panelSerch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelSerch.Name = "panelSerch";
            this.panelSerch.Size = new System.Drawing.Size(211, 36);
            this.panelSerch.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1313, 631);
            this.Controls.Add(this.body);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1000, 0);
            this.Name = "Form1";
            this.Text = "i";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelEx.ResumeLayout(false);
            this.panelPrices.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.contentCliente.ResumeLayout(false);
            this.contentCPF.ResumeLayout(false);
            this.panel50.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelCPF.ResumeLayout(false);
            this.SubpanelCPF.ResumeLayout(false);
            this.SubpanelCPF.PerformLayout();
            this.panelTextCPFClient.ResumeLayout(false);
            this.panelTextCPFClient.PerformLayout();
            this.panelNomeClient.ResumeLayout(false);
            this.subpanelNomeClient.ResumeLayout(false);
            this.subpanelNomeClient.PerformLayout();
            this.panelTextNomeClient.ResumeLayout(false);
            this.panelTextNomeClient.PerformLayout();
            this.panelDtNascClient.ResumeLayout(false);
            this.subpanelDtNascClient.ResumeLayout(false);
            this.subpanelDtNascClient.PerformLayout();
            this.panelDateTimerClient.ResumeLayout(false);
            this.panelGeneroClient.ResumeLayout(false);
            this.subpanelGeneroClient.ResumeLayout(false);
            this.subpanelGeneroClient.PerformLayout();
            this.panelRGClient.ResumeLayout(false);
            this.subpanelRGClient.ResumeLayout(false);
            this.subpanelRGClient.PerformLayout();
            this.panelTextRGClient.ResumeLayout(false);
            this.panelTextRGClient.PerformLayout();
            this.panelTelefoneClient.ResumeLayout(false);
            this.subpanelTelefoneClient.ResumeLayout(false);
            this.subpanelTelefoneClient.PerformLayout();
            this.panelTextTelefoneCLient.ResumeLayout(false);
            this.panelTextTelefoneCLient.PerformLayout();
            this.panelEmailClient.ResumeLayout(false);
            this.subpanelEmailClient.ResumeLayout(false);
            this.subpanelEmailClient.PerformLayout();
            this.panelTextEmailClient.ResumeLayout(false);
            this.panelTextEmailClient.PerformLayout();
            this.panelCEP.ResumeLayout(false);
            this.subpanelCEPClient.ResumeLayout(false);
            this.subpanelCEPClient.PerformLayout();
            this.panelTextCEPClient.ResumeLayout(false);
            this.panelTextCEPClient.PerformLayout();
            this.panelCidadeUFClient.ResumeLayout(false);
            this.subpanelCidadeUFClient.ResumeLayout(false);
            this.subpanelCidadeUFClient.PerformLayout();
            this.panelEndereco.ResumeLayout(false);
            this.subpanelEndereco.ResumeLayout(false);
            this.subpanelEndereco.PerformLayout();
            this.panelTextNumHomeClient.ResumeLayout(false);
            this.panelTextNumHomeClient.PerformLayout();
            this.panelTextEnderecoClient.ResumeLayout(false);
            this.panelTextEnderecoClient.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelPessoaJuridica.ResumeLayout(false);
            this.panelPessoaJuridica.PerformLayout();
            this.panelPessoaFisica.ResumeLayout(false);
            this.panelPessoaFisica.PerformLayout();
            this.panelSerch.ResumeLayout(false);
            this.panelSerch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
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
        private Panel lineDash;
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
        private Panel contentCliente;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Panel panel19;
        private PictureBox pictureBox3;
        private Panel panel17;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelPessoaJuridica;
        private Panel contentCPF;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panelCPF;
        private Label labelCPFClient;
        private RadioButton pessoaJuridica;
        private Panel SubpanelCPF;
        private Panel panelNomeClient;
        private Panel subpanelNomeClient;
        private Label labelNomeClient;
        private Panel panelDtNascClient;
        private Panel subpanelDtNascClient;
        private DateTimePicker dateDTNascClient;
        private Label label5;
        private Panel panelGeneroClient;
        private Panel subpanelGeneroClient;
        private Label labelGeneroClient;
        private ComboBox comboGemeroClient;
        private Panel panelRGClient;
        private Panel subpanelRGClient;
        private Label label7;
        private Panel panelTelefoneClient;
        private Panel subpanelTelefoneClient;
        private Label labelTelefoneClient;
        private Panel panelEmailClient;
        private Panel subpanelEmailClient;
        private Label labelEmailClient;
        private Panel panelCEP;
        private Panel subpanelCEPClient;
        private Label label10;
        private Panel panelCidadeUFClient;
        private Panel subpanelCidadeUFClient;
        private Label labelUFClient;
        private Label labelCidadeClient;
        private ComboBox comboCidadeClient;
        private ComboBox comboUFClient;
        private Panel panelEndereco;
        private Panel subpanelEndereco;
        private Label label14;
        private Label label13;
        private Panel panel50;
        private Panel panel51;
        private Button button10;
        private Button buttonPesquisaCEP;
        private Panel panelPessoaFisica;
        private RadioButton pessoaFisica;
        private Properties.PanelBorderRounded panelTextCPFClient;
        private Properties.masckedboxTemplete textCPFClient;
        private Properties.PanelBorderRounded panelTextNomeClient;
        private Properties.textBoxOnlyLetters textNomeClient;
        private Properties.PanelBorderRounded panelDateTimerClient;
        private Properties.PanelBorderRounded panelTextRGClient;
        private Properties.masckedboxTemplete textRGClient;
        private Properties.PanelBorderRounded panelTextTelefoneCLient;
        private Properties.masckedboxTemplete textTelefoneClient;
        private Properties.PanelBorderRounded panelTextEmailClient;
        private Properties.textBoxTemplete textEmailClient;
        private Properties.PanelBorderRounded panelTextCEPClient;
        private Properties.masckedboxTemplete textCEPClient;
        private Properties.PanelBorderRounded panelTextNumHomeClient;
        private Properties.textBoxOnlyNum_Letters textNumHomeClient;
        private Properties.PanelBorderRounded panelTextEnderecoClient;
        private Properties.textBoxOnlyNum_Letters textEndecoClient;
        private Properties.PanelBorderRounded panelSerch;
    }
}