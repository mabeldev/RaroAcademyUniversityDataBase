namespace Universidade.Models
{
    public class Aluno : Base
    {
        public Aluno(int matricula, string nome, DateTime dataNascimento, int? enderecoId, int? cursoId )
    {
        Matricula = matricula;
        Nome = nome;
        DataNascimento = dataNascimento;
        EnderecoId = enderecoId;
        CursoId = cursoId;
    }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        
        //FK
        public int? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public int? CursoId { get; set; }
        public Curso? Curso { get; set; }

        //ref
        public ICollection<Oferta>? Ofertas { get; set; }
    }
}