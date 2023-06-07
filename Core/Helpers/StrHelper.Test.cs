using Xunit;

namespace Winter.Core.Helpers;

public static class StrHelperTest
{
  [Fact]
  public static void ToKebabCase()
  {
    Assert.Equal(
      "one-green",
      StrHelper.ToKebabCase("OneGreen")
    );

    Assert.Equal(
      "some-day",
      StrHelper.ToKebabCase("someDay")
    );

    Assert.Equal(
      "another-good-day",
      StrHelper.ToKebabCase("AnotherGoodDay")
    );

    Assert.Equal("", StrHelper.ToKebabCase(""));
  }

  [Theory]
  [InlineData(" ")]
  [InlineData("")]
  [InlineData(null)]
  public static void IsEmpty_True(string? value)
  {
    Assert.True(StrHelper.IsEmpty(value));
  }

  [Theory]
  [InlineData("1")]
  [InlineData(" a ")]
  public static void IsEmpty_False(string? value)
  {
    Assert.False(StrHelper.IsEmpty(value));
  }
}
