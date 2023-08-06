namespace OrganiDb.Models
{
    public class Slider : BaseEntity
    {
        public string Image { get; set; }
        public string Logo { get; set; }
        public bool Status { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
