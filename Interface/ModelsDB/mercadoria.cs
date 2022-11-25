using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Mercadoria
    {
        public int ID_mercadoria { get; set; }
        public int ID_for_pedido { get; set; }
        public int ID_for_cliente { get; set; }
        public string Descricao { get; set; } = null!;
        public double Massa { get; set; }
        public double Volume { get; set; }
        public double Valor { get; set; }

        public virtual Cliente ID_for_clienteNavigation { get; set; } = null!;
        public virtual Pedidocliente ID_for_pedidoNavigation { get; set; } = null!;
    }
}
