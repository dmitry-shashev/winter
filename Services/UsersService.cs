using Winter.Models;

namespace Winter.Services;

public interface IUsersService
{
  public void CreateUser(User user);
  public List<User> GetAll();
  public void UpdateUser(User user);
  public void DeleteUser(Guid id);
}

public class UsersService : IUsersService
{
  private readonly List<User> _users =
    new()
    {
      new User(Guid.NewGuid(), "Dimon", "Coder"),
      new User(Guid.NewGuid(), "White", "Snow"),
    };

  public void CreateUser(User user)
  {
    _users.Add(user);
  }

  public List<User> GetAll()
  {
    return this._users;
  }

  public void UpdateUser(User user)
  {
    var index = _users.FindIndex(v => v.Id == user.Id);
    _users.RemoveAt(index);
  }

  public void DeleteUser(Guid id)
  {
    var index = _users.FindIndex(v => v.Id == id);
    _users.RemoveAt(index);
  }
}
