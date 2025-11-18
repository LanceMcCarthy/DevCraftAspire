# DevCraftAspire

A set of projects that test various Telerik and Kendo components in Microsoft's [Aspire](https://aspire.dev). 

### Build Statuses

| Worflow | Status |
|--------|--------|
| Build | [![build](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/build.yml/badge.svg)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/build.yml) |
| Deploy (Docker and Azure) | [![](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy.yml/badge.svg?branch=release)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy.yml) |
| Deploy (Azure Only) | [![](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy-azureonly.yml/badge.svg?branch=release)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy-azureonly.yml) |

### Project Structure

- `DevCraftAspire.ApiService`: Contains the Telerik Reporting REST service.
- `DevCraftAspire.Web`: A Blazor application, using Telerik UI for Blazor and Telerik Reporting.
- `DevCraftAspire.ServiceDefaults`: A shared class library the defines all the services used by the front end and backend.
- `DevCraftAspire.AppHost`: The Aspire apphost project.

> [!NOTE]
> The uses a custom base image `lancemccarthy/skia-aspnet:10.0`, built by [LanceMcCarthy/BaseImages](https://github.com/LanceMcCarthy/BaseImages), is simply a copy of *mcr.microsoft.com/dotnet/aspnet:10.0* with **libfontconfig1** and **libfreetype6** preinstalled.

## Screenshots

Aspire Dashboard

<img width="899" height="558" alt="image" src="https://github.com/user-attachments/assets/955ce088-10f3-4d73-98a7-4bf086d0f4ca" />

The `webfrontend` application, DevCraftAspire.ApiService.

<img width="899" height="559" alt="image" src="https://github.com/user-attachments/assets/7dfbcf61-6d8a-41aa-8a71-5fd53df73f0d" />

The `apiservice` application, DevCraftAspire.Web

<img width="900" height="484" alt="image" src="https://github.com/user-attachments/assets/45b1d215-bbf0-42b8-8ca1-da900aa15d61" />

The `seq` service

<img width="900" height="560" alt="image" src="https://github.com/user-attachments/assets/40b46a09-bf9e-4f77-804c-b9decaf9b40d" />
