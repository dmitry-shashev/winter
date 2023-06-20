It will allow to restart the whole engine during changes

> Might be useful if the engine does not fully restart
> on changes using `dotnet watch`

In the root folder we may create - `dev.sh`

Allow to run

```bash
chmod 777 dev.sh
```

With next content

```bash
nodemon -w "./MSS.LostAndFound" -x "dotnet run --project MSS.LostAndFound/Main" -e ".cs" --ignore 'bin/' --ignore 'obj/'
```

Install nodejs global tool

```bash
npm i -g nodemon
```