using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Interface.Properties
{

    public class TextMoney : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(225, 19);
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);

        }
        string valor;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                KeyUp += new KeyEventHandler(key);
                void key(Object o, KeyEventArgs e)
                {
                    valor = Text;
                    if (valor == "")
                        valor = "R$ 0,00";

                    valor = valor.Replace("R$", "").Replace(",", "");

                    if (valor.Length == 1)
                        valor = "00,0" + valor;
                    else if (valor.Length == 2)
                        valor = "00," + valor;
                    else
                        valor = valor.Insert(valor.Length - 2, ",");

                    Text = string.Format("{0:c}", Convert.ToDouble(valor));
                    Select(Text.Length, 0);
                }


            }

            else
                e.Handled = true;
        }
    }
    public class TextKg : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(225, 19);
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);

        }
        string valor;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                KeyUp += new KeyEventHandler(key);
                void key(Object o, KeyEventArgs e)
                {
                    valor = Text;
                    if (valor == "")
                        valor = "0,00 Kg";

                    valor = valor.Replace("Kg", "").Replace(",", "");

                    if (valor.Length == 1)
                        valor = "00,00" + valor;
                    else if (valor.Length == 2)
                        valor = "00,0" + valor;
                    else if (valor.Length == 2)
                        valor = "00,0" + valor;
                    else
                        valor = valor.Insert(valor.Length - 3, ",");

                    Text = string.Format("{0:n} Kg", Convert.ToDouble(valor));
                    Select(Text.Length - 3, 0);
                }


            }
            else
                e.Handled = true;
        }
    }

    public class TextKm : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(225, 19);
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);

        }
        string valor;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                KeyUp += new KeyEventHandler(key);
                void key(Object o, KeyEventArgs e)
                {
                    valor = Text;
                    if (valor == "")
                        valor = "0,00 Km";

                    valor = valor.Replace("Km", "").Replace(",", "");

                    if (valor.Length == 1)
                        valor = "00,00" + valor;
                    else if (valor.Length == 2)
                        valor = "00,0" + valor;
                    else if (valor.Length == 2)
                        valor = "00,0" + valor;
                    else
                        valor = valor.Insert(valor.Length - 3, ",");

                    Text = string.Format("{0:n} Km", Convert.ToDouble(valor));
                    Select(Text.Length - 3, 0);
                }


            }
            else
                e.Handled = true;
        }
    }

    public class TextM3 : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(225, 19);
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);

        }
        string valor;
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                KeyUp += new KeyEventHandler(key);
                void key(Object o, KeyEventArgs e)
                {
                    valor = Text;
                    if (valor == "")
                        valor = "0,00 m³";

                    valor = valor.Replace("m³", "").Replace(",", "");

                    if (valor.Length == 1)
                        valor = "00,00" + valor;
                    else if (valor.Length == 2)
                        valor = "00,0" + valor;
                    else if (valor.Length == 2)
                        valor = "00,0" + valor;
                    else
                        valor = valor.Insert(valor.Length - 3, ",");

                    Text = string.Format("{0:n} m³", Convert.ToDouble(valor));
                    Select(Text.Length - 3, 0);
                }


            }
            else
                e.Handled = true;
        }
    }
    public class EmpDateTimer : DateTimePicker
    {
        protected override void InitLayout()
        {
            Margin = new Padding(10, 6, 10, 5);
            base.InitLayout();
            CustomFormat = " ";
            Format = DateTimePickerFormat.Custom;
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
        }
        protected override void OnValueChanged(EventArgs eventargs)
        {
            base.OnValueChanged(eventargs);
            Format = DateTimePickerFormat.Short;
        }
    }
    public class textBoxTemplete : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Size = new Size(225, 19);
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);
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
            Margin = new Padding(10, 6, 10, 5);
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);
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

    public class masckedboxTemplete : MaskedTextBox
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
    public class textBoxnOnlyNum : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(10, 6, 10, 5);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;

            else
                e.Handled = true;
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
            Margin = new Padding(10, 6, 10, 5);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);
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

        public void paintButtonPanel(Button button, Panel panel)
        {
            button.ForeColor = Color.FromArgb(0, 98, 255);
            panel.BackColor = Color.FromArgb(0, 98, 255);
        }

        public void paintButton(Button button)
        {
            button.ForeColor = Color.FromArgb(0, 98, 255);
        }

        public void paintLine(Panel line)
        {
            line.BackColor = Color.FromArgb(0, 98, 255);
        }


        public void removePaintButtonPanel(Button button, Panel panel)
        {
            button.ForeColor = Color.FromArgb(255, 255, 255);
            panel.BackColor = Color.Transparent;
        }

        public void removePaintButton(Button button)
        {
            button.ForeColor = Color.FromArgb(255, 255, 255);
        }

        public void removePaintLine(Panel line)
        {
            line.BackColor = Color.Transparent;
        }

        public void RepitarPanelPaint(PaintEventArgs e, Panel panel)
        {
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid,
            Color.Transparent, 1, ButtonBorderStyle.Solid,
            Color.Transparent, 1, ButtonBorderStyle.Solid,
            Color.FromArgb(0, 98, 255), 1, ButtonBorderStyle.Solid);
        }
        public void expansivePanels(int rounded, params Panel[] panels)
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
                panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, rounded, rounded));
            }
        }

        public void expansiveDataGrid(int rounded, params DataGridView[] dataGrids)
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

            foreach (DataGridView panel in dataGrids)
            {
                panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, rounded, rounded));
            }
        }

        public void expansiveButton(int rounded, params Button[] buttons)
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

            foreach (Button panel in buttons)
            {
                panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, rounded, rounded));
            }
        }

        public void feedbackColorInput(masckedboxTemplete mask, Label typeData)
        {
            if (mask.MaskCompleted && mask.Text != "")
            {
                typeData.ForeColor = Color.FromArgb(75, 181, 67);
            }

            if (!mask.MaskCompleted && mask.Text != "")
            {
                typeData.ForeColor = Color.FromArgb(255, 51, 51);
            }

            if (mask.Text == "")
            {
                typeData.ForeColor = Color.FromArgb(91, 91, 101);
            }
        }

        public void feedbackColorInputNum(textBoxnOnlyNum mask, Label typeData)
        {
            if (mask.Text != "")
            {
                typeData.ForeColor = Color.FromArgb(75, 181, 67);
            }

            if (mask.Text == "")
            {
                typeData.ForeColor = Color.FromArgb(91, 91, 101);
            }
        }

        public void feedbackColorInputNumLetters(textBoxOnlyNum_Letters mask, Label typeData)
        {
            if (mask.Text != "")
            {
                typeData.ForeColor = Color.FromArgb(75, 181, 67);
            }

            if (mask.Text == "")
            {
                typeData.ForeColor = Color.FromArgb(91, 91, 101);
            }
        }
    }


}
