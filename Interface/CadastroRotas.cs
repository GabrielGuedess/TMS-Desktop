using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class CadastroRotas : UserControl
    {
        public string TypeControl
        {
            set
            {
                if (value == "Cadastro")
                {
                    MessageBox.Show("Cadastro");
                }
                if (value == "Update")
                {
                    MessageBox.Show("Update");
                }
            }
        }
        public CadastroRotas()
        {
            InitializeComponent();
        }
    }
}
