using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vazarApp.Models
{
    public class User
    {
        public int UserId { set; get; }
        public string Name { set; get; }
        
        [Required]
        public string Email { set; get; }
        public string Password { set; get; }
        public int MobileNo { set; get; }
        [Display(Name="Seller/Buyer")]
        public bool IsBuyer { set; get; }
        public int LocationId { set; get; }
        public Location Location { set; get; }
        public ICollection<ProductReview> ProductReviews { set; get; }
        public ICollection<WishList> WishLists { set; get; }
        public ICollection<OrderedList> OrderedLists { set; get; } 
      
        
    }
}