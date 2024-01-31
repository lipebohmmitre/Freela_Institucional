﻿namespace AcademicApplication.Data.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; } = string.Empty;
        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
    }
}
