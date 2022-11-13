using System.Drawing.Drawing2D;

namespace Interface.TemplateComponents
{
    public class UserPhoto : PictureBox
    {
        GraphicsPath gp = new GraphicsPath();

        protected override void InitLayout()
        {
            base.InitLayout();
            Size = new Size(38, 38);
            Margin = new Padding(0, 0, 0, 0);
            gp.AddEllipse(DisplayRectangle);
            Region = new Region(gp);
        }
    }
}
