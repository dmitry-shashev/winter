using Xunit;

namespace Winter.Core.Helpers;

public static class StrHelperTest
{
  [Fact]
  public static void ToKebabCase()
  {
    string result = StrHelper.ToKebabCase("OneGreen");
    Assert.Equal("one-green", result);
  }
}
