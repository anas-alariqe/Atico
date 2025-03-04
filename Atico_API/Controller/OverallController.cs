using Microsoft.AspNetCore.Mvc;
using Atico_Services.Services;
namespace Atico_API.Controller{
    [ApiController]
    [Route("api/[controller]")] // المسار الأساسي: "api/Overall"
    public class OverallController : ControllerBase
    {
        private readonly IOverall_Date_Service _Overall_Date_Service;

        public OverallController()
        {

        }
        public OverallController(IOverall_Date_Service _overall_date_serv)
        {
            _Overall_Date_Service = _overall_date_serv;
        }

        // مسار GET الأساسي: "api/productsStar"
        [HttpGet]
        public async Task<IActionResult> GetProducts_Star()
        {
            var products_star = await _Overall_Date_Service.GetProductsWhereIs_product_starAsync();
            return Ok(products_star);
        }
    }

}
 