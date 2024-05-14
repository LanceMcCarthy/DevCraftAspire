FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

# Pre-install dependencies for Skia fonts, then clean up after myself
RUN apt-get update \
    && apt-get install libgdiplus libfreetype6 libfontconfig1 -y \
    && apt-get autoremove \
    && rm -rf /var/lib/apt/lists/*