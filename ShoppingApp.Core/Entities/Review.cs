﻿using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Core.Entities
{
    public class Review
    {
        public int Id { get; set; }

        [MaxLength(255), Required]
        public string Rating { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Comment { get; set; } = string.Empty;

        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
    }
}