namespace Universidade.Models
{
    public class CursoDisciplina : Base
    {
        public CursoDisciplina(int? cursoId, int? disciplinaId )
    {
        CursoId = cursoId;
        DisciplinaId = disciplinaId;
    }
        //FK
        public int? CursoId { get; set; }
        public Curso? Curso { get; set; }
        public int? DisciplinaId { get; set; }
        public Disciplina? Disciplina { get; set; }
    }
}