using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class EmailMotoristaTerceiro
    {
        public int ID_email { get; set; }
        public int ID_for_motorista { get; set; }
        public string Email { get; set; } = null!;

        public virtual MotoristaTerceiro ID_for_motoristaNavigation { get; set; } = null!;
    }
}
