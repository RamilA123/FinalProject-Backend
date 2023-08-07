namespace OrganiDb.Models
{
    public class Discount : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public byte Percent { get; set; }
        public DateTime TargetTime { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
