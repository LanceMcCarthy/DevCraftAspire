# DevCraftAspire

A set of projects that test various Telerik and Kendo components in Microsoft's [Aspire](https://aspire.dev).

### Project Structure

- `DevCraftAspire.ApiService`: Contains the Telerik Reporting REST service.
- `DevCraftAspire.Web`: A Blazor application, using Telerik UI for Blazor and Telerik Reporting.
- 
### Build Status

| Build Base Image | Build | Deploy |
|----------|--------|--------|
| [![Update Base Image](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/update-base-image.yml/badge.svg)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/update-base-image.yml) | [![build](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/build.yml/badge.svg)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/build.yml) | [![deploy](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy.yml/badge.svg?branch=release)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy.yml) |

## Screenshots

Aspire Dashboard

<img width="899" height="558" alt="image" src="https://github.com/user-attachments/assets/955ce088-10f3-4d73-98a7-4bf086d0f4ca" />

The `webfrontend` application, DevCraftAspire.ApiService.

<img width="899" height="559" alt="image" src="https://github.com/user-attachments/assets/7dfbcf61-6d8a-41aa-8a71-5fd53df73f0d" />

The `apiservice` application, DevCraftAspire.Web

<img width="900" height="484" alt="image" src="https://github.com/user-attachments/assets/45b1d215-bbf0-42b8-8ca1-da900aa15d61" />

The `seq` service

<img width="900" height="560" alt="image" src="https://github.com/user-attachments/assets/40b46a09-bf9e-4f77-804c-b9decaf9b40d" />


### On Azure

![image](https://github.com/LanceMcCarthy/DevCraftAspire/assets/3520532/e19494ac-6da2-4a15-97ef-73f1615b06d6)


> [!IMPORTANT]
> The ApiService project uses a custom base image `lancemccarthy/aspirebase:8.0`, built by [this Dockerfile](https://github.com/LanceMcCarthy/DevCraftAspire/blob/main/.dockerbuilds/baseimage/Dockerfile). It is simply `mcr.microsoft.com/dotnet/aspnet:8.0` with `libfontconfig1` and `libfreetype6` preinstalled.
