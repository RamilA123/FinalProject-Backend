using OrganiDb.Models;

namespace OrganiDb.ViewModels
{
    public class LayoutVM
    {
        public Dictionary<string, string> SettingDatas { get; set; }
        public int BasketCount { get; set; }
        public AppUser User { get; set; }
    }
}
