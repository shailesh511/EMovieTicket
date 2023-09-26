using EMovieTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMovieTicket.Data.Services
{
    public class ActorsService : IActorsService
    { 

        private readonly AppdbContext _appdbContext;
        public ActorsService(AppdbContext appdbContext)
        {
            _appdbContext = appdbContext; 
        }
        void IActorsService.Add(Actor actor)
        {
            _appdbContext.Actors.Add(actor);
            _appdbContext.SaveChanges();
        }

        Actor IActorsService.Delete(int id)
        {
            Actor actor = _appdbContext.Actors.FirstOrDefault((a)=>a.Id== id);
            var a =  _appdbContext.Actors.Remove(actor);
            _appdbContext.SaveChanges();
            return actor;

        }

         async Task<IEnumerable<Actor>> IActorsService.GetAll()
        {
           var a = await _appdbContext.Actors.ToListAsync();
            return a;
        }

        Actor IActorsService.GetByID(int id)
        {
          var actorDetails = _appdbContext.Actors.FirstOrDefault(a => a.Id == id);
            return actorDetails;
        }

        Actor IActorsService.Update(int id, Actor newActor)
        {
            _appdbContext.Actors.Update(newActor);

            _appdbContext.SaveChanges();
            return newActor;
        }

         
    }
}
