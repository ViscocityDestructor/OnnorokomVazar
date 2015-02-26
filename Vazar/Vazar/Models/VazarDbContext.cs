using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using vazarApp.Models;

namespace Vazar.Models
{
    public class VazarDbContext:DbContext
    {
        public VazarDbContext() : base("VazarDb")
        {
            
        }

        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<SubCategory> SubCategories{ set; get; }
        public DbSet<OrderList> OrderLists { set; get; }
        public DbSet<WishList> WishLists { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Location> Locations { set; get; }
        public DbSet<ProductReview> ProductReviews { set; get; }

        public DbSet<ImageForProduct> ImageForProducts { set; get; }

    }
}