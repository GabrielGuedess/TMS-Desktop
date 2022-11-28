using System;
using System.Collections.Generic;

namespace Interface.ModelsDB
{
    public partial class PessoaJuridica
    {
        public int ID_usuario { get; set; }
        public string Nome_fantasia { get; set; } = null!;
        public string CNPJ { get; set; } = null!;
        public string Inscricao_estadual { get; set; } = null!;
        public string Razao_social { get; set; } = null!;
        public string CEP { get; set; } = null!;
        public string Logradouro { get; set; } = null!;
        public string Numero_endereco { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Complemento_endereco { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string UF { get; set; } = null!;
        public string Telefone { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
