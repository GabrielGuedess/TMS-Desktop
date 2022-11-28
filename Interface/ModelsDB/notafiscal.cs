using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class NotaFiscal
    {
        public int ID_nota_fiscal { get; set; }
        public string Chave_acesso { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public string Descricao { get; set; } = null!;
    }
}
