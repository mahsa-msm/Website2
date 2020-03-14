using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Name { get; set; }
        public string Date { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ModalId { get; set; }
        [Required]
        public string ModalText { get; set; }
    }
}
