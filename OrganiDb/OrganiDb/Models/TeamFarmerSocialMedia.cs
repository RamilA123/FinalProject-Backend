namespace OrganiDb.Models
{
    public class TeamFarmerSocialMedia
    {
        public int Id { get; set; }
        public int TeamFarmerId { get; set; }
        public TeamFarmer TeamFarmer { get; set; }
        public int SocialMediaId { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}
