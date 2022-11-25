using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Contratomotoristaterceiro
    {
        public int ID_contrato { get; set; }
        public int ID_for_motorista { get; set; }
        public string Tipo_contrato { get; set; } = null!;
        public DateOnly Inicio_contrato { get; set; }
        public DateOnly Fim_contrato { get; set; }
        public string Situacao_contrato { get; set; } = null!;
        public string Veiculo_proprio { get; set; } = null!;

        public virtual Motoristaterceiro ID_for_motoristaNavigation { get; set; } = null!;
    }
}
