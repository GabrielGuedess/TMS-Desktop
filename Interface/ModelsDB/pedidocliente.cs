using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class PedidoCliente
    {
        public PedidoCliente()
        {
            Mercadoria = new HashSet<Mercadoria>();
            Rota = new HashSet<Rota>();
            RotaRetorno = new HashSet<RotaRetorno>();
        }

        public int ID_pedido { get; set; }
        public int ID_for_cliente { get; set; }
        public string CEP_destino { get; set; } = null!;
        public string Logradouro_destino { get; set; } = null!;
        public string Numero_destino { get; set; } = null!;
        public string Bairro_destino { get; set; } = null!;
        public string Complemento_endereco { get; set; } = null!;
        public string Cidade_destino { get; set; } = null!;
        public string UF_destino { get; set; } = null!;

        public virtual Cliente ID_for_clienteNavigation { get; set; } = null!;
        public virtual ICollection<Mercadoria> Mercadoria { get; set; }
        public virtual ICollection<Rota> Rota { get; set; }
        public virtual ICollection<RotaRetorno> RotaRetorno { get; set; }
    }
}
