using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IAssistanceService
    {
        Task<IEnumerable<Assistance>> GetAllAsync();
    }
}
