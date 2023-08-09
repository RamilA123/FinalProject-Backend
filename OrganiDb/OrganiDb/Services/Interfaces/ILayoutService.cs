using OrganiDb.ViewModels;

namespace OrganiDb.Services.Interfaces
{
    public interface ILayoutService
    {
        Task<LayoutVM> GetAllDatasAsync();
    }
}
