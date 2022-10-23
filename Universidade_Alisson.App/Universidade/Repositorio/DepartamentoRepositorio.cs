using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class DepartamentoRepositorio : BaseRepositorio<Departamento>, IDepartamentoRepositorio
    {
        public DepartamentoRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}