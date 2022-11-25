namespace Interface.TemplateComponents
{
    internal class MkDate : MaskedTextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Mask = "00/00/0000";
            TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (MaskCompleted)
            {
                int dias = int.Parse(Text.Substring(0, 2));
                int mes = int.Parse(Text.Substring(2, 2));
                int ano = int.Parse(Text.Substring(4));
                if (dias > 31 || mes > 12 || ano < 1000)
                {
                    MessageBox.Show("É necessário preencher a data  corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Text = "";
                }
                Focus();

            }
        }

        public DateOnly convertDateOnly()
        {
            if (Text.Length >= 8)
            {
                DateOnly date = new DateOnly(int.Parse(Text.Substring(4)), int.Parse(Text.Substring(2, 2)), int.Parse(Text.Substring(0, 2))); ;
                return date;
            }
            else
                return new DateOnly();
        }

    }
}
