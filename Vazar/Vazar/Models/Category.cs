using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vazarApp.Models
{
    public class Category
    {
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public ICollection<SubCategory> SubCategories { set; get; }
        public ICollection<Product> Products { set; get; }
    }
}