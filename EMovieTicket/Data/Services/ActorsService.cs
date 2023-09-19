using EMovieTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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
            throw new System.NotImplementedException();
        }

        Actor IActorsService.Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Actor> IActorsService.GetAll()
        {
           var a = _appdbContext.Actors.ToList();
            return a;
        }

        Actor IActorsService.GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        Actor IActorsService.Update(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }
    }
}
