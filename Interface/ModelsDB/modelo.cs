using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class modelo
    {
        public modelo()
        {
            carroceria = new HashSet<carroceria>();
        }

        public int ID_modelo { get; set; }
        public string Nome { get; set; } = null!;
        public int ID_for_marca { get; set; }
        public double Massa_modelo { get; set; }
        public uint Eixo_modelo { get; set; }

        public virtual marca ID_for_marcaNavigation { get; set; } = null!;
        public virtual ICollection<carroceria> carroceria { get; set; }
    }
}
