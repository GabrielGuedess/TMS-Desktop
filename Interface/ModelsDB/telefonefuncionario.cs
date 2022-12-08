using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class TelefoneFuncionario
    {
        public int ID_telefone { get; set; }
        public int ID_for_funcionario { get; set; }
        public string Telefone { get; set; } = null!;

        public virtual Motorista ID_for_funcionarioNavigation { get; set; } = null!;
    }
}
