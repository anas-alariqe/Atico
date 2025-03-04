using Atico_Shared.Interfaces;
public class ViewObject :IViewData_set
    {
    public ViewObject()
    {
       
    }
     public ViewObject(int _id, string _name, string _img_path,string _description ="" )
    {
        Id = _id;
        Title = _name;
        Img_Path = _img_path;
        Description = _description;
    }
    public ViewObject(int _id, string _name, string _img_path,List<string> _descriptions )
    {
        Id = _id;
        Title = _name;
        Img_Path = _img_path;
        Description_set = _descriptions;
    }

    public int Id { get; set; }
    public string ID { get{return Id.ToString();} set{Id = int.TryParse(value,out int o) ? o : Id;} }
    public bool IsActive{ get; set; } = false;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Description_set { get; set; } = new();
    public string Img_Path { get; set; } = string.Empty;
    public List<string> Img_Path_set { get; set; } = new();
    public string LinkTo { get; set; } = string.Empty;
}