using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class TelefoneCliente
    {
        public int ID_telefone { get; set; }
        public int ID_for_cliente { get; set; }
        public string Telefone { get; set; } = null!;

        public virtual Cliente ID_for_clienteNavigation { get; set; } = null!;
    }
}
