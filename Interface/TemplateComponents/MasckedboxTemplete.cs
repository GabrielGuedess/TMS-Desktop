namespace Interface.TemplateComponents
{
    public class MasckedboxTemplete : MaskedTextBox
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
            TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
    }
}
