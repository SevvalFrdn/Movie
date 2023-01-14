using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movie.Model.Models
{
    public class Studio
    {
        [Key]
        public int StudioID { get; set; }
        [Required]
        public string StudioName { get; set; }
    }
}
