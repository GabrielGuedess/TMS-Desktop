using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class TarifasETaxas
    {
        public int ID_ta { get; set; }
        public string Descricao { get; set; } = null!;
        public string Nome_empresa { get; set; } = null!;
        public string Tarifa_ou_taxa { get; set; } = null!;
    }
}
