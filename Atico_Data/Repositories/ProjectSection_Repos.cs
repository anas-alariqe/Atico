namespace Atico_Data.Repositories{
    using Atico_Shared.Interfaces;

    public class ProjectSection_Repos :IData_Repository {
        private IViewData_set? _data;

        private List<IViewData_set>? _data_set;
        public ProjectSection_Repos(IViewData_set? data = null){
            _data = data;
            _data_set = new List<IViewData_set>();
        }
       public async Task<List<IViewData_set>> GetAllAsync(){
        await Task.Delay(1);
        _data_set =  new List<IViewData_set>(){
            new ViewObject(1,"UN","About_Assets//Client-1.jpg",""),
            new ViewObject(2,"MTN","About_Assets//Client-2.jpg",""),
            new ViewObject(3,"Yemen Mobile","About_Assets//Client-3.jpg",""),
            new ViewObject(4,"OXFAM","About_Assets//Client-4.jpg",""),
            new ViewObject(5,"IBY","About_Assets//Client-5.jpg",""),
            new ViewObject(6,"World-Health-Org","About_Assets//Client-6.jpg","")
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
            new ViewObject(1,"UN","About_Assets//Client-1.jpg",""),
            new ViewObject(2,"MTN","About_Assets//Client-2.jpg",""),
            new ViewObject(3,"Yemen Mobile","About_Assets//Client-3.jpg",""),
            new ViewObject(4,"OXFAM","About_Assets//Client-4.jpg",""),
            new ViewObject(5,"IBY","About_Assets//Client-5.jpg",""),
            new ViewObject(6,"World-Health-Org","About_Assets//Client-6.jpg","")
        };
        return view_Obj ;
    }
    }
}