namespace LitvaKebabs.Models
{
    public class ProductReview
    {
        public int ProductReviewId { get; set; }
        public DateTime ProductReviewDate { get; set; }
        public string ProductReviewText { get; set; }
        public decimal ProductReviewRating { get; set; }

        // FK to Order
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
