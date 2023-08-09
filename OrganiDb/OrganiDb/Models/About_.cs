namespace OrganiDb.Models
{
    public class About_ : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Assistance> Assistances { get; set; }
    }
}
