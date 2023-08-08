namespace OrganiDb.Models
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }
        public ICollection<Blog_> Blogs { get; set; }
    }
}
