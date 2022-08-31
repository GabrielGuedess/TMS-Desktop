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
                labelTypePerson.Text = "CPF";
                mkBoxCdClientSearch.Text = "";
                mkBoxCdClientSearch.Height = mkBoxCdClientSearch.Height + 20; 
                mkBoxCdClientSearch.Mask = ("000.000.000-00");
            }
        }

        private void pessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            ClienteCNPJ.Visible = pessoaJuridica.Checked;

            if (pessoaJuridica.Checked)
            {
                pessoaFisica.Checked = false;
                labelTypePerson.Text = "CNPF";
                mkBoxCdClientSearch.Text = "";
                mkBoxCdClientSearch.Mask = "00.000.000/0000-00";
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

        private bool validar()
        {
            if (ClienteCPF.Text.Length < 11 )
            {
                MessageBox.Show("CPF digitado é invalido");
                return false;
            }
           /* if (c.Text.Length < 11)
            {
                MessageBox.Show("Celular digitado é inválido");
                return false;
            }
            if (MtxtBtelefone.Text.Length > 1 && MtxtBtelefone.Text.Length < 10)
            {
                MessageBox.Show("Telefone digitado é inválido");
                return false;
            }
            if (MtxtBCEP.Text.Length < 8)
            {
                MessageBox.Show("CEP digitado é inválido");
                return false;
            }
            if (MtxtBnumCNH.Text.Length < 10)
            {
                MessageBox.Show("CNH digitada é inválido");
                return false;
            }
            if (MtxtBvencimentoCNH.Text == " ")
            {
                MessageBox.Show("Preencha o campo de Vencimento da CNH");
                return false;
            }
            if (cmBveiculoP.Text == "")
            {
                MessageBox.Show("Preencha o campo veiculo próprio");
                return false;
            }
            if (cmBmopp.Text == "")
            {
                MessageBox.Show("Preencha o campo Curso MOPP");
                return false;
            }*/
            return true;
        }
    }
}
