using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vazarApp.Models;

namespace Vazar.Models
{
    public class ImageForProduct
    {
        public int Id { set; get; }
        public string ImagePath { set; get; }
         public int ProductId { set; get; }
      
         public Product Product { set; get; }
    }
}