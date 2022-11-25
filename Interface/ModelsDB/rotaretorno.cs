﻿using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Rotaretorno
    {
        public Rotaretorno()
        {
            Processopedido = new HashSet<Processopedido>();
        }

        public int ID_retorno { get; set; }
        public int ID_for_rota { get; set; }
        public int ID_for_pedido { get; set; }
        public double Distancia_KM { get; set; }
        public double Gasto_combustivel_reais { get; set; }
        public double Gasto_pedagio_reais { get; set; }
        public DateOnly Data_inicio { get; set; }
        public DateOnly Data_fim { get; set; }

        public virtual Pedidocliente ID_for_pedidoNavigation { get; set; } = null!;
        public virtual ICollection<Processopedido> Processopedido { get; set; }
    }
}