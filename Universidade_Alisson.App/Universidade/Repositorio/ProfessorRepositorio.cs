using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class ProfessorRepositorio : BaseRepositorio<Professor>, IProfessorRepositorio
    {
        public ProfessorRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}