using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class emailmotoristaterceiro
    {
        public int ID_email { get; set; }
        public int ID_for_motorista { get; set; }
        public string Email { get; set; } = null!;

        public virtual motoristaterceiro ID_for_motoristaNavigation { get; set; } = null!;
    }
}
