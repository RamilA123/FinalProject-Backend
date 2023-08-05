using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> GetAllAsync();
    }
}
