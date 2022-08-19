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
                rotas1.TypeControl = value;
            }
        }

        public CadastroRotas()
        {
            InitializeComponent();
        }
    }
}
