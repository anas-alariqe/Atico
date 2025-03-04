public class ViewTemplateService : IViewTemplateService
{
    private readonly List<ViewTemplate> templates = new()
    {
        new ViewTemplate { UseCaseName = "ProductDetails", RazorComponent = "Atico.Atico_web.Components.Pages.ProductDetailsView" },
        new ViewTemplate { UseCaseName = "ServiceRequest", RazorComponent = "Atico_web.Components.Pages.ServiceRequestForm" },
        new ViewTemplate { UseCaseName = "ProjectPortfolio", RazorComponent = "Atico.Atico_web.Components.Controls.Pages.PortfolioView" }
    };

    public Task<ViewTemplate?> GetTemplateByUseCaseName(string useCaseName)
    {
        return Task.FromResult(templates.FirstOrDefault(t => t.UseCaseName == useCaseName));
    }
}