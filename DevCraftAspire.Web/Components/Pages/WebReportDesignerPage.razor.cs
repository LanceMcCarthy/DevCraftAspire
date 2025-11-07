using Telerik.ReportViewer.Blazor;

namespace DevCraftAspire.Web.Components.Pages
{
    public partial class WebReportDesignerPage
    {
        private string? ApiServiceUrl { get; set; }
        private string TemplateString { get; set; } = string.Empty;



        protected override async Task OnInitializedAsync()
        {
            var rootUrl = "";
#if DEBUG
            rootUrl = "https://localhost:7443";
#elif RELEASE
        // If we are running in Azure, the final URL will be available in this variable
        rootUrl = Environment.GetEnvironmentVariable("services__apiservice__https__1");
#endif
            this.ApiServiceUrl = $"{rootUrl}/api/reportdesigner";
            this.TemplateString = @$"{rootUrl}api/reportdesigner/resources/templates/telerikReportViewerTemplate.html";

            await base.OnInitializedAsync();
        }
    }
}
