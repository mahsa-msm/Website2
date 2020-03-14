using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhonNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
    }
}
