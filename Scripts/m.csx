#!/usr/bin/env dotnet script

#load "./functions.cs"

switch (Args[0]) {
  case "reset":
      Functions.RunCommand("ef database update 0");
      Functions.RunCommand("ef database update");
      break;
}

