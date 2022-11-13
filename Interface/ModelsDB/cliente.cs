using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class cliente
    {
        public cliente()
        {
            celularcliente = new HashSet<celularcliente>();
            emailcliente = new HashSet<emailcliente>();
            mercadoria = new HashSet<mercadoria>();
            pedidocliente = new HashSet<pedidocliente>();
            telefonecliente = new HashSet<telefonecliente>();
        }

        public int ID_cliente { get; set; }
        public string CEP { get; set; } = null!;
        public string Logradouro { get; set; } = null!;
        public string Numero_endereco { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Complemento_endereco { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string UF { get; set; } = null!;

        public virtual clientefisico? clientefisico { get; set; }
        public virtual clientejuridico? clientejuridico { get; set; }
        public virtual ICollection<celularcliente> celularcliente { get; set; }
        public virtual ICollection<emailcliente> emailcliente { get; set; }
        public virtual ICollection<mercadoria> mercadoria { get; set; }
        public virtual ICollection<pedidocliente> pedidocliente { get; set; }
        public virtual ICollection<telefonecliente> telefonecliente { get; set; }
    }
}
