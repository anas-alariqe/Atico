using Atico_Shared.UseCase;
namespace Atico_Services.Services{
    public interface IOverall_Date_Service
    {
        Task<List<product_star_preInfo?>?> GetProductsWhereIs_product_starAsync();
    }
}
