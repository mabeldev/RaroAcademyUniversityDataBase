using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class DisciplinaRepositorio : BaseRepositorio<Disciplina>, IDisciplinaRepositorio
    {
        public DisciplinaRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}