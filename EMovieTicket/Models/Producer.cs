﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMovieTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relatiosnships
        public List<Movie>Movies { get; set; }
    }
}