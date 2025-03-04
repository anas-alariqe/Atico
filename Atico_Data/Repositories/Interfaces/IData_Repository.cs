
using Atico_Shared.Interfaces;

public interface IData_Repository
{
    Task<List<IViewData_set>> GetAllAsync();
    Task<List<IViewData_set>> GetAll_StarAsync();
    Task<List<IViewData_set>> GetAll_Items_InSectionAsync(IViewData_set _Section);
}