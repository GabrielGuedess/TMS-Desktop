using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class celularcliente
    {
        public int ID_celular { get; set; }
        public int ID_for_cliente { get; set; }
        public string Celular { get; set; } = null!;

        public virtual cliente ID_for_clienteNavigation { get; set; } = null!;
    }
}
