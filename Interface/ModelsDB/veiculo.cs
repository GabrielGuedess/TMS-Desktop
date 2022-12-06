using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            ProcessoPedido = new HashSet<ProcessoPedido>();
            ID_for_carroceria = new HashSet<Carroceria>();
        }

        public int ID_veiculo { get; set; }
        public string Placa { get; set; } = null!;
        public int ID_for_marca { get; set; }
        public int ID_for_modelo { get; set; }
        public int ID_for_tipo_veiculo { get; set; }
        public short Ano_fabricacao { get; set; }
        public string? Cor { get; set; }
        public string Cod_RENAVAM { get; set; } = null!;
        public string Cod_RNTRC { get; set; } = null!;
        public DateOnly Vencimento_RNTRC { get; set; }
        public string Cod_CIOT { get; set; } = null!;

        public virtual Marca ID_for_marcaNavigation { get; set; } = null!;
        public virtual Modelo ID_for_modeloNavigation { get; set; } = null!;
        public virtual TipoVeiculo ID_for_tipo_veiculoNavigation { get; set; } = null!;
        public virtual ICollection<ProcessoPedido> ProcessoPedido { get; set; }

        public virtual ICollection<Carroceria> ID_for_carroceria { get; set; }
    }
}
