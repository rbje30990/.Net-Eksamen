using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eksamensprojekt_Rema1000.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Kilograms { get; set; }
        public int QuantityInPackage { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        
        // Navigation properties
        public int CategoryId { get; set; }
        public Category Category { get; set; }        
        
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}