namespace Atico_Data.Repositories{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Atico_Shared.Interfaces;

    public class Product_Repository :  IData_Repository{
        private List<IViewData_set>? _data_set;
        public Product_Repository(List<IViewData_set>? data_Set = null){
            _data_set = data_Set;
        }
        public async Task<List<IViewData_set>> GetAllAsync(){
            await Task.Delay(1);
            _data_set = new List<IViewData_set>(){
                new Product(1,"Oils","products/Oils.jpg"),
                new Product(2,"Battry","products/Battry.jpg"),
                new Product(3,"Tires","products/Tires.jpg"),
                new Product(4,"Spare Parts","products/GeneisePart.jpg"),
                new Product(5,"Solar panels","products/Solar.png")
            };            
            return _data_set;
        }

        public Task<List<IViewData_set>> GetAll_Items_InSectionAsync(IViewData_set _Section)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IViewData_set>> GetAll_StarAsync(){
            await Task.Delay(1);

            _data_set = new List<IViewData_set>(){
                new Product(1,"Oils","products/Oils.jpg"),
                new Product(2,"Battry","products/Battry.jpg"),
                new Product(3,"Tires","products/Tires.jpg"),
                new Product(4,"Spare Parts","products/GeneisePart.jpg"),
                new Product(5,"Solar panels","products/Solar.png")
            };
            return _data_set;
        }
    }
}