using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMovieTicket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }


        //Relatiosnships
        public List<Movie> Movies { get; set; }
    }
}
