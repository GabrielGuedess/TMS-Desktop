using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class celularmotoristaterceiro
    {
        public int ID_celular { get; set; }
        public int ID_for_motorista { get; set; }
        public string Celular { get; set; } = null!;

        public virtual motoristaterceiro ID_for_motoristaNavigation { get; set; } = null!;
    }
}
