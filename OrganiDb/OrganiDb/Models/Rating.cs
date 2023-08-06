namespace OrganiDb.Models
{
    public class Rating : BaseEntity
    {
        public int RatingCount { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
