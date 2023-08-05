using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface ITeamFarmerService
    {
        Task<List<TeamFarmer>> GetAllWithIncludesAsync();
    }
}
