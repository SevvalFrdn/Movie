using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movie.Model.Models
{
    public class Director
    {
        [Key]
        public int DirectorID { get; set; }
        [Required]
        public string DirectorName { get; set; }
    }
}
