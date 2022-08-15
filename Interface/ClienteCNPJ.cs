using Interface.Properties;

namespace Interface
{
    public partial class ClienteCNPJ : UserControl
    {
        public string TypeControl
        {
            set { cadastrarCNPJ.Text = value; }
        }

        public ClienteCNPJ()
        {
            InitializeComponent();
        }
    }
}
