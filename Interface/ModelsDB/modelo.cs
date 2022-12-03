using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Modelo
    {
        public Modelo()
        {
            Veiculo = new HashSet<Veiculo>();
        }

        public int ID_modelo { get; set; }
        public string Nome { get; set; } = null!;
        public int ID_for_marca { get; set; }
        public int ID_for_tipo_veiculo { get; set; }
        public double Massa_modelo { get; set; }
        public uint Eixo_modelo { get; set; }

        public virtual Marca ID_for_marcaNavigation { get; set; } = null!;
        public virtual TipoVeiculo ID_for_tipo_veiculoNavigation { get; set; } = null!;
        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
