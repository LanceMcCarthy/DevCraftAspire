FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

# Pre-install dependencies for Skia fonts, then clean up after myself
RUN apt-get update \
    && apt-get install -y --allow-unauthenticated \
    libfreetype6 \
    libfontconfig1 \
    && apt-get autoremove \
    && rm -rf /var/lib/apt/lists/*