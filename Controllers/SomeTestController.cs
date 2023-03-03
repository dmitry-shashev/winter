using Winter.Core.Helpers;

namespace Winter.Controllers;

[DefaultController]
public class SomeTestController
{
  [HttpGetFor(nameof(TestOne))]
  public void TestOne()
  {
    UserHelper.TestEnums();
  }
}
