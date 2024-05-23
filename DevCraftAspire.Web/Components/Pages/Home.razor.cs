using Telerik.ReportViewer.Blazor;

namespace DevCraftAspire.Web.Components.Pages;

public partial class Home
{
    private string? ApiServiceUrl { get; set; }
    private ReportViewer? ReportViewer1 { get; set; }
    private ReportSourceOptions MyReportSource { get; set; } = new() { Report = "BarcodesReport.trdp" };

    protected override async Task OnInitializedAsync()
    {
        var rootUrl = "";
#if DEBUG
        rootUrl = "https://localhost:7443";
#elif RELEASE
        // If we are running in Azure, the final URL will be available in this variable
        rootUrl = Environment.GetEnvironmentVariable("services__apiservice__https__0");
#endif
        this.ApiServiceUrl = $"{rootUrl}/reports";

        await base.OnInitializedAsync();
    }
}