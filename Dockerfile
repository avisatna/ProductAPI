# This docker file uses multi-stage build strategy
# to ensure optimal image build times and sizes
# End result container image requires .NET runtime,
# however creating it requires .NET SDK.
# mcr.microsoft.com/dotnet/sdk:2.1
# mcr.microsoft.com/dotnet/aspnet:2.1

# FROM mcr.microsoft.com/dotnet/aspnet:2.1 AS base
# WORKDIR /src

# FROM mcr.microsoft.com/dotnet/sdk:2.1 AS build
# WORKDIR /src
# COPY . .
# RUN dotnet restore Product.WebApi.csproj
# RUN dotnet build "./Product.WebApi.csproj" -c Debug -o /out

# FROM build AS publish
# RUN dotnet publish Product.WebApi.csproj -c Debug -o /out

# # Building final image used in running container
# FROM base AS final
# RUN apk update \
#     && apk add unzip procps
# WORKDIR /src
# COPY --from=publish /out .
# CMD ASPNETCORE_URLS=http://*:$PORT dotnet Product.WebApi.dll

# Google Cloud
# First let’s build the app and publish it.
FROM gcr.io/cloud-builders/csharp/dotnet AS builder
COPY . /src
WORKDIR /src
RUN dotnet restore --packages /packages
RUN dotnet publish -c Release -o /published

# Now let's build the app's image.
FROM gcr.io/google-appengine/aspnetcore:2.1
COPY --from=builder /published /app
ENV ASPNETCORE_URLS=http://*:${PORT}
WORKDIR /app
ENTRYPOINT [ "dotnet", "Product.WebApi.dlll" ]