using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class motoristaterceiro
    {
        public motoristaterceiro()
        {
            celularmotoristaterceiro = new HashSet<celularmotoristaterceiro>();
            contratomotoristaterceiro = new HashSet<contratomotoristaterceiro>();
            emailmotoristaterceiro = new HashSet<emailmotoristaterceiro>();
            telefonemotoristaterceiro = new HashSet<telefonemotoristaterceiro>();
            veiculoterceiro = new HashSet<veiculoterceiro>();
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

        public virtual ICollection<celularmotoristaterceiro> celularmotoristaterceiro { get; set; }
        public virtual ICollection<contratomotoristaterceiro> contratomotoristaterceiro { get; set; }
        public virtual ICollection<emailmotoristaterceiro> emailmotoristaterceiro { get; set; }
        public virtual ICollection<telefonemotoristaterceiro> telefonemotoristaterceiro { get; set; }
        public virtual ICollection<veiculoterceiro> veiculoterceiro { get; set; }
    }
}
