#!/usr/bin/env dotnet script

#load  "./Scripts/functions.cs"

if (Args.Count() == 0) {
  throw new Exception("The script name must be specified");
}

var proxyArgsRow = Args.Skip(1).Aggregate("", (a, b) => a + " " + b).Trim();
Functions.RunCommand(
  $"script ./Scripts/{Args[0]}.csx",
  proxyArgsRow
);


