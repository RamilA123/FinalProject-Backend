namespace OrganiDb.Models
{
    public class BlogReview : BaseEntity
    {
        public string Text { get; set; }
        public int BlogId { get; set; }
        public Blog_ Blog { get; set; }
    }
}
