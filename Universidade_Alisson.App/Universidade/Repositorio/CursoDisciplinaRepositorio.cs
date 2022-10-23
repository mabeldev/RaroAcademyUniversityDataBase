using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class CursoDisciplinaRepositorio : BaseRepositorio<CursoDisciplina>, ICursoDisciplinaRepositorio
    {
        public CursoDisciplinaRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}