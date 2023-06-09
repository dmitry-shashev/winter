public abstract class Functions
{
  public static void RunCommand(params string[] argsArr)
  {
    var argsRow = argsArr
      .Aggregate("", (a, b) => a + " " + b)
      .Trim();
    Process cmd = new Process();
    cmd.StartInfo.FileName = "dotnet";
    cmd.StartInfo.Arguments = argsRow;
    cmd.Start();
    cmd.WaitForExit();
  }

  public static void RemoveDirectory(string path)
  {
    if (Directory.Exists(path))
    {
      Directory.Delete(path, true);
    }
  }
}
