using Universidade.Models;
using Universidade.Interfaces;
using Universidade.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Universidade.Repositorio
{
    public abstract class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        private readonly UniversidadeContext _universidadeContext;

        public BaseRepositorio(UniversidadeContext universidadeContext)
        {
            _universidadeContext = universidadeContext;
        }

        public async Task AdicionarAsync (T item)
        {
            await _universidadeContext.Set<T>().AddAsync(item);
            await _universidadeContext.SaveChangesAsync();
        }
        public async Task DeletarAsync (T item)
        {
            _universidadeContext.Entry(item).State = EntityState.Modified;
            await _universidadeContext.SaveChangesAsync();
        }
        public async Task AlterarAsync (T item)
        {
            _universidadeContext.Entry(item).State = EntityState.Modified;
            await _universidadeContext.SaveChangesAsync();
        }
        public async Task<T> BuscarPorId(int id)
        {
            return await _universidadeContext.Set<T>().FindAsync(id);
        }
        public async Task<List<T>> BuscarTodos()
        {
            return await _universidadeContext.Set<T>().ToListAsync();
        }
        
    }
}