using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class Usuario
    {
        public int ID_usuario { get; set; }
        public string Nome { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Senha { get; set; } = null!;
    }
}
