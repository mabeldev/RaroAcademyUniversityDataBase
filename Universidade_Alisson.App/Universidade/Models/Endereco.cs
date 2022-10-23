namespace Universidade.Models
{
    public class Endereco : Base
    {
        public Endereco(string rua, string cidade, string estado, string? complemento)
    {
        Rua = rua;
        Cidade = cidade;
        Estado = estado;
        Complemento = complemento;
    }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string? Complemento { get; set; }
    }
}