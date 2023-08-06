//Builder Services
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OrganiDb.Data;
using OrganiDb.Helpers;
using OrganiDb.Models;
using OrganiDb.Services;
using OrganiDb.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.Configure<EmailConfigurations>(builder.Configuration.GetSection("EmailConfigurations"));


builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequiredLength = 6;
    opt.Password.RequireDigit = true;
    opt.Password.RequireLowercase = true;
    opt.Password.RequireUppercase = true;
    opt.Password.RequireNonAlphanumeric = true;

    opt.User.RequireUniqueEmail = true;
    opt.SignIn.RequireConfirmedEmail = true;

    opt.Lockout.MaxFailedAccessAttempts = 5;
    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    opt.Lockout.AllowedForNewUsers = true;
});

builder.Services.AddScoped<ISliderService,SliderService>();
builder.Services.AddScoped<IAssistanceService,AssistanceService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ITeamFarmerService,TeamFarmerService>();
builder.Services.AddScoped<ISocialMediaService,SocialMediaService>();
builder.Services.AddScoped<IBannerService,BannerService>();
builder.Services.AddScoped<IBannerInfoService,BannerInfoService>();
builder.Services.AddScoped<IAccountService,AccountService>();
builder.Services.AddScoped<ILayoutService,LayoutService>();
builder.Services.AddScoped<IEmailService,EmailService>();
builder.Services.AddScoped<EmailConfigurations>();



//App Services
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
