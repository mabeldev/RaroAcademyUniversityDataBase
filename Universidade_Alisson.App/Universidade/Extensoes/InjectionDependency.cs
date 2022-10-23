using Universidade.Interfaces;
using Universidade.Repositorio;
using Universidade.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Universidade.Extensoes
{
    public static class InjectionDependency
    {
        public static ServiceProvider Provider()
        {

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IAlunoRepositorio, AlunoRepositorio>();
            serviceCollection.AddSingleton<ICursoDisciplinaRepositorio, CursoDisciplinaRepositorio>();
            serviceCollection.AddSingleton<ICursoRepositorio, CursoRepositorio>();
            serviceCollection.AddSingleton<IDepartamentoRepositorio, DepartamentoRepositorio>();
            serviceCollection.AddSingleton<IDependenteRepositorio, DependenteRepositorio>();
            serviceCollection.AddSingleton<IDisciplinaRepositorio, DisciplinaRepositorio>();
            serviceCollection.AddSingleton<IEnderecoRepositorio, EnderecoRepositorio>();
            serviceCollection.AddSingleton<IOfertaRepositorio, OfertaRepositorio>();
            serviceCollection.AddSingleton<IProfessorRepositorio, ProfessorRepositorio>();
            serviceCollection.AddSingleton<ITitulacaoRepositorio, TitulacaoRepositorio>();
        
            serviceCollection.AddDbContext<UniversidadeContext>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}