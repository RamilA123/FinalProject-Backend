namespace OrganiDb.Models
{
    public class Assistance : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AboutId { get; set; }
        public About_ About { get; set; }
    }
}
