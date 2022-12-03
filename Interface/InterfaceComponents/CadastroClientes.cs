using Interface.ControlValidationAuxiliary;
using Interface.TemplateComponents;
using Interface.Utilities;
using System.Data;

namespace Interface
{
    public partial class CadastroClientes : UserControl
    {
        readonly Utilidades utils = new();

        readonly LimparFormularios limpar = new();
        public string TypeControl
        {
            set
            {
                ClienteCPF.TypeControl = value;
                ClienteCNPJ.TypeControl = value;

                if (value.Contains("Cadastro"))
                {
                    searchPanel.Visible = false;
                    ClienteCPF.Location = new Point(0, 62);
                    ClienteCNPJ.Location = new Point(0, 62);
                }
                if (value.Contains("Update"))
                {
                    searchPanel.Visible = true;
                    ClienteCPF.Location = new Point(0, 124);
                    ClienteCNPJ.Location = new Point(0, 124);
                }
            }
        }

        public Overview? overview { get; set; }

        public string Pessoa = "";

        public DataRow OverviewDataResponse
        {
            set
            {
                mkBoxCdClientSearch.Text = value[Pessoa].ToString();

                if (Pessoa != "" && Pessoa.Contains("CPF"))
                {
                    ClienteCPF.DataForUpdate = value;
                }

                if (Pessoa != "" && Pessoa.Contains("CNPJ"))
                {
                    ClienteCNPJ.DataForUpdate = value;
                }
            }
        }

        public CadastroClientes()
        {
            InitializeComponent();
        }
        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            ClienteCPF.Visible = pessoaFisica.Checked;
            ClienteCNPJ.Visible = pessoaFisica.Checked;

            mkBoxCdClientSearch.Mask = pessoaFisica.Checked ? "000.000.000-00" : "00.000.000/0000-00";
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

        private void CadastroClientes_Resize(object sender, EventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        private void panelSerch_Paint(object sender, PaintEventArgs e)
        {
            utils.alignCenterPanels(panelSerch, panel17, true, true);
        }

        public void pessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            ClienteCPF.Visible = pessoaFisica.Checked;

            if (pessoaFisica.Checked)
            {
                var overviewCPF =
                    overview!.Controls["panelContainerRadio"].Controls["tableLayoutPanel1"].Controls["panelCPF"].Controls["CPF"] as RadioButton;

                overviewCPF!.Checked = true;

                pessoaJuridica.Checked = false;
                labelTypePerson.Text = "CPF";

                mkBoxCdClientSearch.Text = "";
                mkBoxCdClientSearch.Height += 20;
                mkBoxCdClientSearch.Mask = "000.000.000-00";

                limpar.CleanControl(ClienteCPF.Controls["contentCPF"]);
            }
        }

        public void pessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            ClienteCNPJ.Visible = pessoaJuridica.Checked;

            if (pessoaJuridica.Checked)
            {
                var overviewCPF =
                    overview!.Controls["panelContainerRadio"].Controls["tableLayoutPanel1"].Controls["panelCNPJ"].Controls["CNPJ"] as RadioButton;

                overviewCPF!.Checked = true;

                pessoaFisica.Checked = false;

                labelTypePerson.Text = "CNPF";

                mkBoxCdClientSearch.Text = "";
                mkBoxCdClientSearch.Mask = "00.000.000/0000-00";

                limpar.CleanControl(ClienteCNPJ.Controls["contentCNPJ"]);
            }
        }

        private void mkBoxCdClientSearch_TextChanged(object sender, EventArgs e)
        {
            if (pessoaFisica.Checked)
            {
                MasckedboxTemplete? inputMaskCPF = ClienteCPF.Controls["contentCPF"].Controls["tableLayoutPanel3"].Controls["panelCPF"].Controls["SubpanelCPF"].Controls["panelTextCPFClient"].Controls["mkCPF"] as MasckedboxTemplete;

                inputMaskCPF!.Text = mkBoxCdClientSearch.Text;
            }

            if (pessoaJuridica.Checked)
            {
                MasckedboxTemplete? inputMaskCNPJ = ClienteCNPJ.Controls["contentCNPJ"].Controls["tableLayoutPanel3"].Controls["panelCPF"].Controls["SubpanelCPF"].Controls["panelTextCNPJClient"].Controls["mkCNPJ"] as MasckedboxTemplete;

                inputMaskCNPJ!.Text = mkBoxCdClientSearch.Text;
            }

            utils.feedbackColorInput(mkBoxCdClientSearch, labelTypePerson);
        }
    }
}
