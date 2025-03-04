using Atico_Shared.Interfaces;

public class Partiner :IViewData_set
    {
    public Partiner()
    {
       
    }
    public Partiner(string _id, string _name, string _img_path, string _href="")
    {
        Id = int.TryParse(_id, out int _id1)? _id1 : -1 ;
        ID = _id;
        Title = _name;
        Img_Path = _img_path;
        Description = "";
        LinkTo= _href;
    }
    public int Id { get; set; } = -1;
    public string ID { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Img_Path { get; set; } = string.Empty;
    public List<string> Img_Path_set { get; set; } = new();
    public string LinkTo { get; set; } = string.Empty;
    public List<string> Description_set { get; set; } = new();
}