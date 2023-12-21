namespace DevCraftAspire.Web.Clients;

public class ReportsApiClient(HttpClient httpClient)
{
    public HttpClient ServiceHttpClient => httpClient;
}