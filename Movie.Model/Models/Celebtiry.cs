using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movie.Model.Models
{
    public class Celebtiry
    {
        [Key]
        public int CelebrityID { get; set; }
        [Required,StringLength(40)]
        public string CelebrityName { get; set; }
        public string CelebrityActorORActress { get; set; }
        public string CelebrityYearofBirth { get; set; }
        [Required, StringLength(20)]
        public string CelebrityCountry { get; set; }
        public string CelebrityMovies { get; set; }

    }
}
