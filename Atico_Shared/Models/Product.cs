using Atico_Shared.Interfaces;

public class Product: IViewData_set
    {
    public Product()
    {
       
    }
    public Product(int _id, string _name, string _img_path)
    {
        Id = _id;
        Title = _name;
        Img_Path = _img_path;
        Description = "";
        SectionId=0;
        Price =0 ;
        Section = null;
    }

    public int Id { get; set; }
    public string ID { get; set; } =string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int SectionId { get; set; }
    public  Product_Section? Section { get; set; }
    public string Img_Path { get; set; } = string.Empty;
    public List<string> Img_Path_set { get; set; } = new();
    public List<string> Description_set { get; set; } = new();
    public string LinkTo { get; set; } = string.Empty;
}