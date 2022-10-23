using Universidade.Enuns;
namespace Universidade.Models

{
    public class Curso : Base
    {
        public Curso(string nome, Turnos turno, TimeSpan duracao, string tipoCurso, int? departamentoId)
    {
        Nome = nome;
        Turno = turno;
        Duracao = duracao;
        TipoCurso = tipoCurso;
        DepartamentoId = departamentoId;
    }
        public string Nome { get; set; }
        public Turnos Turno { get; set; }
        public TimeSpan Duracao { get; set; }
        public string TipoCurso { get; set; }

        
        //FK
        public int? DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }
    }
}