using Interface.Properties;

namespace Interface
{
    public partial class Dash : Form
    {
        readonly Utilidades utils = new();
        public Dash()
        {
            InitializeComponent();
        }

        public string activeDash = "";

        public string activeOver = "";


        private void Form1_Load(object sender, EventArgs e)
        {
            activeDash = "Exchange";

            activeOver = "Cadastro";

            cadastroClientes1.Visible = false;

            if (activeDash == "Clientes")
            {
                utils.paintButton_Panel(buttonClientes, lineClientes);


                if (activeOver == "Overview")
                {
                    utils.paintButton_Panel(buttonOver, lineOver);
                    cadastroClientes1.Visible = false;
                }

                if (activeOver == "Cadastro")
                {
                    utils.paintButton_Panel(buttonCa, lineCa);
                    cadastroClientes1.Visible = true;
                }

                if (activeOver == "Update")
                {
                    utils.paintButton_Panel(buttonUp, lineUp);
                    cadastroClientes1.Visible = false;
                }

                if (activeOver == "Delete")
                {
                    utils.paintButton_Panel(buttonDel, lineDel);
                    cadastroClientes1.Visible = false;
                }
            }

            if (activeDash == "Exchange")
            {
                utils.paintButton_Panel(buttonEx, lineEx);
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            utils.expansivePanels(panelSerch);

            utils.alignCenterPanels(panel1, containerOverview, true, false, 0, 20);
            utils.alignCenterPanels(panel3, containerCadastro, true, false, 0, 20);
            utils.alignCenterPanels(panel14, containerUpdate, true, false, 0, 20);
            utils.alignCenterPanels(panel16, containerDelete, true, false, 0, 20);

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            activeDash = "Clientes";

            if (activeDash == "Clientes")
            {
                utils.paintButton_Panel(buttonClientes, lineClientes);

                utils.rePaintWhite(buttonEx, buttonPrice);
                utils.rePaintTransaparent(lineEx, linePrice);


                if (activeOver == "Overview")
                {
                    utils.paintButton_Panel(buttonOver, lineOver);
                    cadastroClientes1.Visible = false;
                }

                if (activeOver == "Cadastro")
                {
                    utils.paintButton_Panel(buttonCa, lineCa);
                    cadastroClientes1.Visible = true;
                }


                if (activeOver == "Update")
                {
                    utils.paintButton_Panel(buttonUp, lineUp);
                    cadastroClientes1.Visible = false;
                }

                if (activeOver == "Delete")
                {
                    utils.paintButton_Panel(buttonDel, lineDel);
                    cadastroClientes1.Visible = false;
                }
            }
        }

        private void buttonClientes_MouseHover(object sender, EventArgs e)
        {
            if (activeDash != "Clientes")
            {
                utils.paintButton_Panel(buttonClientes, lineClientes);
            }
        }

        private void buttonClientes_MouseLeave(object sender, EventArgs e)
        {
            if (activeDash != "Clientes")
            {
                utils.rePaintWhite(buttonClientes);
                utils.rePaintTransaparent(lineClientes);
            }
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            activeDash = "Exchange";

            utils.paintButton_Panel(buttonEx, lineEx);

            utils.rePaintWhite(buttonClientes, buttonPrice);
            utils.rePaintTransaparent(lineClientes, linePrice);

        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            activeDash = "Price";

            utils.paintButton_Panel(buttonPrice, linePrice);

            utils.rePaintWhite(buttonClientes, buttonEx);
            utils.rePaintTransaparent(lineClientes, lineEx);
        }


        private void buttonOver_Click(object sender, EventArgs e)
        {
            activeOver = "Overview";

            utils.paintButton_Panel(buttonOver, lineOver);

            if (activeDash == "Clientes")
            {
                utils.rePaintWhite(buttonCa, buttonUp, buttonDel);
                utils.rePaintTransaparent(lineCa, lineUp, lineDel);

                if (activeOver == "Overview")
                {
                    utils.paintButton_Panel(buttonOver, lineOver);
                    cadastroClientes1.Visible = false;
                }

                if (activeOver == "Cadastro")
                {
                    utils.paintButton_Panel(buttonCa, lineCa);
                    cadastroClientes1.Visible = true;
                }


                if (activeOver == "Update")
                {
                    utils.paintButton_Panel(buttonUp, lineUp);
                    cadastroClientes1.Visible = false;
                }

                if (activeOver == "Delete")
                {
                    utils.paintButton_Panel(buttonDel, lineDel);
                    cadastroClientes1.Visible = false;
                }
            }
        }
        private void buttonOver_MouseHover(object sender, EventArgs e)
        {
            if (activeOver != "Overview")
            {
                utils.paintButton_Panel(buttonOver, lineOver);
            }
        }

        private void buttonOver_MouseLeave(object sender, EventArgs e)
        {
            if (activeOver != "Overview")
            {
                utils.rePaintWhite(buttonOver);
                utils.rePaintTransaparent(lineOver);
            }
        }
        public void buttonCa_Click(object sender, EventArgs e)
        {
            activeOver = "Cadastro";

            utils.paintButton_Panel(buttonCa, lineCa);

            if (activeDash == "Clientes")
            {
                utils.rePaintWhite(buttonOver, buttonUp, buttonDel);
                utils.rePaintTransaparent(lineOver, lineUp, lineDel);

                if (activeOver == "Overview")
                {
                    utils.paintButton_Panel(buttonOver, lineOver);
                }

                if (activeOver == "Cadastro")
                {
                    utils.paintButton_Panel(buttonCa, lineCa);
                }


                if (activeOver == "Update")
                {
                    utils.paintButton_Panel(buttonUp, lineUp);
                }

                if (activeOver == "Delete")
                {
                    utils.paintButton_Panel(buttonDel, lineDel);
                }
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            activeOver = "Update";

            utils.rePaintWhite(buttonOver, buttonCa, buttonDel);
            utils.rePaintTransaparent(lineOver, lineCa, lineDel);
            utils.paintButton_Panel(buttonUp, lineUp);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            activeOver = "Delete";

            utils.rePaintWhite(buttonOver, buttonCa, buttonUp);
            utils.rePaintTransaparent(lineOver, lineCa, lineUp);
            utils.paintButton_Panel(buttonDel, lineDel);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panel1, containerOverview, true, false, 0, 20);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panel3, containerCadastro, true, false, 0, 20);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panel14, containerUpdate, true, false, 0, 20);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panel16, containerDelete, true, false, 0, 20);
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, body, Color.FromArgb(30, 30, 36), true, true, false, false);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, flowLayoutPanel2, Color.FromArgb(30, 30, 36), false, false, false, true);
        }

        private void panelPrices_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}