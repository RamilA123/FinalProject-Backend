namespace OrganiDb.Models
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeamFarmer> TeamFarmers { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
