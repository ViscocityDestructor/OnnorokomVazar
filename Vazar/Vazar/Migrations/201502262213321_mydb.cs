namespace Vazar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mydb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                        Category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.Category_CategoryId);
            
            CreateTable(
                "dbo.ImageForProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubCategoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        Latitude = c.Int(nullable: false),
                        Longitude = c.Int(nullable: false),
                        Address = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(nullable: false),
                        Password = c.String(),
                        MobileNo = c.Int(nullable: false),
                        Role = c.String(),
                        Location_LocationId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Locations", t => t.Location_LocationId)
                .Index(t => t.Location_LocationId);
            
            CreateTable(
                "dbo.OrderLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ProductReviews",
                c => new
                    {
                        ProductReviewId = c.Int(nullable: false, identity: true),
                        Review = c.String(),
                        Ratings = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductReviewId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.WishLists",
                c => new
                    {
                        WishListId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WishListId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WishLists", "UserId", "dbo.Users");
            DropForeignKey("dbo.WishLists", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductReviews", "UserId", "dbo.Users");
            DropForeignKey("dbo.ProductReviews", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderLists", "UserId", "dbo.Users");
            DropForeignKey("dbo.OrderLists", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Users", "Location_LocationId", "dbo.Locations");
            DropForeignKey("dbo.Products", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.ImageForProducts", "ProductId", "dbo.Products");
            DropIndex("dbo.WishLists", new[] { "UserId" });
            DropIndex("dbo.WishLists", new[] { "ProductId" });
            DropIndex("dbo.ProductReviews", new[] { "UserId" });
            DropIndex("dbo.ProductReviews", new[] { "ProductId" });
            DropIndex("dbo.OrderLists", new[] { "UserId" });
            DropIndex("dbo.OrderLists", new[] { "ProductId" });
            DropIndex("dbo.Users", new[] { "Location_LocationId" });
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropIndex("dbo.ImageForProducts", new[] { "ProductId" });
            DropTable("dbo.WishLists");
            DropTable("dbo.ProductReviews");
            DropTable("dbo.OrderLists");
            DropTable("dbo.Users");
            DropTable("dbo.Locations");
            DropTable("dbo.SubCategories");
            DropTable("dbo.ImageForProducts");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
