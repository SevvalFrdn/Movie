using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

namespace Movie.Model.Models
{
    public class Moviee
    {
        [Key]
        public int MovieID { get; set; }
        [Required, StringLength(50)]
        public string MovieName { get; set; }
        [Required]
        public string MovieReview { get; set; }
        [Required, StringLength(40)]
        public string MovieDirector { get; set; }
        public string MovieWriter { get; set; }
        public string MovieStars { get; set; }
        public string MovieGenres { get; set; }
        public string MovieReleaseDate { get; set; }
        public string MovieRuntime { get; set; }
        [ForeignKey("Studio")]
        public int StudioID { get; set; }
        public virtual Studio Studio { get; set; }




    }
}
