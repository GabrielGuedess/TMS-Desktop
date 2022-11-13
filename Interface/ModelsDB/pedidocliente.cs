using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class pedidocliente
    {
        public pedidocliente()
        {
            mercadoria = new HashSet<mercadoria>();
            rota = new HashSet<rota>();
            rotaretorno = new HashSet<rotaretorno>();
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

        public virtual cliente ID_for_clienteNavigation { get; set; } = null!;
        public virtual ICollection<mercadoria> mercadoria { get; set; }
        public virtual ICollection<rota> rota { get; set; }
        public virtual ICollection<rotaretorno> rotaretorno { get; set; }
    }
}
