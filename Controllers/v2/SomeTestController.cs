namespace Winter.Controllers.v2;

[DefaultController]
[ApiVersion("2.0")]
public class SomeTestController
{
  [HttpGetFor(nameof(TestTwo))]
  public void TestTwo() { }
}
