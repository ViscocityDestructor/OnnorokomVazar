using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vazarApp.Models
{
    public class Product
    {
        
        public int ProductId { set; get; }
        [Required]
        public string Title { set; get; }
        public string ImagePath { set; get; }
        public string Specification { set; get; }
        public string Description { set; get; }
        public int Quantity { set; get; }
        public double Price { set; get; }
        public int CatagoryId { set; get; }
        public int SubCatagoryId { set; get; }
        public Category Category { set; get; }
        public SubCategory SubCategory { set; get; }
        public ICollection<ProductReview> ProductReviews { set; get; }
        public ICollection<WishList> WishLists { set; get; }
        public ICollection<OrderedList> OrderedLists { set; get; } 

    }
}