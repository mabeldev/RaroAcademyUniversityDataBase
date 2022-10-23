using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class EnderecoRepositorio : BaseRepositorio<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}