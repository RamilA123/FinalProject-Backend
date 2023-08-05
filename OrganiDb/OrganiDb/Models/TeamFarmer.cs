namespace OrganiDb.Models
{
    public class TeamFarmer : BaseEntity
    {
        public string Image { get; set; }
        public string FullName { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public ICollection<TeamFarmerSocialMedia> TeamFarmerSocialMedias { get; set; }
    }
}
