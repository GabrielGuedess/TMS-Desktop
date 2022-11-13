using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class veiculo
    {
        public veiculo()
        {
            processopedido = new HashSet<processopedido>();
        }

        public int ID_veiculo { get; set; }
        public string Placa { get; set; } = null!;
        public int ID_for_marca { get; set; }
        public short Ano_fabricacao { get; set; }
        public string? Cor { get; set; }
        public string Cod_RENAVAM { get; set; } = null!;
        public string Cod_RNTRC { get; set; } = null!;
        public DateOnly Vencimento_RNTRC { get; set; }
        public string Cod_CIOT { get; set; } = null!;
        public string Disponibilidade { get; set; } = null!;

        public virtual marca ID_for_marcaNavigation { get; set; } = null!;
        public virtual ICollection<processopedido> processopedido { get; set; }
    }
}
