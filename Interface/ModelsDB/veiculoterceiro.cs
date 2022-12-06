using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class VeiculoTerceiro
    {
        public int ID_veiculo_terceiro { get; set; }
        public int ID_for_motorista { get; set; }
        public string Placa { get; set; } = null!;
        public short Ano_fabricao { get; set; }
        public string Cod_RENAVAM { get; set; } = null!;
        public string Cod_RNTRC { get; set; } = null!;
        public DateOnly Vencimento_RNTRC { get; set; }
        public string Cod_CIOT { get; set; } = null!;
        public string Tipo_veiculo { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string Carroceria { get; set; } = null!;
        public double Massa_modelo { get; set; }
        public sbyte Eixo_modelo { get; set; }
        public double Massa_carroceria { get; set; }
        public sbyte Eixo_carroceria { get; set; }
        public double Capacidade_volumetrica { get; set; }
        public double Capacidade_KG { get; set; }

        public virtual MotoristaTerceiro ID_for_motoristaNavigation { get; set; } = null!;
    }
}
