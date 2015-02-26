using vazarApp.Models;

namespace Vazar.Models
{
    public class ProductReview
    {
        public int ProductReviewId { set; get; }
        public string Review { set; get; }
        public int Ratings { set; get; }
        public int ProductId { set; get; }
        public int UserId { set; get; }
        public Product Product { set; get; }
        public User User { set; get; }
       

    }
}