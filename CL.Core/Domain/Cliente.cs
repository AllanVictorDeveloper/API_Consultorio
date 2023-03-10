namespace CL.Core.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }

        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }

        public DateTime Criacao { get; set; }
        public DateTime? UltimaAtualizacao { get; set; }
    }
}