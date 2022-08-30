using Interface.Properties;

namespace Interface
{
    public partial class Overview : UserControl
    {
        readonly Utilidades utils = new();

        readonly Database database = new();

        public string TypeControl
        {
            set
            {
                buscar.Text = value;

                panelContainerRadio.Visible = false;
                contentOverview.Location = new Point(0, 62);

                database.GetData = value;
                database.PessoaData = CPF.Checked ? "Clientes_Fisicos" : "Clientes_Juridicos";
                database.GetDataGridView(dataGridView1, maskInput);

                if (value.Contains("Clientes"))
                {
                    panelContainerRadio.Visible = true;
                    contentOverview.Location = new Point(0, 124);

                    typeData.Text = CPF.Checked ? "CPF" : "CNPJ";
                    maskInput.Text = "";
                    maskInput.Mask = CPF.Checked ? "000.000.000-00" : "00.000.000/0000-00";
                }

                if (value.Contains("Usuarios"))
                {
                    typeData.Text = "CPF";
                    maskInput.Text = "";
                    maskInput.Mask = "000.000.000-00";
                }

                if (value.Contains("Rotas"))
                {
                    typeData.Text = "ID";
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }

                if (value.Contains("Motoristas"))
                {
                    typeData.Text = "CPF";
                    maskInput.Text = "";
                    maskInput.Mask = "000.000.000-00";
                }

                if (value.Contains("Veiculos"))
                {
                    typeData.Text = "Placa";
                    maskInput.Text = "";
                    maskInput.Mask = ">&&&&&&&";
                }

                if (value.Contains("Terceiros"))
                {
                    typeData.Text = "CPF";
                    maskInput.Text = "";
                    maskInput.Mask = "000.000.000-00";
                }

                if (value.Contains("Sinistros"))
                {
                    typeData.Text = "Código";
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }

                if (value.Contains("Notas"))
                {
                    typeData.Text = "Chave de Acesso";
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }

                if (value.Contains("Tarifas"))
                {
                    typeData.Text = "Nome da empresa";
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }

                if (value.Contains("Redes"))
                {
                    typeData.Text = "Num ID";
                    maskInput.Text = "";
                    maskInput.Mask = "";
                }

                maskInput.Width = 271 - typeData.Width;
                maskInput.Location = new Point(35 + (typeData.Width + 10), 7);
            }
        }
        public Overview()
        {
            InitializeComponent();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            utils.paintTheBorders(e, panel17, Color.FromArgb(0, 98, 255), false, false, false, true);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        private void Overview_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            utils.expansiveDataGrid(20, dataGridView1);
        }

        private void buscar_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, buscar);
        }

        private void CPF_CheckedChanged(object sender, EventArgs e)
        {
            if (CPF.Checked)
            {
                database.PessoaData = "Clientes_Fisicos";
                database.GetDataGridView(dataGridView1, maskInput);

                CNPJ.Checked = false;
                typeData.Text = "CPF";
                maskInput.Mask = "000.000.000-00";
            }
        }

        private void CNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (CNPJ.Checked)
            {
                database.PessoaData = "Clientes_Juridicos";
                database.GetDataGridView(dataGridView1, maskInput);

                CPF.Checked = false;
                typeData.Text = "CNPJ";
                maskInput.Mask = "00.000.000/0000-00";
            }
        }

        private void panelCPF_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterRadioButtons(CPF, panelCPF, true, true);
        }

        private void panelCNPJ_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterRadioButtons(CNPJ, panelCNPJ, true, true);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            database.GetDataGridView(dataGridView1, maskInput);
        }
    }
}
