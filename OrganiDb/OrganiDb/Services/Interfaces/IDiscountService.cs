using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<Discount> GetAsync();
    }
}
