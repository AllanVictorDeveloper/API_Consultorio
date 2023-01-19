namespace CL.Core.Shared.ModelViews
{
    public class NovoEndereco
    {
        public int Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

        public string Complemento { get; set; }
    }
}