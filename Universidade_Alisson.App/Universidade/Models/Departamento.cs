namespace Universidade.Models
{
    public class Departamento : Base
    {
        public Departamento(string nome, int? enderecoId)
    {
        Nome = nome;
        EnderecoId = enderecoId;
    }
        public string Nome { get; set; }
        
        //FK
        public int? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
    }
}