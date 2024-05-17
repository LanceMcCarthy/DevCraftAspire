using Microsoft.AspNetCore.Mvc;
using Telerik.Reporting.Services.AspNetCore;
using Telerik.Reporting.Services;

namespace DevCraftAspire.ApiService.Controllers;

[Route("/reports")]
[ApiController]
public class ReportsController(IReportServiceConfiguration reportServiceConfiguration) // Primary constructors allow for a simplified ReportsController.
    : ReportsControllerBase(reportServiceConfiguration)
{
}
