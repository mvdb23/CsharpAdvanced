using CsharpAdvanced23_24.Data;
using Microsoft.EntityFrameworkCore;

namespace CsharpAdvanced23_24.Repositories
{
    public class AirbnbRepository<T> : IAirbnbRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        private readonly CsharpAdvanced23_24Context _myDbContext;
        public AirbnbRepository(CsharpAdvanced23_24Context myDbContext)
        {

            _myDbContext = myDbContext;
            _dbSet = myDbContext.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _myDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _myDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _myDbContext.Entry(entity).State = EntityState.Modified;
            await _myDbContext.SaveChangesAsync();
        }
    }
}
