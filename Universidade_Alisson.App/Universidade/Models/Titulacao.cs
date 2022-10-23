namespace Universidade.Models
{
    public class Titulacao : Base
    {
        public Titulacao(string grau, string curso, string instituicao, int? professorId)
        {
            Grau = grau;
            Curso = curso;
            Instituicao = instituicao;
            ProfessorId = professorId;
        }
        
        public string Grau { get; set; }
        public string Curso { get; set; }
        public string Instituicao { get; set; }
        
        //FK
        public int? ProfessorId { get; set; }
        public Professor? Professor { get; set; }
    }
}