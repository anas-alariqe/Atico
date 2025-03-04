namespace Atico_Data.Repositories{
    using Atico_Shared.Interfaces;

    public class Product_Section_Repository  :IData_Repository {
        private IViewData_set? _data;

        private List<IViewData_set>? _data_set;
        public Product_Section_Repository (IViewData_set? data = null){
            _data = data;
            _data_set = new List<IViewData_set>();
        }
       public async Task<List<IViewData_set>> GetAllAsync(){
        await Task.Delay(1);
        _data_set =  new List<IViewData_set>(){
            new Product_Section(1,"Oil Derivatives Services","Services_Assets//icons services-01.svg","#"),
            new Product_Section(2,"Logistics Transportation","Services_Assets//icons services-02.svg","#"),
            new Product_Section(3,"Clearing & Forwording","Services_Assets//icons services-03.svg","#"),
            new Product_Section(4,"Transportation Services","Services_Assets//icons services-04.svg","#"),
            new Product_Section(5,"Procurement Services","Services_Assets//icons services-05.svg","#"),
            new Product_Section(6,"Construction & Constructing Services","Services_Assets//icons services-06.svg","#"),
            new Product_Section(7,"Rental Services","Services_Assets//icons services-07.svg","#")
            
        };
        return _data_set;
    }
    public async Task<List<IViewData_set>> GetAll_StarAsync(){
        await Task.Delay(1);

        List<IViewData_set> view_Obj =  new List<IViewData_set>(){
            new Product_Section(1,"Oil Derivatives Services","Services_Assets//icons services-01.svg","#"),
            new Product_Section(2,"Logistics Transportation","Services_Assets//icons services-02.svg","#"),
            new Product_Section(3,"Clearing & Forwording","Services_Assets//icons services-03.svg","#"),
            new Product_Section(4,"Transportation Services","Services_Assets//icons services-04.svg","#"),
            new Product_Section(5,"Procurement Services","Services_Assets//icons services-05.svg","#"),
            new Product_Section(6,"Construction & Constructing Services","Services_Assets//icons services-06.svg","#"),
            new Product_Section(7,"Rental Services","Services_Assets//icons services-07.svg","#")
        };
        return view_Obj ;
    }
    public async Task<List<IViewData_set>> GetAll_Items_InSectionAsync(IViewData_set _Section){
        await Task.Delay(1);

        List<IViewData_set> view_Obj =  new List<IViewData_set>();
        foreach(var srv in ((Product_Section)_Section).Products){
            view_Obj.Add(srv);
        }
        return view_Obj ;
    }
    }
}