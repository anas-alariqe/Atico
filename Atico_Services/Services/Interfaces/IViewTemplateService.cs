public interface IViewTemplateService
{
    Task<ViewTemplate?> GetTemplateByUseCaseName(string useCaseName);
}