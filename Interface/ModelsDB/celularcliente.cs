using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class CelularCliente
    {
        public int ID_celular { get; set; }
        public int ID_for_cliente { get; set; }
        public string Celular { get; set; } = null!;

        public virtual Cliente ID_for_clienteNavigation { get; set; } = null!;
    }
}
