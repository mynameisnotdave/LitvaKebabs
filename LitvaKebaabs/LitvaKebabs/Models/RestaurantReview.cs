namespace LitvaKebabs.Models
{
    public class RestaurantReview
    {
        public int RestaurantReviewId { get; set; }
        public DateTime RestaurantReviewDate { get; set; }
        public string RestaurantReviewText { get; set; }
        public decimal RestaurantReviewRating { get; set; }

        // FK to Customer
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
