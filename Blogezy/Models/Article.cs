using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Blogezy.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:200,MinimumLength = 5)]
        public string HeaderInfo { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        [StringLength(maximumLength: 999, MinimumLength = 5)]
        public string Description { get; set; }

        [Required]
        public DateTime Publishdate { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        public string Category { get; set; }

        [Required]
        [StringLength(maximumLength: 500, MinimumLength = 5)]
        public string Commentary { get; set; }


    }
}