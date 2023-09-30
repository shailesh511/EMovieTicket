using EMovieTicket.Data.Base;
using EMovieTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMovieTicket.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actor>, IActorsService
    { 

        public ActorsService(AppdbContext appdbContext): base(appdbContext) { }
       
    }
}
