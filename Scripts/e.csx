#!/usr/bin/env dotnet script

#load "./functions.cs"

switch (Args[0]) {
  case "reset":
      Functions.RemoveDirectory("./bin");
      Functions.RemoveDirectory("./obj");
      Functions.RunCommand("restore");
      Functions.RunCommand("tool restore");
      break;
}

