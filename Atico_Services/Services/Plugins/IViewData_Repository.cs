
using Atico_Shared.Interfaces;

namespace Atico_Services.Services.Plugins{

    public interface IViewData_Repository{
        Task<List<IViewData_set>> GetAllAsync();
        Task<List<IViewData_set>> GetAll_StarAsync();
        Task<List<IViewData_set>> GetAll_Items_InSectionAsync(IViewData_set viewData_Set);
        

    
    }
}