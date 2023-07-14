using Microsoft.AspNetCore.Mvc.Testing;

namespace e2e;

[TestClass]
public class UsersControllerTest
{
  private readonly HttpClient _httpClient;

  public UsersControllerTest()
  {
    var webAppFactory =
      new WebApplicationFactory<Program>();
    _httpClient = webAppFactory.CreateDefaultClient();
  }

  [TestMethod]
  public async Task TestMethod1()
  {
    var response = await _httpClient.GetAsync(
      "/api/v1/users"
    );
    var stringResult =
      await response.Content.ReadAsStringAsync();
    // TODO: currently not implemented
    Assert.AreEqual("Hello World!", stringResult);
  }
}
