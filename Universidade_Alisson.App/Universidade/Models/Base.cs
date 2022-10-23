namespace Universidade.Models
{
    public class Base
    {
        public Base()
        {
            Ativo = true;
        }

        public int Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        
    }
    
}