using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class Marca
    {
        public Marca()
        {
            Modelo = new HashSet<Modelo>();
            Veiculo = new HashSet<Veiculo>();
        }

        public int ID_marca { get; set; }
        public string Nome_marca { get; set; } = null!;

        public virtual ICollection<Modelo> Modelo { get; set; }
        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
