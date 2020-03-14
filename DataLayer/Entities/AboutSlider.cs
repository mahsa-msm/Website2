using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class AboutSlider
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
