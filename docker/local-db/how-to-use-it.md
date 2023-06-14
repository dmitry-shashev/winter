#### Create a folder if not exists

`./docker/dbdata`

> it should be created from the current user, it
> will not work if it is root

#### All commands must be started from this folder

#### For the first time run

```bash
dicker-compose up --build
```

And then stop containers and simply run

```bash
docker-compose up
```
