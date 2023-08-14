namespace OrganiDb.Responses
{
    public class BasketCountResponse
    {
        public decimal TotalPrice { get; set; }
        public decimal GrandTotalPrice { get; set; }
        public int ProductCount { get; set; }
        public int GrandTotalCount { get; set; }
    }
}
