namespace Atico_Shared.Interfaces{
    public interface IViewData{
        int Id { get; set; }
        string ID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Img_Path { get; set; }
        string LinkTo { get; set;}
        bool Equals(object? obj);
    }
}