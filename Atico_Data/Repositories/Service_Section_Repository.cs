namespace Atico_Data.Repositories{
    using Atico_Shared.Interfaces;

    public class Service_Section_Repository :IData_Repository {
        private IViewData_set? _data;

        private List<IViewData_set>? _data_set;
        public Service_Section_Repository(IViewData_set? data = null){
            _data = data;
            _data_set = new List<IViewData_set>();
        }
       public async Task<List<IViewData_set>> GetAllAsync(){
        await Task.Delay(1);
        _data_set =  new List<IViewData_set>(){
            new Service_Section(1,"Oil Derivatives Services","Services_Assets//icons services-01.svg",""),
            new Service_Section(2,"Logistics Transportation","Services_Assets//icons services-02.svg",""),
            new Service_Section(3,"Clearing & Forwording","Services_Assets//icons services-03.svg",""),
            new Service_Section(4,"Transportation Services","Services_Assets//icons services-04.svg",""),
            new Service_Section(5,"Procurement Services","Services_Assets//icons services-05.svg",""),
            new Service_Section(6,"Construction & Constructing Services","Services_Assets//icons services-06.svg",""),
            new Service_Section(7,"Rental Services","Services_Assets//icons services-07.svg","")
            
        };
        return _data_set;
    }
    public async Task<List<IViewData_set>> GetAll_StarAsync(){
        await Task.Delay(1);

        List<IViewData_set> view_Obj =  new List<IViewData_set>(){
            new Service_Section(1,"Oil Derivatives Services","Services_Assets//icons services-01.svg",new List<Service> {
                new Service("1","Importing of petroleum derivatives","Services_Assets//Service_Icon_001.jpg",".//Service//"+"1"),
                new Service("2","Fuel supplies and delivery","Services_Assets//Service_Icon_002.jpg",".//Service//"+"2"),
                new Service("3","Site & Fuel station","Services_Assets//Service_Icon_003.jpg",".//Service//"+"3")
            
            }),
            new Service_Section(2,"Logistics Transportation","Services_Assets//icons services-02.svg",new List<Service> {
                new Service("4","General Oilfield services","Services_Assets//Service_Icon_004.jpg",".//Service//"+"4")
            
            }),
            new Service_Section(3,"Clearing & Forwording","Services_Assets//icons services-03.svg",new List<Service> {
                new Service("5","Crude Oil Hauling","Services_Assets//Service_Icon_005.jpg",".//Service//"+"5")
            
            }),
            new Service_Section(4,"Transportation Services","Services_Assets//icons services-04.svg",new List<Service> {
                new Service("6","Site & Fuel station","Services_Assets//Service_Icon_005.jpg",".//Service//"+"6")
            }),
            new Service_Section(5,"Procurement Services","Services_Assets//icons services-05.svg",new List<Service> {
                new Service("7","Site & Fuel station","Services_Assets//Service_Icon_005.jpg",".//Service//"+"7"),
                new Service("8","Site & Fuel station","Services_Assets//Service_Icon_005.jpg",".//Service//"+"7"),
                new Service("9","Site & Fuel station","Services_Assets//Service_Icon_005.jpg",".//Service//"+"7")

            }),
            new Service_Section(6,"Construction & Constructing Services","Services_Assets//icons services-06.svg",""),
            new Service_Section(7,"Rental Services","Services_Assets//icons services-07.svg","")
        };
        return view_Obj ;
    }
    public async Task<List<IViewData_set>> GetAll_Items_InSectionAsync(IViewData_set _Section){
        await Task.Delay(1);

        List<IViewData_set> view_Obj =  new List<IViewData_set>();
        foreach(var srv in ((Service_Section)_Section).Services){
            view_Obj.Add(srv);
        }
        return view_Obj ;
    }
    
    }
}