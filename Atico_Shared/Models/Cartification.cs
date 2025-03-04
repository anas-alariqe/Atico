using System.Data.Common;
using Atico_Shared.Interfaces;

public class Cartification : IViewData_set
    {
    public Cartification()
    {
       
    }
    public Cartification(int _id, string _name, string _img_path,string _description="")
    {
        Id = _id;
        Title = _name;
        Img_Path = _img_path;
        Description = _description;
        SectionId=0;
    }
    public int Id { get; set; }
    public string ID { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Description_set { get; set; } = new();
    public int SectionId { get; set; }
    public string Img_Path { get; set; } = string.Empty;
    public List<string> Img_Path_set { get; set; } = new();
    public string LinkTo { get; set; } = string.Empty;
}