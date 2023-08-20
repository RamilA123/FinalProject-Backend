namespace OrganiDb.Areas.Admin.ViewModels.Product
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Discount { get; set; }
        public string Brand { get; set; }
        public int Rating { get; set; }
        public string Tag { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
    }
}

