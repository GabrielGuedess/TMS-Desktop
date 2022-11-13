using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class celularfuncionario
    {
        public int ID_celular { get; set; }
        public int ID_for_funcionario { get; set; }
        public string Celular { get; set; } = null!;

        public virtual motorista ID_for_funcionarioNavigation { get; set; } = null!;
    }
}
