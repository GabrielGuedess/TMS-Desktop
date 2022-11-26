using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class MotoristaTerceiro
    {
        public MotoristaTerceiro()
        {
            CelularMotoristaTerceiro = new HashSet<CelularMotoristaTerceiro>();
            ContratoMotoristaTerceiro = new HashSet<ContratoMotoristaTerceiro>();
            EmailMotoristaTerceiro = new HashSet<EmailMotoristaTerceiro>();
            TelefoneMotoristaTerceiro = new HashSet<TelefoneMotoristaTerceiro>();
            VeiculoTerceiro = new HashSet<VeiculoTerceiro>();
        }

        public int ID_motorista_terceiro { get; set; }
        public string Nome { get; set; } = null!;
        public DateOnly Data_nascimento { get; set; }
        public string Genero { get; set; } = null!;
        public string RG { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public string Logradouro { get; set; } = null!;
        public string Numero_endereco { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Complemento_endereco { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string UF { get; set; } = null!;
        public string Numero_CNH { get; set; } = null!;
        public string Categoria_CNH { get; set; } = null!;
        public DateOnly Vencimento_CNH { get; set; }
        public string Curso_MOPP { get; set; } = null!;
        public string Disponibilidade { get; set; } = null!;

        public virtual ICollection<CelularMotoristaTerceiro> CelularMotoristaTerceiro { get; set; }
        public virtual ICollection<ContratoMotoristaTerceiro> ContratoMotoristaTerceiro { get; set; }
        public virtual ICollection<EmailMotoristaTerceiro> EmailMotoristaTerceiro { get; set; }
        public virtual ICollection<TelefoneMotoristaTerceiro> TelefoneMotoristaTerceiro { get; set; }
        public virtual ICollection<VeiculoTerceiro> VeiculoTerceiro { get; set; }
    }
}
