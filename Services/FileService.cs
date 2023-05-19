namespace Winter.Services;

public class FileService
{
  private readonly string _path = "/uploaded-files/";
  private readonly ApplicationDbContext _dbContext;

  public FileService(ApplicationDbContext context)
  {
    _dbContext = context;
  }

  public void SaveFile(IFormFile file)
  {
    var folder = $"{AppContext.BaseDirectory}{_path}";
    var finalPath = $"{folder}{file.FileName}";

    Directory.CreateDirectory(folder);

    // saving the file on the disk
    file.CopyTo(new FileStream(finalPath, FileMode.Create));

    // adding the record to the db
    _dbContext.UploadedFiles.Add(
      new UploadedFile()
      {
        Name = file.FileName,
        Path = finalPath,
      }
    );
    _dbContext.SaveChanges();
  }
}
