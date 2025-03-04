using Atico_Shared.UseCase;

namespace Atico_Services.Services{
    
    public class Overall_Date_Service : IOverall_Date_Service
    {
        public async Task<List<product_star_preInfo?>?> GetProductsWhereIs_product_starAsync()
        {
            await Task.Delay(1);
            List<product_star_preInfo?>? product_Star_s = new() ;
            /*IProduct_Repository  _Iprod_repos= new Atico_Data.Repositories.Product_Repository();
            List<Product> products = await  _Iprod_repos.GetAll_StarAsync();
            foreach(var prod in products){
                product_Star_s.Add(new product_star_preInfo(prod.Id,prod.Name,prod.Img_Path));
            }*/
            
            return product_Star_s;
        }
    }
}