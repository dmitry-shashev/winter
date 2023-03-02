using Winter.Core.Helpers;

namespace Winter.Controllers;

[DefaultController]
public class SomeTestController
{
  [HttpGetDefault(nameof(TestOne))]
  public void TestOne()
  {
    UserHelper.TestEnums();
  }
}
