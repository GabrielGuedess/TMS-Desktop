using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class redetransporte
    {
        public int ID_rede { get; set; }
        public string Tipo_rede { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public string Categoria_CNH { get; set; } = null!;
        public string Tipo_veiculo { get; set; } = null!;
    }
}
