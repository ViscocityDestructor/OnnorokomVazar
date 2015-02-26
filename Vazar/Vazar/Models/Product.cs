using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vazar.Models;

namespace vazarApp.Models
{
    public class Product
    {
        
        public int ProductId { set; get; }
        [Required]
        public string Title { set; get; }
      
        public string Description { set; get; }
        public int Quantity { set; get; }
        public double Price { set; get; }
      
        public int SubCategoryId { set; get; }
       
        public SubCategory SubCategory { set; get; }
        public ICollection<ImageForProduct> ImageForProducts { set; get; }

    }
}