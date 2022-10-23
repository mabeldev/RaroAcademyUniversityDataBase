using System.Linq.Expressions;
using Universidade.Models;

namespace Universidade.Interfaces
{
    public interface IBaseRepositorio<T> where T : class
    {
        Task AdicionarAsync (T item);
        Task DeletarAsync (T item);
        Task AlterarAsync (T item);
        Task<T> BuscarPorId(int id);
        Task<List<T>> BuscarTodos();
    }
}