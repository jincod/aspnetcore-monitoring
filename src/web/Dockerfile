FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS builder
WORKDIR /source
# Just copy everything
COPY . .
RUN dotnet restore -r linux-musl-x64
RUN dotnet publish -c Release -r linux-musl-x64 -o /app --no-restore

FROM mcr.microsoft.com/dotnet/runtime-deps:5.0-alpine
WORKDIR /app
COPY --from=builder /app .
RUN ls
CMD ./web