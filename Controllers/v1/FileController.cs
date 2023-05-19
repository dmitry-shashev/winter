namespace Winter.Controllers.v1;

[DefaultController]
public class FileController
{
  private readonly FileService _fileService;

  public FileController(FileService fileService)
  {
    _fileService = fileService;
  }

  [HttpGetFor(nameof(UploadForm))]
  public ContentResult UploadForm()
  {
    // on the local host
    //   https://localhost:7091/api/v1/file/upload-form
    var html =
      @"
<form action=""/api/v1/file""  method=""post"" enctype=""multipart/form-data"">
    <input type=""file"" name=""uploadedFile"" /><br>
    <input type=""submit"" value=""Load"" />
</form>
";
    return new ContentResult
    {
      Content = html,
      ContentType = "text/html"
    };
  }

  [HttpPost]
  public void AddFile(IFormFile uploadedFile)
  {
    _fileService.SaveFile(uploadedFile);
  }
}
