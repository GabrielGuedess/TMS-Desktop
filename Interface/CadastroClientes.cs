using Interface.Properties;

namespace Interface
{
    public partial class CadastroClientes : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set
            {
                ClienteCPF.TypeControl = value;
                ClienteCNPJ.TypeControl = value;

                if (value == "Cadastro")
                {
                    searchPanel.Visible = false;
                    ClienteCPF.Location = new Point(0, 62);
                    ClienteCNPJ.Location = new Point(0, 62);
                }
                if (value == "Update")
                {
                    searchPanel.Visible = true;
                    ClienteCPF.Location = new Point(0, 124);
                    ClienteCNPJ.Location = new Point(0, 124);
                }
            }
        }

        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            ClienteCPF.Visible = false;
            ClienteCNPJ.Visible = false;
            pessoaFisica.Checked = true;
        }

        private void panelPessoaFisica_Paint(object sender, PaintEventArgs e)
        {
            utils.RepitarPanelPaint(e, panelPessoaFisica);
            utils.alignCenterRadioButtons(pessoaFisica, panelPessoaFisica, true, true);
        }

        private void panelPessoaJuridica_Paint(object sender, PaintEventArgs e)
        {
            utils.RepitarPanelPaint(e, panelPessoaJuridica);
            utils.alignCenterRadioButtons(pessoaJuridica, panelPessoaJuridica, true, true);
        }

        private void pessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            ClienteCPF.Visible = pessoaFisica.Checked;

            if (pessoaFisica.Checked)
            {
                pessoaJuridica.Checked = false;
                textSearch.PlaceholderText = "CPF";
            }
        }

        private void pessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            ClienteCNPJ.Visible = pessoaJuridica.Checked;

            if (pessoaJuridica.Checked)
            {
                pessoaFisica.Checked = false;
                textSearch.PlaceholderText = "CNPJ";
            }
        }

        private void CadastroClientes_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }
    }
}
