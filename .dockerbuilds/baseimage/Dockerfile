FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

# Pre-install dependencies for Skia fonts
RUN apt-get update && apt-get install -y \
    libfreetype6 \
    libfontconfig1 \
    && rm -rf /var/lib/apt/lists/*