using Microsoft.AspNetCore.Mvc;
using Telerik.Reporting.Services.AspNetCore;
using Telerik.Reporting.Services;

namespace DevCraftAspire.ApiService.Controllers;

// Primary constructors allow for nice clear Telerik Reporting ReportsController.
[Route("/reports")]
[ApiController]
public class ReportsController(IReportServiceConfiguration reportServiceConfiguration) 
    : ReportsControllerBase(reportServiceConfiguration)
{
}
