FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

ENV DOTNET_USE_POLLING_FILE_WATCHER 1
ENV PATH $PATH:/root/.dotnet/tools

COPY ./ ./
RUN dotnet dev-certs https

RUN dotnet tool install --global dotnet-ef

EXPOSE 7091
EXPOSE 5233

ENTRYPOINT dotnet ef database update && dotnet watch run --non-interactive
