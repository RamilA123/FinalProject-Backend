namespace OrganiDb.ViewModels.Wishlist
{
    public class WishlistDetailVM
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public byte Percent { get; set; }
    }
}
