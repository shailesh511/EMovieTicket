using EMovieTicket.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EMovieTicket.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetByID(int id);
        void Add(Actor actor);  
        Actor Update(int id, Actor newActor);
        Actor Delete(int id);

    }
}
