namespace OrganiDb.Models
{
    public class SocialMedia : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeamFarmerSocialMedia> TeamFarmerSocialMedias { get; set; }
    }
}
