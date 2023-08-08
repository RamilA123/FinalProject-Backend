using OrganiDb.Models;

namespace OrganiDb.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllAsync();
    }
}
