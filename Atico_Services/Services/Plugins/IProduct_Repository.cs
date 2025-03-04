namespace Atico_Services.Services.Plugins{

    public interface IProduct_Repository{
        Task<List<Product>> GetAllAsync();
        Task<List<Product>> GetAll_StarAsync();
    }
}