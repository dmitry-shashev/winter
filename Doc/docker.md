Remove folders

> may require `sudo` - dotnet restore recreate these folders,
> `dotnet watch` run restore automatically

```bash
rm obj
rm bin
```

In order to start

go to `./docker/local`

then run the command

```bash
docker-compose up --build
```

then navigate on the url

```bash
https://localhost:7091/swagger/index.html
```

> Also orchestration system has a container for managing MySql
> on address 'http://localhost:8081'