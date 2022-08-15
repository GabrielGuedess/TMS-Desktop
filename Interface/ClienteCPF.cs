using Interface.Properties;

namespace Interface
{
    public partial class UserControl1 : UserControl
    {
        readonly Utilidades utils = new();
        public string TypeControl
        {
            set { cadastrarCPF.Text = value; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            utils.expansivePanels(10, panel51, panelTextCPFClient,
            panelTextNomeClient, panelDateTimerClient, panelTextRGClient, panelTextTelefoneCLient,
            panelTextEmailClient, panelTextCEPClient, panelTextEnderecoClient);
        }

        private void cadastrar_Paint(object sender, PaintEventArgs e)
        {
            utils.expansiveButton(10, cadastrarCPF);
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            if (cadastrarCPF.Text == "Cadastro")
            {
                cadastrarCPF.Text = "1Cadastro";
            }

            if (cadastrarCPF.Text == "Update")
            {
                cadastrarCPF.Text = "2Update";
            }
        }
    }
}
