namespace Universidade.Models
{
    public class Dependente : Base
    {
        public Dependente(string nome, string relacionamento, DateTime dataNascimento, int? professorId)
        {
            Nome = nome;
            Relacionamento = relacionamento;
            DataNascimento = dataNascimento;
            ProfessorId = professorId;
        }
        public string Nome { get; set; }
        public string Relacionamento { get; set; }
        public DateTime DataNascimento { get; set; }
        
        //FK
        public int? ProfessorId { get; set; }
        public Professor? Professor { get; set; }
    }
}