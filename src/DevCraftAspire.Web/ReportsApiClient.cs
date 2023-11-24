namespace DevCraftAspire.Web;

public class ReportsApiClient(HttpClient httpClient)
{
    public HttpClient ServiceHttpClient => httpClient;
}