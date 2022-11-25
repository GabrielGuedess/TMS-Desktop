using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Rota
    {
        public int ID_rota { get; set; }
        public int ID_for_pedido { get; set; }
        public string CEP_partida { get; set; } = null!;
        public string Logradouro_partida { get; set; } = null!;
        public string Numero_partida { get; set; } = null!;
        public string Bairro_partida { get; set; } = null!;
        public string Complemento_partida { get; set; } = null!;
        public string Cidade_partida { get; set; } = null!;
        public string UF_partida { get; set; } = null!;
        public double Distancia_KM { get; set; }
        public double Gasto_combustivel_reais { get; set; }
        public double Gasto_pedagio_reais { get; set; }
        public DateOnly Data_inicio { get; set; }
        public DateOnly Data_fim { get; set; }

        public virtual Pedidocliente ID_for_pedidoNavigation { get; set; } = null!;
    }
}
