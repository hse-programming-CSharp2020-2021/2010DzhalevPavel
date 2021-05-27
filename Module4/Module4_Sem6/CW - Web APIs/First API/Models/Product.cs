// Author: Pavel Dzhalev
// Created on 27 05 2021

using System.ComponentModel.DataAnnotations;

namespace First_API
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}