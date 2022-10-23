using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class AlunoRepositorio : BaseRepositorio<Aluno>, IAlunoRepositorio
    {
        public AlunoRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}