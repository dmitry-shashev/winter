FROM mcr.microsoft.com/dotnet/sdk:6.0

RUN useradd --uid=1000 --gid=65534 -ms /bin/bash coder
USER coder

RUN dotnet tool install --global dotnet-ef

WORKDIR /app

ENV DOTNET_USE_POLLING_FILE_WATCHER 1
ENV PATH $PATH:/home/coder/.dotnet/tools

COPY ./ ./
RUN dotnet dev-certs https


EXPOSE 7091
EXPOSE 5233

ENTRYPOINT dotnet ef database update && dotnet watch run --non-interactive
