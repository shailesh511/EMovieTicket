using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMovieTicket.Data.Base
{
    public class EntityBaseRepository<T> : IEntityRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppdbContext _appDbContext;

        public EntityBaseRepository(AppdbContext appdbContext)
        {
            _appDbContext = appdbContext;
        }
        public void Add(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
            _appDbContext.SaveChanges();

        }

        public T Delete(int id)
        {
            var a = _appDbContext.Set<T>().FirstOrDefault(e => e.Id == id);

            EntityEntry entityEntry = _appDbContext.Entry(a);
            entityEntry.State = EntityState.Deleted;
            _appDbContext.SaveChanges();
            return a;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var a = await _appDbContext.Set<T>().ToListAsync();
            return a;
        }

        public T GetByID(int id)
        {
           T a = _appDbContext.Set<T>().FirstOrDefault((e)=> e.Id==id);
            return a;
            
        }

        public T Update(int id, T entity)
        {
            EntityEntry entityEntry = _appDbContext.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            _appDbContext.SaveChanges();

            return entity;
        }
    }
}
