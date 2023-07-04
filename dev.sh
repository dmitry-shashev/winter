# if we want a full restart on each file change

nodemon -w "./" -x "dotnet run --project Main " -e ".cs" --ignore 'bin/' --ignore 'obj/'
