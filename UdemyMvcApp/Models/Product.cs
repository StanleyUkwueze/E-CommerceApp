﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyMvcApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }

        [Display(Name = "Category Type")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
       
    }
}
