using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movie.Model.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        [Required]
        public string GenreName { get; set; }
    }
}
