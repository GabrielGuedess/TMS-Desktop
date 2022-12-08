using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class ProcessoManutencao
    {
        public ProcessoManutencao()
        {
            Manutencao = new HashSet<Manutencao>();
        }

        public int ID_processo_manutencao { get; set; }
        public string Descricao { get; set; } = null!;
        public string? Classificacao { get; set; }
        public byte Preventivo { get; set; }
        public byte Corretivo { get; set; }

        public virtual ICollection<Manutencao> Manutencao { get; set; }
    }
}
