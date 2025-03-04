using Atico_Services.Services.Plugins;
using Atico_Shared.Interfaces;
using Atico_Data.Repositories;


public class ViewData_Repository : IViewData_Repository
{
    private readonly IData_Repository? _repository;
    public ViewData_Repository(IData_Repository? Data_Repository = null)
    {
        _repository = Data_Repository;
    }

    public async Task<List<IViewData_set>> GetAllAsync(){
        if(_repository is not null)
            return await _repository.GetAllAsync();
        else
            return new();
    }
    public async Task<List<IViewData_set>> GetAll_StarAsync(){
         if(_repository is not null)
            return await _repository.GetAll_StarAsync();
        else
            return new();
    }
    public async Task<List<IViewData_set>> GetAll_Items_InSectionAsync(IViewData_set viewData_Set){
         if(_repository is not null)
            return await _repository.GetAll_Items_InSectionAsync(viewData_Set);
        else
            return new();
    }
}
