using System;
using System.Collections.Generic;

namespace Interface
{
    public partial class Usuario
    {
        public int ID_usuario { get; set; }
        public string Nome { get; set; } = null!;
        public string User_name { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
