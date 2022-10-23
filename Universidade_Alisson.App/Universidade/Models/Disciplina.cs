namespace Universidade.Models
{
    public class Disciplina : Base
    {
    public Disciplina(string nome, TimeSpan horas)
    {
        Nome = nome;
        Horas = horas;
    }
        public string Nome { get; set; }
        public TimeSpan Horas { get; set; }

        //ref
        public ICollection<Oferta>? Ofertas { get; set; }
    }
}