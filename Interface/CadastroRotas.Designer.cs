namespace Interface
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
            this.rotas1 = new Interface.Rotas();
            this.SuspendLayout();
            // 
            // rotas1
            // 
            this.rotas1.BackColor = System.Drawing.Color.Transparent;
            this.rotas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotas1.Location = new System.Drawing.Point(0, 0);
            this.rotas1.Margin = new System.Windows.Forms.Padding(0);
            this.rotas1.Name = "rotas1";
            this.rotas1.Size = new System.Drawing.Size(975, 1118);
            this.rotas1.TabIndex = 0;
            // 
            // CadastroRotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rotas1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CadastroRotas";
            this.Size = new System.Drawing.Size(975, 1118);
            this.ResumeLayout(false);

        }

        #endregion

        private Rotas rotas1;
    }
}
