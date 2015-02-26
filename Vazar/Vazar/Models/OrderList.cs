using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vazarApp.Models
{
    public class OrderList
    {
        public int Id { set; get; }
        public int UserId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        //public double Price { set; get; }
        public User User { set; get; }
      
        public Product Product { set; get; }
       
    }
}