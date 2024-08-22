using ControleDeEstoqueProauto.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoqueProauto
{
    internal interface IDal<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T?> GetForAsync(Func<T, bool > func);
        Task<IEnumerable<T>> GetListForAsync(Func<T, bool> func);
    }

    internal class DAL<T>  : IDal<T> where T : class
    {
        private readonly ContextControl _context = new ContextControl();

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T?> GetForAsync(Func<T, bool> func)
        {
            return await Task.Run(() => _context.Set<T>().LastOrDefault(func));
        }

        public async Task<IEnumerable<T>> GetListForAsync(Func<T, bool> func)
        {
            return await Task.Run(() => _context.Set<T>().Where(func).ToList());
        }
    }
}


