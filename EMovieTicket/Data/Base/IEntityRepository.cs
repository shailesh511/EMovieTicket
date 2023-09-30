using System.Collections.Generic;
using System.Threading.Tasks;

namespace EMovieTicket.Data.Base
{
    public interface IEntityRepository<T> where T:class,IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAll();
        T GetByID(int id);
        void Add(T entity);
        T Update(int id, T entity);
        T Delete(int id);
    }
}
