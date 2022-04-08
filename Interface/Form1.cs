using Interface.Properties;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Interface
{
    public partial class Form1 : Form
    {
        Utilidades utilidades = new Utilidades();
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
                buttonClientes.ForeColor = Color.FromArgb(0, 98, 255);
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
                buttonClientes.ForeColor = Color.FromArgb(0, 98, 255);
                lineDash.BackColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void buttonDash_Click_1(object sender, EventArgs e)
        {
            activeDash = "Dash";

            utilidades.rePaintWhite(e, buttonPrice, buttonEx);
            utilidades.rePaintTransaparent(e, lineEx, linePrice);
            /* buttonEx.ForeColor = Color.White;
             lineEx.BackColor = Color.Transparent;
             buttonPrice.ForeColor = Color.White;
             linePrice.BackColor = Color.Transparent;*/

            //if (activeDash == "Dash")
           // {
                utilidades.paintButton_Panel(e, buttonClientes, lineDash);
               /* buttonClientes.ForeColor = Color.FromArgb(0, 98, 255);
                lineDash.BackColor = Color.FromArgb(0, 98, 255);*/
                contentCliente.Visible = true;
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            activeDash = "Exchange";

            utilidades.rePaintWhite(e, buttonClientes, buttonPrice);
            utilidades.rePaintTransaparent(e, lineDash, linePrice);
            /*buttonClientes.ForeColor = Color.White;
            lineDash.BackColor = Color.Transparent;
            buttonPrice.ForeColor = Color.White;
            linePrice.BackColor = Color.Transparent;*/
            contentCliente.Visible = false;

            if (activeDash == "Exchange")
            {
                utilidades.paintButton_Panel(e, buttonEx, lineEx);

               /* buttonEx.ForeColor = Color.FromArgb(0, 98, 255);
                lineEx.BackColor = Color.FromArgb(0, 98, 255);*/
            }
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            activeDash = "Price";
            utilidades.rePaintWhite(e, buttonClientes, buttonEx);
            utilidades.rePaintTransaparent(e, lineDash, lineEx);
            /*buttonClientes.ForeColor = Color.White;
            lineDash.BackColor = Color.Transparent;
            buttonEx.ForeColor = Color.White;
            lineEx.BackColor = Color.Transparent;*/

            if (activeDash == "Price")
            {
                utilidades.paintButton_Panel(e, buttonPrice, linePrice);

                /*buttonPrice.ForeColor = Color.FromArgb(0, 98, 255);
                linePrice.BackColor = Color.FromArgb(0, 98, 255);*/
            }
        }


        private void buttonOver_Click(object sender, EventArgs e)
        {
            activeOver = "Over";
            utilidades.rePaintWhite(e, buttonCa, buttonUp, buttonDel);
            utilidades.rePaintTransaparent(e, lineCa, lineUp, lineDel);
            /*buttonCa.ForeColor = Color.White;
            buttonUp.ForeColor = Color.White;
            buttonDel.ForeColor = Color.White;

            lineCa.BackColor = Color.Transparent;
            lineUp.BackColor = Color.Transparent;
            lineDel.BackColor = Color.Transparent;*/

            if (activeOver == "Over")
            {
                utilidades.paintButton_Panel(e, buttonOver, lineOver);
                /*buttonOver.ForeColor = Color.FromArgb(0, 98, 255);
                lineOver.BackColor = Color.FromArgb(0, 98, 255);*/
            }
        }

        /*private void buttonOver_MouseHover(object sender, EventArgs e)
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
        }*/
        private void buttonOver_MouseHover(object sender, EventArgs e)
        {
            if (activeDash != "Dash")
            {
                buttonClientes.ForeColor = Color.FromArgb(0, 98, 255);
                lineDash.BackColor = Color.FromArgb(0, 98, 255);
            }
        }

        private void buttonOver_MouseLeave(object sender, EventArgs e)
        {
            if (activeDash != "Dash")
            {
                buttonClientes.ForeColor = Color.White;
                lineDash.BackColor = Color.Transparent;
            }
        }
        public void buttonCa_Click(object sender, EventArgs e)
        {
            
            utilidades.rePaintWhite( e, buttonOver, buttonUp, buttonDel);
            activeOver = "Cadastro";

            /*buttonOver.ForeColor = Color.White;
            buttonUp.ForeColor = Color.White;
            buttonDel.ForeColor = Color.White;*/

        utilidades.rePaintTransaparent(e, lineOver, lineUp, lineDel);

            /*lineOver.BackColor = Color.Transparent;
            lineUp.BackColor = Color.Transparent;
            lineDel.BackColor = Color.Transparent;*/

            if (activeOver == "Cadastro")
           {
                utilidades.paintButton_Panel(e, buttonCa, lineCa);
                /*buttonCa.ForeColor = Color.FromArgb(0, 98, 255);
                lineCa.BackColor = Color.FromArgb(0, 98, 255);*/
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            activeOver = "Update";
            utilidades.rePaintWhite(e, buttonOver, buttonCa, buttonDel);
            utilidades.rePaintTransaparent(e, lineOver, lineCa, lineDel);

            /*buttonOver.ForeColor = Color.White;
            buttonCa.ForeColor = Color.White;
            buttonDel.ForeColor = Color.White;

            lineOver.BackColor = Color.Transparent;
            lineCa.BackColor = Color.Transparent;
            lineDel.BackColor = Color.Transparent;*/

            if (activeOver == "Update")
            {
                utilidades.paintButton_Panel(e, buttonUp, lineUp);

                /*buttonUp.ForeColor = Color.FromArgb(0, 98, 255);
                lineUp.BackColor = Color.FromArgb(0, 98, 255);*/
            }
            
        }
        

        private void buttonDel_Click(object sender, EventArgs e)
        {
            activeOver = "Delete";
            utilidades.rePaintWhite(e, buttonOver, buttonCa, buttonUp);
            utilidades.rePaintTransaparent(e, lineOver, lineCa, lineUp);

            /*buttonOver.ForeColor = Color.White;
            buttonCa.ForeColor = Color.White;
            buttonUp.ForeColor = Color.White;

            lineOver.BackColor = Color.Transparent;
            lineCa.BackColor = Color.Transparent;
            lineUp.BackColor = Color.Transparent;*/

            if (activeOver == "Delete")
            {
                utilidades.paintButton_Panel(e, buttonDel, lineDel);

                /*buttonDel.ForeColor = Color.FromArgb(0, 98, 255);
                lineDel.BackColor = Color.FromArgb(0, 98, 255);*/
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
                X = panelPessoaFisica.Width / 2 - pessoaJuridica.Width / 2,
                Y = panelPessoaFisica.Height / 2 - pessoaJuridica.Height / 2
            };
            pessoaFisica.Location = new Point()
            {
                X = panelPessoaJuridica.Width / 2 - pessoaFisica.Width / 2,
                Y = panelPessoaJuridica.Height / 2 - pessoaFisica.Height / 2
            };

            utilidades.expansivePanels(panel51, panel13, panelTextCPFClient,
                panelTextNomeClient, panelDateTimerClient, panelTextRGClient, panelTextTelefoneCLient,
                panelTextEmailClient, panelTextCEPClient, panelTextEnderecoClient, panelTextNumHomeClient);
           /* panel13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel13.Width, panel13.Height, 10, 10));
            panel51.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel51.Width, panel51.Height, 10, 10));
            panelTextCPFClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextCPFClient.Width, panelTextCPFClient.Height, 10, 10));
            panelTextNomeClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextNomeClient.Width, panelTextNomeClient.Height, 10, 10));
            panelDateTimerClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDateTimerClient.Width, panelDateTimerClient.Height, 10, 10));
            panelTextRGClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextRGClient.Width, panelTextRGClient.Height, 10, 10));
            panelTextTelefoneCLient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextTelefoneCLient.Width, panelTextTelefoneCLient.Height, 10, 10));
            panelTextEmailClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextEmailClient.Width, panelTextEmailClient.Height, 10, 10));
            panelTextCEPClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextCEPClient.Width, panelTextCEPClient.Height, 10, 10));
            panelTextEnderecoClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextEnderecoClient.Width, panelTextEnderecoClient.Height, 10, 10));
            panelTextNumHomeClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextNumHomeClient.Width, panelTextNumHomeClient.Height, 10, 10));*/
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            utilidades.RepitarPanelPaint(e, panelPessoaFisica);
           /* ControlPaint.DrawBorder(e.Graphics, panelPessoaFisica.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.FromArgb(0, 98, 255), 1, ButtonBorderStyle.Solid);// bottom*/

            pessoaFisica.Location = new Point()
            {
                X = panelPessoaFisica.Width / 2 - pessoaFisica.Width / 2,
                Y = panelPessoaFisica.Height / 2 - pessoaFisica.Height / 2
            };
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            utilidades.RepitarPanelPaint(e, panelPessoaJuridica);
            /*ControlPaint.DrawBorder(e.Graphics, panelPessoaJuridica.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.FromArgb(0, 98, 255), 1, ButtonBorderStyle.Solid);// bottom*/

            pessoaJuridica.Location = new Point()
            {
                X = panelPessoaJuridica.Width / 2 - pessoaJuridica.Width / 2,
                Y = panelPessoaJuridica.Height / 2 - pessoaJuridica.Height / 2
            };
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            panelTextCPFClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextCPFClient.Width, panelTextCPFClient.Height, 10, 10));
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            panel13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel13.Width, panel13.Height, 10, 10));
        }

        private void panel51_Paint(object sender, PaintEventArgs e)
        {
            panel51.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel51.Width, panel51.Height, 10, 10));
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            panelTextNomeClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextNomeClient.Width, panelTextNomeClient.Height, 10, 10));
        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {
            panelDateTimerClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelDateTimerClient.Width, panelDateTimerClient.Height, 10, 10));
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            panelTextRGClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextRGClient.Width, panelTextRGClient.Height, 10, 10));
        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {
            panelTextTelefoneCLient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextTelefoneCLient.Width, panelTextTelefoneCLient.Height, 10, 10));
        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {
            panelTextEmailClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextEmailClient.Width, panelTextEmailClient.Height, 10, 10));
        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {
            panelTextCEPClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextCEPClient.Width, panelTextCEPClient.Height, 10, 10));
        }

        private void panel48_Paint(object sender, PaintEventArgs e)
        {
            panelTextEnderecoClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextEnderecoClient.Width, panelTextEnderecoClient.Height, 10, 10));
        }

        private void panel49_Paint(object sender, PaintEventArgs e)
        {
            panelTextNumHomeClient.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTextNumHomeClient.Width, panelTextNumHomeClient.Height, 10, 10));
        }

    }
}