using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vazarApp.Models
{
    public class WishList
    {
        public int WishListId { set; get; }
        public int UserId { set; get; }
        public int ProductId { set; get; }
        public User User { set; get; }
        public Product Product { set; get; }
       
    }
}