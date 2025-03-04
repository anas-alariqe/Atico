using Atico_Shared.UseCase;
namespace Atico_Services.Services{
    public class ViewProduct_Stars{
        public List<product_star_preInfo> Prod_stars{ get; set; } 

        public ViewProduct_Stars() {
            Prod_stars = new List<product_star_preInfo>(){
                new product_star_preInfo(1,"Oils","products/Oils.jpg"),
                new product_star_preInfo(2,"Battry","products/Battry.jpg"),
                new product_star_preInfo(3,"Tires","products/Tires.jpg"),
                new product_star_preInfo(4,"Spare Parts","products/GeneisePart.jpg"),
                new product_star_preInfo(5,"Solar panels","products/Solar.png")
            };
        }
         public static List<product_star_preInfo> GetAll() {
            return  new List<product_star_preInfo>(){
                new product_star_preInfo(1,"Oils","products/Oils.jpg"),
                new product_star_preInfo(2,"Battry","products/Battry.jpg"),
                new product_star_preInfo(3,"Tires","products/Tires.jpg"),
                new product_star_preInfo(4,"Spare Parts","products/GeneisePart.jpg"),
                new product_star_preInfo(5,"Solar panels","products/Solar.png")
            };
        }


        
    }
}