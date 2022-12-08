using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class EmailCliente
    {
        public int ID_email { get; set; }
        public int ID_for_cliente { get; set; }
        public string Email { get; set; } = null!;

        public virtual Cliente ID_for_clienteNavigation { get; set; } = null!;
    }
}
