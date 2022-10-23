namespace Universidade.Models
{
    public class Oferta : Base
    {
        public Oferta(string ano, int semestre, decimal nota, decimal frequencia,
                                int? alunoId, int? professorId, int? disciplinaId)
         {
            Ano = ano;
            Semestre = semestre;
            Nota = nota;
            Frequencia = frequencia;
            AlunoId = alunoId;
            ProfessorId = professorId;
            DisciplinaId = disciplinaId;
         }

        public string Ano { get; set; }
        public int Semestre { get; set; }
        public decimal Nota { get; set; }
        public decimal Frequencia { get; set; }
        
        //FK
        public int? AlunoId { get; set; }
        public Aluno? Aluno { get; set; }
        public int? ProfessorId { get; set; }
        public Professor? Professor { get; set; }
        public int? DisciplinaId { get; set; }
        public Disciplina? Disciplina { get; set; }
    }
}