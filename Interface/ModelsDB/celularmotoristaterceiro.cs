using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class CelularMotoristaTerceiro
    {
        public int ID_celular { get; set; }
        public int ID_for_motorista { get; set; }
        public string Celular { get; set; } = null!;

        public virtual MotoristaTerceiro ID_for_motoristaNavigation { get; set; } = null!;
    }
}
