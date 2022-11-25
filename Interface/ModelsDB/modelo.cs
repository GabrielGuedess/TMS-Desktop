using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Modelo
    {
        public Modelo()
        {
            Carroceria = new HashSet<Carroceria>();
        }

        public int ID_modelo { get; set; }
        public string Nome { get; set; } = null!;
        public int ID_for_marca { get; set; }
        public double Massa_modelo { get; set; }
        public uint Eixo_modelo { get; set; }

        public virtual Marca ID_for_marcaNavigation { get; set; } = null!;
        public virtual ICollection<Carroceria> Carroceria { get; set; }
    }
}
