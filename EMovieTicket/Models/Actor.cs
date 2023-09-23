using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMovieTicket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture URL")]
        [Required(ErrorMessage ="Profile Picture is required!!")]
        public  string ProfilePictureURL { get; set; }

        [Required(ErrorMessage ="Please enter your full name!!")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Name should be greater than 3")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="This Field is required!!")]
        [StringLength(100,MinimumLength =10, ErrorMessage ="Bio must contains 10 characters")]
        public string Bio { get; set; }

        //relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
