namespace Atico_Data.Repositories{
    using Atico_Shared.Interfaces;

    public class Cartification_Repos :IData_Repository {
        private IViewData_set? _data;

        private List<IViewData_set>? _data_set;
        public Cartification_Repos(IViewData_set? data = null){
            _data = data;
            _data_set = new List<IViewData_set>();
        }
       public async Task<List<IViewData_set>> GetAllAsync(){
        await Task.Delay(1);
        _data_set =  new List<IViewData_set>(){
            new Cartification(1,"Cartific-1","About_Assets//Cartific-1.jpg",""),
            new Cartification(2,"Cartific-2","About_Assets//Cartific-2.jpg",""),
            new Cartification(3,"Cartific-3","About_Assets//Cartific-3.jpg","")
        };
        return _data_set;
    }

        public Task<List<IViewData_set>> GetAll_Items_InSectionAsync(IViewData_set _Section)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IViewData_set>> GetAll_StarAsync(){
        await Task.Delay(1);

        List<IViewData_set> view_Obj =  new List<IViewData_set>(){
            new Cartification(1,"Cartific-1","About_Assets//Cartific-1.jpg",""),
            new Cartification(2,"Cartific-2","About_Assets//Cartific-2.jpg",""),
            new Cartification(3,"Cartific-3","About_Assets//Cartific-3.jpg","")
        };
        return view_Obj ;
    }
    }
}