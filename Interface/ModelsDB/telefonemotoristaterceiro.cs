using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Telefonemotoristaterceiro
    {
        public int ID_telefone { get; set; }
        public int ID_for_motorista { get; set; }
        public string Telefone { get; set; } = null!;

        public virtual Motoristaterceiro ID_for_motoristaNavigation { get; set; } = null!;
    }
}
