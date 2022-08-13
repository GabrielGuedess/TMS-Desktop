using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Interface.Properties
{
    public class textBoxTemplete : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(225, 19);
            Margin = new Padding(10, 10, 0, 0);
        }
    }
    public class textBoxOnlyLetters : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(10, 10, 0, 0);

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsWhiteSpace(e.KeyChar) || char.IsLetter(e.KeyChar)
                || char.IsSurrogate(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }

    public class PanelBorderRounded : Panel
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // width of ellipse
               int nHeightEllipse // height of ellipse
           );
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            BackColor = Color.FromArgb(15, 15, 19);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            Margin = new Padding(5, 0, 5, 0);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;

        }
    }

    public class PanelBorderRoundedOnRight : Panel
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // width of ellipse
               int nHeightEllipse // height of ellipse
           );
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            BackColor = Color.FromArgb(15, 15, 19);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            Margin = new Padding(5, 0, 5, 0);
            Anchor = AnchorStyles.Right;

        }
    }


    public class PanelBorderRoundedOnLeft : Panel
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // width of ellipse
               int nHeightEllipse // height of ellipse
           );
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            BackColor = Color.FromArgb(15, 15, 19);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            Margin = new Padding(5, 0, 5, 0);
            Anchor = AnchorStyles.Left;

        }
    }

    public class userPhoto : PictureBox
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

    public class masckedboxTemplete : MaskedTextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(10, 10, 0, 0);
            Font = new Font(Font.Name, 12);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
        }
    }


    public class textBoxOnlyNum_Letters : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(10, 10, 0, 0);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;

            else
                e.Handled = true;
        }
    }


    public class Utilidades
    {
        public void rePaintWhite(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.ForeColor = Color.White;
            }
        }

        public void paintTheBorders(PaintEventArgs e, Panel panel, Color color, bool left, bool top, bool right, bool bottom)
        {
            Color leftSide = left ? color : Color.Transparent;
            Color topSide = top ? color : Color.Transparent;
            Color rightSide = right ? color : Color.Transparent;
            Color bottomSide = bottom ? color : Color.Transparent;


            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
            leftSide, 1, ButtonBorderStyle.Solid,
            topSide, 1, ButtonBorderStyle.Solid,
            rightSide, 1, ButtonBorderStyle.Solid,
            bottomSide, 1, ButtonBorderStyle.Solid);
        }

        public void alignCenterRadioButtons(RadioButton button, Panel parentPanel, bool horizontal, bool vertical)
        {

            button.Location = new Point()
            {
                X = horizontal ? parentPanel.Width / 2 - button.Width / 2 : 0,
                Y = vertical ? parentPanel.Height / 2 - button.Height / 2 : 0,
            };

        }


        public void alignCenterButtons(Button button, Panel parentPanel, bool horizontal, bool vertical)
        {

            button.Location = new Point()
            {
                X = horizontal ? parentPanel.Width / 2 - button.Width / 2 : 0,
                Y = vertical ? parentPanel.Height / 2 - button.Height / 2 : 0,
            };

        }


        public void alignCenterPanels(Panel panel, Panel parentPanel, bool horizontal, bool vertical, int xDefault = 0, int yDefault = 0)
        {

            panel.Location = new Point()
            {
                X = horizontal ? parentPanel.Width / 2 - panel.Width / 2 : xDefault,
                Y = vertical ? parentPanel.Height / 2 - panel.Height / 2 : yDefault,
            };

        }

        public void rePaintTransaparent(params Panel[] panels)
        {
            foreach (Panel panel in panels)
            {
                panel.BackColor = Color.Transparent;
            }
        }

        public void paintButton_Panel(Button button, Panel panel)
        {
            button.ForeColor = Color.FromArgb(0, 98, 255);
            panel.BackColor = Color.FromArgb(0, 98, 255);
        }

        public void removePaintButton_Panel(Button button, Panel panel)
        {
            button.ForeColor = Color.FromArgb(255, 255, 255);
            panel.BackColor = Color.Transparent;
        }

        public void RepitarPanelPaint(PaintEventArgs e, Panel panel)
        {
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid,
            Color.Transparent, 1, ButtonBorderStyle.Solid,
            Color.Transparent, 1, ButtonBorderStyle.Solid,
            Color.FromArgb(0, 98, 255), 1, ButtonBorderStyle.Solid);
        }
        public void expansivePanels(params Panel[] panels)
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

            static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );

            foreach (Panel panel in panels)
            {
                panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 10, 10));
            }
        }
    }


}
