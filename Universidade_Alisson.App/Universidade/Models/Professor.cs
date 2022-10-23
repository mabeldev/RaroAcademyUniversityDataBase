namespace Universidade.Models
{
    public class Professor : Base
    {
        public Professor(string cpf, string nome, float salario,
                             DateTime dataNascimento, DateTime dataInicio,
                                int? enderecoId, int? departamentoId )
    {
        Cpf = cpf;
        Nome = nome;
        Salario = salario;
        DataNascimento = dataNascimento;
        DataInicio = dataInicio;
        EnderecoId = enderecoId;
        DepartamentoId = departamentoId;
    }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public float Salario { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInicio { get; set; }
        
        //FK
        public int? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public int? DepartamentoId { get; set; }
        public Departamento? Departamento { get; set; }

        //ref
        public ICollection<Oferta>? Ofertas { get; set; }
        public ICollection<Dependente>? Dependentes { get; set; }
    }
}