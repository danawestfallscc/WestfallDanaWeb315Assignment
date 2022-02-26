using System;
using System.ComponentModel.DataAnnotations;

namespace InBloom.Models
{
    public class Flower
    {
        public int ID { get; set; }
        public string Type { get; set; }

        public string LatinName { get; set; }
        public string Colour { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }
        
    }
}