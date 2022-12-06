using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Cliente
    {
        public Cliente()
        {
            CelularCliente = new HashSet<CelularCliente>();
            EmailCliente = new HashSet<EmailCliente>();
            Mercadoria = new HashSet<Mercadoria>();
            PedidoCliente = new HashSet<PedidoCliente>();
            TelefoneCliente = new HashSet<TelefoneCliente>();
        }

        public int ID_cliente { get; set; }
        public string Tipo_cliente { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public string Logradouro { get; set; } = null!;
        public string Numero_endereco { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Complemento_endereco { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string UF { get; set; } = null!;

        public virtual ClienteFisico? ClienteFisico { get; set; }
        public virtual ClienteJuridico? ClienteJuridico { get; set; }
        public virtual ICollection<CelularCliente> CelularCliente { get; set; }
        public virtual ICollection<EmailCliente> EmailCliente { get; set; }
        public virtual ICollection<Mercadoria> Mercadoria { get; set; }
        public virtual ICollection<PedidoCliente> PedidoCliente { get; set; }
        public virtual ICollection<TelefoneCliente> TelefoneCliente { get; set; }
    }
}
