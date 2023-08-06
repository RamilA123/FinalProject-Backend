using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
    }
}
