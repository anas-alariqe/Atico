using System.Collections.Generic;
using Atico_Shared.Interfaces;

public class Service_Section : IViewData_set
{
    public Service_Section()
    {
       
    }


    public Service_Section(int _id, string _title, string _img_path, string _link)
    {
        this.Id = _id;
        this.Title = _title;
        this.Img_Path = _img_path;
        this.LinkTo = _link;
    }
    
    public Service_Section(int _id, string _title, string _img_path, List<Service> _services, string _link="" )
    {
        this.Id = _id;
        this.Title = _title;
        this.Img_Path = _img_path;
        this.LinkTo = _link;
        foreach(var item in _services)
            Services.Add(item);
    }

    public int Id { get; set; }
    public string ID { get => Id.ToString(); set => Id = int.TryParse(value, out int Int1)? Int1:-1; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Img_Path { get; set; } = string.Empty;
    public  List<Service>? Services { get; set; }= new List<Service>();
    public string LinkTo {get; set; } = "";
    public List<string> Img_Path_set { get ; set; } = new();
    public List<string> Description_set { get ; set; } = new();
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
