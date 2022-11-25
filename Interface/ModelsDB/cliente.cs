using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Cliente
    {
        public Cliente()
        {
            Celularcliente = new HashSet<Celularcliente>();
            Emailcliente = new HashSet<Emailcliente>();
            Mercadoria = new HashSet<Mercadoria>();
            Pedidocliente = new HashSet<Pedidocliente>();
            Telefonecliente = new HashSet<Telefonecliente>();
        }

        public int ID_cliente { get; set; }
        public string CEP { get; set; } = null!;
        public string Logradouro { get; set; } = null!;
        public string Numero_endereco { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Complemento_endereco { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string UF { get; set; } = null!;

        public virtual Clientefisico? Clientefisico { get; set; }
        public virtual Clientejuridico? clientejuridico { get; set; }
        public virtual ICollection<Celularcliente> Celularcliente { get; set; }
        public virtual ICollection<Emailcliente> Emailcliente { get; set; }
        public virtual ICollection<Mercadoria> Mercadoria { get; set; }
        public virtual ICollection<Pedidocliente> Pedidocliente { get; set; }
        public virtual ICollection<Telefonecliente> Telefonecliente { get; set; }
    }
}
