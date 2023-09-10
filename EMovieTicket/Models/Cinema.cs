using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMovieTicket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        //Relatiosnships
        public List<Movie> Movies { get; set; }
    }
}
