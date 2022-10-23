using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class DependenteRepositorio : BaseRepositorio<Dependente>, IDependenteRepositorio
    {
        public DependenteRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}