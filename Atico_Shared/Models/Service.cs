using Atico_Shared.Interfaces;

public class Service : IViewData_set
    {
    public Service()
    {
    
    }
    public Service(string _id, string _name, string _img_path,string _description="")
    {
        Id = int.TryParse(_id, out int _id1)? _id1 : -1;
        ID = _id;
        Title = _name;
        Img_Path = _img_path;
        Description = _description;
        SectionId=0;
    }
    public int Id { get; set; } =-1;
    public string ID { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int SectionId { get; set; }
    public  Service_Section? Section { get; set; }
    public string Img_Path { get; set; } = "";
    public List<string> Img_Path_set { get; set; } = new();
    public List<string> Description_set { get; set; } = new(); 
    public string LinkTo { get; set; } = string.Empty;
}