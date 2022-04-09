using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

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
            Margin = new Padding(10,10,0,0);
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
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
            Margin= new Padding(5, 0, 5, 0);
            
                
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
            Font = new Font(Font.OriginalFontName, 12);
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

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) )
                e.Handled = false;
            
            else
                e.Handled = true;
        }
    }


    public class Utilidades
    {
        //public delegate void RepintarClickEventHandle(object sender, EventArgs e);
        //public event RepintarClickEventHandle RepintarClickEvent;
        public void rePaintWhite(EventArgs e, params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.ForeColor = Color.White;
            }
        }
        public void rePaintTransaparent(EventArgs e, params Panel[] panels)
        {
            foreach (Panel panel in panels)
            {
                panel.BackColor = Color.Transparent;
            }
        }
        public void paintButton_Panel(EventArgs e, Button button, Panel panel)
        {
            button.ForeColor = Color.FromArgb(0, 98, 255);
            panel.BackColor = Color.FromArgb(0, 98, 255); ;
        }

        public void RepitarPanelPaint(PaintEventArgs e, Panel panel)
        {
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.FromArgb(0, 98, 255), 1, ButtonBorderStyle.Solid);// bottom
        }
        public void expansivePanels(params Panel[] panels)
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
            );
            foreach (Panel panel in panels)
            {
                panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 10, 10));
            }
        }
    }


}
