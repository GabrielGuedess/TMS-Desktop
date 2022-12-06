using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Manutencao
    {
        public int ID_manutencao { get; set; }
        public int ID_for_empresa { get; set; }
        public string Tipo_manutencao { get; set; } = null!;
        public int ID_for_processo_manutencao { get; set; }
        public DateOnly Data_inicio { get; set; }
        public DateOnly Data_fim { get; set; }
        public double Valor_reais { get; set; }
        public string Detalhamento { get; set; } = null!;

        public virtual PessoaJuridica ID_for_empresaNavigation { get; set; } = null!;
        public virtual ProcessoManutencao ID_for_processo_manutencaoNavigation { get; set; } = null!;
    }
}
