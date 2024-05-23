using DevCraftAspire.Web.Models;

namespace DevCraftAspire.Web.Components.Pages;

public partial class About
{
    private string? ApiServiceUrl { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var apiUrl = "";

#if DEBUG
        apiUrl = "https://localhost:7443";
#elif RELEASE
        apiUrl = Environment.GetEnvironmentVariable("services__apiservice__https__0");
#endif

        this.ApiServiceUrl = $"{apiUrl}/reports";

        await base.OnInitializedAsync();
    }
}