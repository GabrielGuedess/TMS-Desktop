using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class marca
    {
        public marca()
        {
            modelo = new HashSet<modelo>();
            veiculo = new HashSet<veiculo>();
        }

        public int ID_marca { get; set; }
        public string Nome_marca { get; set; } = null!;

        public virtual ICollection<modelo> modelo { get; set; }
        public virtual ICollection<veiculo> veiculo { get; set; }
    }
}
