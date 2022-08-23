namespace Interface
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.panel19 = new System.Windows.Forms.Panel();
            this.userPhoto1 = new Interface.Properties.userPhoto();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.userPhoto1);
            this.panel19.Controls.Add(this.label2);
            this.panel19.Controls.Add(this.label1);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(170, 38);
            this.panel19.TabIndex = 2;
            // 
            // userPhoto1
            // 
            this.userPhoto1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("userPhoto1.ErrorImage")));
            this.userPhoto1.Image = ((System.Drawing.Image)(resources.GetObject("userPhoto1.Image")));
            this.userPhoto1.InitialImage = ((System.Drawing.Image)(resources.GetObject("userPhoto1.InitialImage")));
            this.userPhoto1.Location = new System.Drawing.Point(0, 0);
            this.userPhoto1.Margin = new System.Windows.Forms.Padding(0);
            this.userPhoto1.Name = "userPhoto1";
            this.userPhoto1.Size = new System.Drawing.Size(38, 38);
            this.userPhoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPhoto1.TabIndex = 4;
            this.userPhoto1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(48, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frontend";
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
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel19);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(170, 38);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel19;
        private Label label2;
        private Label label1;
        private Properties.userPhoto userPhoto1;
    }
}
