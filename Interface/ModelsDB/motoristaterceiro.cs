using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Motoristaterceiro
    {
        public Motoristaterceiro()
        {
            Celularmotoristaterceiro = new HashSet<Celularmotoristaterceiro>();
            Contratomotoristaterceiro = new HashSet<Contratomotoristaterceiro>();
            Emailmotoristaterceiro = new HashSet<Emailmotoristaterceiro>();
            Telefonemotoristaterceiro = new HashSet<Telefonemotoristaterceiro>();
            Veiculoterceiro = new HashSet<Veiculoterceiro>();
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

        public virtual ICollection<Celularmotoristaterceiro> Celularmotoristaterceiro { get; set; }
        public virtual ICollection<Contratomotoristaterceiro> Contratomotoristaterceiro { get; set; }
        public virtual ICollection<Emailmotoristaterceiro> Emailmotoristaterceiro { get; set; }
        public virtual ICollection<Telefonemotoristaterceiro> Telefonemotoristaterceiro { get; set; }
        public virtual ICollection<Veiculoterceiro> Veiculoterceiro { get; set; }
    }
}
