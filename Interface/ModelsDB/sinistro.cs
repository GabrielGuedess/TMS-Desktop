using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class Sinistro
    {
        public int ID_Sinistro { get; set; }
        public string Tipo_sinistro { get; set; } = null!;
        public string Descricao { get; set; } = null!;
    }
}
