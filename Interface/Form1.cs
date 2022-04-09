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

        private void buttonDash_Click_1(object sender, EventArgs e)
        {
            activeDash = "Dash";
            utilidades.rePaintWhite(e, buttonPrice, buttonEx);
            utilidades.rePaintTransaparent(e, lineEx, linePrice);
            utilidades.paintButton_Panel(e, buttonClientes, lineDash);
            contentCliente.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            activeDash = "Exchange";

            utilidades.rePaintWhite(e, buttonClientes, buttonPrice);
            utilidades.rePaintTransaparent(e, lineDash, linePrice);
            contentCliente.Visible = false;
            utilidades.paintButton_Panel(e, buttonEx, lineEx);
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            activeDash = "Price";
            utilidades.rePaintWhite(e, buttonClientes, buttonEx);
            utilidades.rePaintTransaparent(e, lineDash, lineEx);
            utilidades.paintButton_Panel(e, buttonPrice, linePrice);
        }


        private void buttonOver_Click(object sender, EventArgs e)
        {
            activeOver = "Over";
            utilidades.rePaintWhite(e, buttonCa, buttonUp, buttonDel);
            utilidades.rePaintTransaparent(e, lineCa, lineUp, lineDel);
            utilidades.paintButton_Panel(e, buttonOver, lineOver);
        }
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
            utilidades.rePaintTransaparent(e, lineOver, lineUp, lineDel);
            utilidades.paintButton_Panel(e, buttonCa, lineCa);  
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            activeOver = "Update";
            utilidades.rePaintWhite(e, buttonOver, buttonCa, buttonDel);
            utilidades.rePaintTransaparent(e, lineOver, lineCa, lineDel);
            utilidades.paintButton_Panel(e, buttonUp, lineUp);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            activeOver = "Delete";
            utilidades.rePaintWhite(e, buttonOver, buttonCa, buttonUp);
            utilidades.rePaintTransaparent(e, lineOver, lineCa, lineUp);
            utilidades.paintButton_Panel(e, buttonDel, lineDel);
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

            utilidades.expansivePanels(panel51, panelSerch, panelTextCPFClient,
                panelTextNomeClient, panelDateTimerClient, panelTextRGClient, panelTextTelefoneCLient,
                panelTextEmailClient, panelTextCEPClient, panelTextEnderecoClient, panelTextNumHomeClient);
           
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            utilidades.RepitarPanelPaint(e, panelPessoaFisica);
            pessoaFisica.Location = new Point()
            {
                X = panelPessoaFisica.Width / 2 - pessoaFisica.Width / 2,
                Y = panelPessoaFisica.Height / 2 - pessoaFisica.Height / 2
            };
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            utilidades.RepitarPanelPaint(e, panelPessoaJuridica);
            

            pessoaJuridica.Location = new Point()
            {
                X = panelPessoaJuridica.Width / 2 - pessoaJuridica.Width / 2,
                Y = panelPessoaJuridica.Height / 2 - pessoaJuridica.Height / 2
            };
        }

        private void panel51_Paint(object sender, PaintEventArgs e)
        {
            panel51.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel51.Width, panel51.Height, 10, 10));
        }

    }
}