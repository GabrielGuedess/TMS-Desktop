using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class telefonemotoristaterceiro
    {
        public int ID_telefone { get; set; }
        public int ID_for_motorista { get; set; }
        public string Telefone { get; set; } = null!;

        public virtual motoristaterceiro ID_for_motoristaNavigation { get; set; } = null!;
    }
}
