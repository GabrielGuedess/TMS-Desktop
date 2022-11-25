using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Carroceria
    {
        public int ID_carroceira { get; set; }
        public int ID_for_modelo { get; set; }
        public string Descricao_carroceira { get; set; } = null!;
        public uint Eixo_carroceria { get; set; }
        public double Massa_carroceria { get; set; }
        public double Capacidade_volumetrica { get; set; }
        public double Capacidade_KG { get; set; }

        public virtual Modelo ID_for_modeloNavigation { get; set; } = null!;
    }
}
