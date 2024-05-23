# DevCraftAspire
A set of projects that test various Telerik and Kendo components in .NET Aspire!

## CI-CD Status

| Branch | Status |
|----------|--------|
| `main` | [![xx](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/build.yml/badge.svg)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/build.yml) |
| `release` | [![xx](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy.yml/badge.svg?branch=release)](https://github.com/LanceMcCarthy/DevCraftAspire/actions/workflows/deploy.yml) |

## Azure Deployment Links

- App => https://webfrontend.purpledune-16458cf6.eastus2.azurecontainerapps.io/ 
- ApiService => https://apiservice.purpledune-16458cf6.eastus2.azurecontainerapps.io/reports/formats

> [!IMPORTANT]
> The ApiService container uses a custom base image with all the required Linux dependencies pre-installed ([ghcr.io/lancemccarthy/aspirebase](https://github.com/LanceMcCarthy/DevCraftAspire/pkgs/container/aspirebase)). It is defined by [this Dockerfile](https://github.com/LanceMcCarthy/DevCraftAspire/blob/main/.dockerbuilds/baseimage/Dockerfile) and published by the `update-images.yaml` workflow.

## Screenshots

### Visual Studio 2022 - .NET Aspire Solution

![image](https://github.com/LanceMcCarthy/DevCraftAspire/assets/3520532/03318693-d973-4ba3-ae0b-15a53e4d56ce)

### Local Deployment

![image](https://github.com/LanceMcCarthy/DevCraftAspire/assets/3520532/b83e9abb-8321-4710-83c2-c8c25e46f9b8)
