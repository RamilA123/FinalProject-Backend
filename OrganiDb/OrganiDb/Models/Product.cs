namespace OrganiDb.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Featured { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
