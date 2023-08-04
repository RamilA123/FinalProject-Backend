using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OrganiDb.Models;

namespace OrganiDb.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerInfo> BannerInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Banner>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<BannerInfo>().HasQueryFilter(m => !m.SoftDelete);

            modelBuilder.Entity<Banner>().HasData(

              new Banner
              {
                  Id = 1,
                  Image = "background2.png"
              },
              new Banner
              {
                  Id = 2,
                  Image = "banner1.png"
              },
              new Banner
              {
                  Id = 3,
                  Image = "banner2.png"
              },
              new Banner
              {
                  Id = 4,
                  Image = "banner4.png"
              },
              new Banner
              {
                  Id = 5,
                  Image = "banner5.png"
              },
              new Banner
              {
                  Id = 6,
                  Image = "banner3.jpg"
              },
              new Banner
              {
                  Id = 7,
                  Image = "banner6.jpg"
              },
              new Banner
              {
                  Id = 8,
                  Image = "banner7.webp"
              },
              new Banner
              {
                  Id = 9,
                  Image = "banner8.png"
              },
              new Banner
              {
                  Id = 10,
                  Image = "banner9.jpg"
              },
              new Banner
              {
                  Id = 11,
                  Image = "banner11.png"
              },
              new Banner
              {
                  Id = 12,
                  Image = "banner10.webp"
              }
                );
        }
    
    }
}
