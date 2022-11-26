using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class ProcessoPedido
    {
        public int ID_processo { get; set; }
        public int ID_for_rota { get; set; }
        public int ID_for_retorno { get; set; }
        public int ID_for_veiculo { get; set; }
        public int ID_for_motorista { get; set; }
        public double KM_total { get; set; }
        public double Gasto_total { get; set; }
        public DateOnly Data_inicio { get; set; }
        public DateOnly DATA_fim { get; set; }

        public virtual Motorista ID_for_motoristaNavigation { get; set; } = null!;
        public virtual RotaRetorno ID_for_retornoNavigation { get; set; } = null!;
        public virtual Veiculo ID_for_veiculoNavigation { get; set; } = null!;
    }
}
