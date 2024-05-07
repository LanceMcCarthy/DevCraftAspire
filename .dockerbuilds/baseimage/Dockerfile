FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

# Pre-install dependencies for Skia fonts
RUN apt-get update
RUN apt-get install libfreetype6 libfontconfig1 -y