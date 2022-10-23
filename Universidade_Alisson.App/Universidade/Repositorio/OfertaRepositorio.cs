using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class OfertaRepositorio : BaseRepositorio<Oferta>, IOfertaRepositorio
    {
        public OfertaRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}