using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Carroceria
    {
        public Carroceria()
        {
            ID_for_tipo_veiculo = new HashSet<TipoVeiculo>();
            ID_for_veiculo = new HashSet<Veiculo>();
        }

        public int ID_carroceria { get; set; }
        public string Descricao_carroceira { get; set; } = null!;
        public byte Eixo_carroceria { get; set; }
        public double Massa_carroceria { get; set; }
        public double Capacidade_volumetrica { get; set; }

        public virtual ICollection<TipoVeiculo> ID_for_tipo_veiculo { get; set; }
        public virtual ICollection<Veiculo> ID_for_veiculo { get; set; }
    }
}
