using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class emailfuncionario
    {
        public int ID_email { get; set; }
        public int ID_for_funcionario { get; set; }
        public string Email { get; set; } = null!;

        public virtual motorista ID_for_funcionarioNavigation { get; set; } = null!;
    }
}
