namespace OrganiDb.Models
{
    public class Blog_ : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<BlogReview> BlogReviews { get; set; }
    }
}
