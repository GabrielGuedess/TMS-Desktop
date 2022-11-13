using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class telefonecliente
    {
        public int ID_telefone { get; set; }
        public int ID_for_cliente { get; set; }
        public string Telefone { get; set; } = null!;

        public virtual cliente ID_for_clienteNavigation { get; set; } = null!;
    }
}
