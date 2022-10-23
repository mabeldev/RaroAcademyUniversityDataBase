using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;

namespace Universidade.Repositorio
{
    public class TitulacaoRepositorio : BaseRepositorio<Titulacao>, ITitulacaoRepositorio
    {
        public TitulacaoRepositorio(UniversidadeContext universidadeContext) : base(universidadeContext)
        {
            
        }
    }
}