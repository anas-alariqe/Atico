using System.Collections.Generic;
using Atico_Shared.Interfaces;

public class Product_Section : IViewData_set
{
    public Product_Section(){
        
    }
    public Product_Section(int _Id, string _Title, string _Image_Path, string _LinkTo)
    {
        Id=_Id;
        Title=_Title;
        Img_Path=_Image_Path;
        LinkTo=_LinkTo;
    }
    public Product_Section(int _Id, string _Title, string _Image_Path, List<Product> _products , string _LinkTo="")
    {
        Id=_Id;
        Title=_Title;
        Img_Path=_Image_Path;
        LinkTo=_LinkTo;
        foreach(var item in _products)
            Products.Add(item);
    }

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Img_Path { get; set; } = string.Empty;
    public  List<Product> Products { get; set; }= new List<Product>();
    public List<string> Img_Path_set { get; set; }= new();
    public List<string> Description_set { get; set; }= new();
    public string ID { get => Id.ToString(); set => Id= int.TryParse(value, out int Id1)? Id1 : -1; }
    public string LinkTo { get; set; } = string.Empty;
    public override bool Equals(object? obj)
    {
        bool equal = false;
        if (obj == null) return equal;
        if (obj.GetType() != typeof(Product_Section)) return equal;
        var _obj = obj as Product_Section;
        equal = ( _obj?.GetHashCode() == this.GetHashCode()) ; 
        return equal;
    }

    public override int GetHashCode()
    {
       return Id.GetHashCode()+Title.GetHashCode()+Img_Path.GetHashCode();
    }
}