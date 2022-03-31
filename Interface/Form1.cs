using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            contentCliente.Visible = false;

            //user photo
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox2.DisplayRectangle);
            pictureBox2.Region = new Region(gp);
        }

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

        public static string activeDash = "Dash";

        public static string activeOver = "Over";

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (activeDash == "Dash")
            {
                buttonDash.ForeColor = Color.FromArgb(0, 98, 255);
                lineDash.BackColor = Color.FromArgb(0, 98, 255);
            }
            else if (activeDash == "Exchange")
            {
                buttonEx.ForeColor = Color.FromArgb(0, 98, 255);
                lineEx.BackColor = Color.FromArgb(0, 98, 255);
            }

            if (activeOver == "Over")
            {
                buttonOver.ForeColor = Color.FromArgb(0, 98, 255);
                lineOver.BackColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void button1_MouseHover_2(object sender, EventArgs e)
        {
            if (activeDash != "Dash")
            {
                buttonDash.ForeColor = Color.FromArgb(0, 98, 255);
                lineDash.BackColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (activeDash != "Dash")
            {
                buttonDash.ForeColor = Color.White;
                lineDash.BackColor = Color.Transparent;
            }
        }

        private void buttonDash_Click_1(object sender, EventArgs e)
        {
            activeDash = "Dash";

            buttonEx.ForeColor = Color.White;
            lineEx.BackColor = Color.Transparent;
            buttonPrice.ForeColor = Color.White;
            linePrice.BackColor = Color.Transparent;

            if (activeDash == "Dash")
            {
                buttonDash.ForeColor = Color.FromArgb(0, 98, 255);
                lineDash.BackColor = Color.FromArgb(0, 98, 255);
                contentCliente.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activeDash = "Exchange";

            buttonDash.ForeColor = Color.White;
            lineDash.BackColor = Color.Transparent;
            buttonPrice.ForeColor = Color.White;
            linePrice.BackColor = Color.Transparent;
            contentCliente.Visible = false;

            if (activeDash == "Exchange")
            {
                buttonEx.ForeColor = Color.FromArgb(0, 98, 255);
                lineEx.BackColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            activeDash = "Price";

            buttonDash.ForeColor = Color.White;
            lineDash.BackColor = Color.Transparent;
            buttonEx.ForeColor = Color.White;
            lineEx.BackColor = Color.Transparent;

            if (activeDash == "Price")
            {
                buttonPrice.ForeColor = Color.FromArgb(0, 98, 255);
                linePrice.BackColor = Color.FromArgb(0, 98, 255);
            }
        }


        private void buttonOver_Click(object sender, EventArgs e)
        {
            activeOver = "Over";
            buttonCa.ForeColor = Color.White;
            buttonUp.ForeColor = Color.White;
            buttonDel.ForeColor = Color.White;

            lineCa.BackColor = Color.Transparent;
            lineUp.BackColor = Color.Transparent;
            lineDel.BackColor = Color.Transparent;

            if (activeOver == "Over")
            {
                buttonOver.ForeColor = Color.FromArgb(0, 98, 255);
                lineOver.BackColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void buttonOver_MouseHover(object sender, EventArgs e)
        {
            if (activeOver != "Over")
            {
                buttonOver.ForeColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void buttonOver_MouseLeave(object sender, EventArgs e)
        {
            if (activeOver != "Over")
            {
                buttonOver.ForeColor = Color.White;
            }
        }

        private void buttonCa_Click(object sender, EventArgs e)
        {
            activeOver = "Cadastro";
            buttonOver.ForeColor = Color.White;
            buttonUp.ForeColor = Color.White;
            buttonDel.ForeColor = Color.White;

            lineOver.BackColor = Color.Transparent;
            lineUp.BackColor = Color.Transparent;
            lineDel.BackColor = Color.Transparent;

            if (activeOver == "Cadastro")
            {
                buttonCa.ForeColor = Color.FromArgb(0, 98, 255);
                lineCa.BackColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            activeOver = "Update";
            buttonOver.ForeColor = Color.White;
            buttonCa.ForeColor = Color.White;
            buttonDel.ForeColor = Color.White;

            lineOver.BackColor = Color.Transparent;
            lineCa.BackColor = Color.Transparent;
            lineDel.BackColor = Color.Transparent;

            if (activeOver == "Update")
            {
                buttonUp.ForeColor = Color.FromArgb(0, 98, 255);
                lineUp.BackColor = Color.FromArgb(0, 98, 255);
            }
        }


        private void buttonDel_Click(object sender, EventArgs e)
        {
            activeOver = "Delete";
            buttonOver.ForeColor = Color.White;
            buttonCa.ForeColor = Color.White;
            buttonUp.ForeColor = Color.White;

            lineOver.BackColor = Color.Transparent;
            lineCa.BackColor = Color.Transparent;
            lineUp.BackColor = Color.Transparent;

            if (activeOver == "Delete")
            {
                buttonDel.ForeColor = Color.FromArgb(0, 98, 255);
                lineDel.BackColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            if (buttonOver.ForeColor == Color.FromArgb(0, 98, 255))
            {
                lineOver.BackColor = Color.FromArgb(0, 98, 255);
            }
            else
            {
                lineOver.BackColor = Color.Transparent;
            }
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, body.ClientRectangle,
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid, // left
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.Transparent, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, flowLayoutPanel2.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.FromArgb(30, 30, 36), 1, ButtonBorderStyle.Solid);// bottom
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pessoaJuridica.Location = new Point()
            {
                X = panel15.Width / 2 - pessoaJuridica.Width / 2,
                Y = panel15.Height / 2 - pessoaJuridica.Height / 2
            };
            pessoaFisica.Location = new Point()
            {
                X = panel20.Width / 2 - pessoaFisica.Width / 2,
                Y = panel20.Height / 2 - pessoaFisica.Height / 2
            };

            panel13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel13.Width, panel13.Height, 10, 10));
            panel51.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel51.Width, panel51.Height, 10, 10));
            panel22.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel22.Width, panel22.Height, 10, 10));
            panel27.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel27.Width, panel27.Height, 10, 10));
            panel30.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel30.Width, panel30.Height, 10, 10));
            panel35.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel35.Width, panel35.Height, 10, 10));
            panel38.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel38.Width, panel38.Height, 10, 10));
            panel40.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel40.Width, panel40.Height, 10, 10));
            panel43.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel43.Width, panel43.Height, 10, 10));
            panel48.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel48.Width, panel48.Height, 10, 10));
            panel49.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel49.Width, panel49.Height, 10, 10));
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel15.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.FromArgb(0, 98, 255), 1, ButtonBorderStyle.Solid);// bottom

            pessoaFisica.Location = new Point()
            {
                X = panel15.Width / 2 - pessoaFisica.Width / 2,
                Y = panel15.Height / 2 - pessoaFisica.Height / 2
            };
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel20.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.FromArgb(0, 98, 255), 1, ButtonBorderStyle.Solid);// bottom

            pessoaJuridica.Location = new Point()
            {
                X = panel20.Width / 2 - pessoaJuridica.Width / 2,
                Y = panel20.Height / 2 - pessoaJuridica.Height / 2
            };
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            panel22.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel22.Width, panel22.Height, 10, 10));
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            panel13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel13.Width, panel13.Height, 10, 10));
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contentCPF_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel51_Paint(object sender, PaintEventArgs e)
        {
            panel51.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel51.Width, panel51.Height, 10, 10));
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            panel27.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel27.Width, panel27.Height, 10, 10));
        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {
            panel30.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel30.Width, panel30.Height, 10, 10));
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            panel35.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel35.Width, panel35.Height, 10, 10));
        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {
            panel38.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel38.Width, panel38.Height, 10, 10));
        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {
            panel40.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel40.Width, panel40.Height, 10, 10));
        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {
            panel43.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel43.Width, panel43.Height, 10, 10));
        }

        private void panel48_Paint(object sender, PaintEventArgs e)
        {
            panel48.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel48.Width, panel48.Height, 10, 10));
        }

        private void panel49_Paint(object sender, PaintEventArgs e)
        {
            panel49.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel49.Width, panel49.Height, 10, 10));
        }

    }
}