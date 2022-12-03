using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class TipoVeiculo
    {
        public TipoVeiculo()
        {
            Modelo = new HashSet<Modelo>();
            Veiculo = new HashSet<Veiculo>();
            ID_for_carroceria = new HashSet<Carroceria>();
        }

        public int ID_tipo_veiculo { get; set; }
        public string Descricao { get; set; } = null!;
        public string Possui_carroceria { get; set; } = null!;

        public virtual ICollection<Modelo> Modelo { get; set; }
        public virtual ICollection<Veiculo> Veiculo { get; set; }

        public virtual ICollection<Carroceria> ID_for_carroceria { get; set; }
    }
}
