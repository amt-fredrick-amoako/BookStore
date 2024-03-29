﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
