using Winter.Core.Helpers;

namespace Winter.Controllers.v1;

[DefaultController]
public class SomeTestController
{
  [HttpGetFor(nameof(TestOne))]
  public void TestOne()
  {
    UserHelper.TestEnums();
  }
}
