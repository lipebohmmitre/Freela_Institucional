namespace AcademicApplication.Data.Entities
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string NomeAluno { get; set; } = string.Empty;
        public string NomeSocialAluno { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string UfRG { get; set; } = string.Empty;
        public string OrgaoExpedidorRg { get; set; } = string.Empty;
        public DateTime DataExpedicaoRg { get; set; }
        public string Nacionalidade { get; set; } = string.Empty;
        public string TituloEleitor { get; set; } = string.Empty;
        public string SessaoTituloEleitor { get; set; } = string.Empty;
        public string ZonaTituloEleitor { get; set; } = string.Empty;
        public string TelefoneAluno { get; set; } = string.Empty;
        public string TelefoneSecundarioAluno { get; set; } = string.Empty;
        public string EstadoNascimentoAluno { get; set; } = string.Empty;
        public string CidadeNascimentoAluno { get; set; } = string.Empty;
        public string EstadoCivil { get; set; } = string.Empty;
        public string EmailAluno { get; set; } = string.Empty;
        public string EmailSecundarioAluno { get; set; } = string.Empty;
        public char SexoAluno { get; set; }
        public string ProfissaoAluno { get; set; } = string.Empty;
        public string NomePaiAluno { get; set; } = string.Empty;
        public string NomeMaeAluno { get; set; } = string.Empty;


        public int EnderecoId { get; set; }
        public virtual Endereco EnderecoAluno { get; set; }

        public int EscolaridadeId { get; set; }
        public virtual Escolaridade Escolaridade { get; set; }

        
    }
}
