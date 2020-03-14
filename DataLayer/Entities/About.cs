using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Titel { get; set; }
        [Required]
        public string Text { get; set; }

    }
}
