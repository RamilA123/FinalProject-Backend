namespace OrganiDb.Models
{
    public class Review : BaseEntity
    {
        public string Text { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
