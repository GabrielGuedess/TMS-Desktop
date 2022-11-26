using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class ClienteFisico
    {
        public int ID_for_cliente { get; set; }
        public string Nome { get; set; } = null!;
        public DateOnly Data_nascimento { get; set; }
        public string Genero { get; set; } = null!;
        public string RG { get; set; } = null!;
        public string CPF { get; set; } = null!;

        public virtual Cliente ID_for_clienteNavigation { get; set; } = null!;
    }
}
