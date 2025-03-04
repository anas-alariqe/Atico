using Atico_Shared.Interfaces;

public class Brand :IViewData
{
    public int Id { get; set; } = -1;
    public string ID { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Img_Path { get; set; } = string.Empty;
    public string LinkTo { get; set; } = string.Empty;

    public int SectionId { get; set; }
    public Product_Section? Section { get; set; }
    public List<Product>? Products { get; set; }
}