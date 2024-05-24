# DevCraftAspire

A set of projects that test various Telerik and Kendo components in .NET Aspire!

## Azure Deployment Links

- App => https://webfrontend.purpledune-16458cf6.eastus2.azurecontainerapps.io/ 
- ApiService => https://apiservice.purpledune-16458cf6.eastus2.azurecontainerapps.io/reports/formats

## CI-CD Status

| Build Base | Build | Deploy |
|----------|--------|--------|
| [![Update Base Image](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/update-base-image.yml/badge.svg)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/update-base-image.yml) | [![build](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/build.yml/badge.svg)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/build.yml) | [![deploy](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy.yml/badge.svg?branch=release)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy.yml) |

> [!NOTE]
> The ApiService project uses a custom base image `lancemccarthy/aspirebase:8.0`, built by [this Dockerfile](https://github.com/LanceMcCarthy/DevCraftAspire/blob/main/.dockerbuilds/baseimage/Dockerfile). It is simply `mcr.microsoft.com/dotnet/aspnet:8.0` with `libfontconfig1` and `libfreetype6` preinstalled.

## Screenshots

### On Azure

![image](https://github.com/LanceMcCarthy/DevCraftAspire/assets/3520532/e19494ac-6da2-4a15-97ef-73f1615b06d6)

### Visual Studio 2022

![image](https://github.com/LanceMcCarthy/DevCraftAspire/assets/3520532/03318693-d973-4ba3-ae0b-15a53e4d56ce)
