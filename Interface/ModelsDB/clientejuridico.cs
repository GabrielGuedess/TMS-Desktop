using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class clientejuridico
    {
        public int ID_for_cliente { get; set; }
        public string Nome_fantasia { get; set; } = null!;
        public string CNPJ { get; set; } = null!;
        public string Inscricao_estadual { get; set; } = null!;
        public string Razao_social { get; set; } = null!;

        public virtual cliente ID_for_clienteNavigation { get; set; } = null!;
    }
}
