﻿using OrganiDb.Models;

namespace OrganiDb.ViewModels.Contact
{
    public class ContactVM
    {
        public List<Banner> Banners { get; set; }
        public List<BannerInfo> BannerInfos { get; set; }
        public LayoutVM Data  { get; set; }
        public List<City> Cities  { get; set; }
    }
}
