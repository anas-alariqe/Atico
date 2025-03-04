using System.Collections.Generic;
using Atico_Shared.Interfaces;

public class News :IViewData_set
    {
    public News()
    {
       
    }
    public News(int _id, string _title, string _img_path,string _description="")
    {
        Id = _id;
        Title = _title;
        Img_Path = _img_path;
        Description = _description;
        SectionId=0;
    }

    public int Id { get; set; }
    public string ID { get => Id.ToString(); set => Id= int.TryParse(value, out int _out)? _out:0;}
    public string Description { get; set; } = string.Empty;
    public int SectionId { get; set; }
    public string Img_Path { get; set; } = string.Empty;
    public List<string> Img_Path_set {  get; set; } = new();
    public string Title { get ; set; } = string.Empty;
    public string LinkTo { get; set; } = string.Empty;
    public List<string> Description_set { get ; set; } = new List<string>();
}