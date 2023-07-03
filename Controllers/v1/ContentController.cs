using Winter.Core.Helpers;

namespace Winter.Controllers.v1;

[DefaultController]
public class ContentController
{
  private readonly FileService _fileService;

  public ContentController(FileService fileService)
  {
    _fileService = fileService;
  }

  // using next image
  // https://images.freeimages.com/images/large-previews/31a/traverse-1234278.jpg
  // in order to check it
  // https://localhost:7091/api/v1/content/get-image?name=traverse-1234278.jpg
  [HttpGetFor(nameof(GetImage))]
  public IActionResult GetImage(string name)
  {
    var fileBytes = _fileService.GetFile(name);
    MemoryStream ms = new MemoryStream(fileBytes);
    var contentType = StrHelper.DetermineFileContentType(
      name
    );
    return new FileStreamResult(ms, contentType);
  }
}
