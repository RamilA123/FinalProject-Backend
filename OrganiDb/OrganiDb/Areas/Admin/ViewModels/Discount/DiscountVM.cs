namespace OrganiDb.Areas.Admin.ViewModels.Discount
{
    public class DiscountVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public byte Percent { get; set; }
        public DateTime TargetTime { get; set; }
        public int ProductCount { get; set; }
    }
}
