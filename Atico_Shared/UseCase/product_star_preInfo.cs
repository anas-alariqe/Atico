namespace Atico_Shared.UseCase
{
    public class product_star_preInfo{
        public int Id { get; set;}
        public string Name { get; set;} ="";
        public string Prod_Star_img_path { get; set;} = "";
         public product_star_preInfo()
        {
         
        }
        public product_star_preInfo(int id, string name, string path)
        {
            Id= id;
            Name = name;
            Prod_Star_img_path = path;
        }
    }
}