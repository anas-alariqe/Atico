namespace Atico_Data.Repositories{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Atico_Shared.Interfaces;

    public class Service_Repository :  IData_Repository{
        private IViewData_set? _data_set;
        public Service_Repository(IViewData_set? data_Set = null){
            _data_set = data_Set;
        }
        public async Task<List<IViewData_set>> GetAllAsync(){
            await Task.Delay(1);
            var _data_set1 = new List<IViewData_set>(){
                new Service("1","","products/Oils.jpg"),
                new Service("2","","products/Battry.jpg"),
                new Service("3","","products/Tires.jpg"),
                new Service("4","","products/GeneisePart.jpg"),
                new Service("5","","products/Solar.png")
            };            
            return _data_set1;
        }

        public Task<List<IViewData_set>> GetAll_Items_InSectionAsync(IViewData_set _Section)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IViewData_set>> GetAll_StarAsync(){
            await Task.Delay(1);

            var _data_set1 = new List<IViewData_set>(){
                new Service("1","","products/Oils.jpg"),
                new Service("2","","products/Battry.jpg"),
                new Service("3","","products/Tires.jpg"),
                new Service("4","","products/GeneisePart.jpg"),
                new Service("5","","products/Solar.png")
            };
            return _data_set1;
        }
    }
}