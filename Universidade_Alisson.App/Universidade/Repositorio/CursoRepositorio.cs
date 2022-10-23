using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class CursoRepositorio : BaseRepositorio<Curso>, ICursoRepositorio
    {
        public CursoRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}