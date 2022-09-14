using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using Interface.TemplateComponents;

namespace Interface.Utilities
{
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

        public void feedbackColorInput(MasckedboxTemplete mask, Label typeData)
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

        public void feedbackColorInputNum(TextBoxOnlyNum mask, Label typeData)
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

        public void feedbackColorInputNumLetters(TextBoxOnlyNum_Letters mask, Label typeData)
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
