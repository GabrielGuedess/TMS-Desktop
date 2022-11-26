using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class Motorista
    {
        public Motorista()
        {
            CelularFuncionario = new HashSet<CelularFuncionario>();
            EmailFuncionario = new HashSet<EmailFuncionario>();
            ProcessoPedido = new HashSet<ProcessoPedido>();
            TelefoneFuncionario = new HashSet<TelefoneFuncionario>();
        }

        public int ID_motorista { get; set; }
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

        public virtual ICollection<CelularFuncionario> CelularFuncionario { get; set; }
        public virtual ICollection<EmailFuncionario> EmailFuncionario { get; set; }
        public virtual ICollection<ProcessoPedido> ProcessoPedido { get; set; }
        public virtual ICollection<TelefoneFuncionario> TelefoneFuncionario { get; set; }
    }
}
