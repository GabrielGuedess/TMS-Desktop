using System;
using Interface.Properties;

namespace Interface
{
    public partial class UserControl1 : UserControl
    {
        readonly Utilidades utils = new();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            utils.expansivePanels(panel51, panelTextCPFClient,
            panelTextNomeClient, panelDateTimerClient, panelTextRGClient, panelTextTelefoneCLient,
            panelTextEmailClient, panelTextCEPClient, panelTextEnderecoClient);
        }
    }
}
