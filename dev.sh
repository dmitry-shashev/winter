# if we want a full restart on each file change

nodemon -w "./" -x "dotnet run" -e ".cs" --ignore 'bin/' --ignore 'obj/'

# If we are in the solution
#nodemon -w "./Main" -x "dotnet run --project Main" -e ".cs" --ignore 'bin/' --ignore 'obj/'
