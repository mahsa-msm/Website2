using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class ContactSection
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string BackgroundImage { get; set; }
    }
}
