using Winter.Models;

namespace Winter.Services;

public interface IUsersService
{
  public User CreateUser(string firstName, string lastName);
  public IEnumerable<User> GetAll();
  public User UpdateUser(
    Guid id,
    string firstName,
    string lastName
  );
  public void DeleteUser(Guid id);
  public User GetById(Guid id);
}

public class UsersService : IUsersService
{
  private readonly List<User> _users =
    new()
    {
      new User(
        Guid.NewGuid(),
        "Dimon",
        "Coder",
        DateTime.Now
      ),
      new User(
        Guid.NewGuid(),
        "White",
        "Snow",
        DateTime.Now
      ),
    };

  public User GetById(Guid id)
  {
    var foundUser = _users.SingleOrDefault(p => p.Id == id);
    if (foundUser is null)
    {
      // TODO: test and upgrade it
      throw new Exception("Not Found");
    }
    return foundUser;
  }

  public User CreateUser(string firstName, string lastName)
  {
    var newUser = new User(
      Guid.NewGuid(),
      firstName,
      lastName,
      DateTime.Now
    );
    _users.Add(newUser);
    return newUser;
  }

  public IEnumerable<User> GetAll()
  {
    return this._users;
  }

  public User UpdateUser(
    Guid id,
    string firstName,
    string lastName
  )
  {
    var index = this._users.FindIndex(v => v.Id == id);
    var foundUser = _users[index];
    if (foundUser is null)
    {
      // TODO: test and upgrade it
      throw new Exception("Not Found");
    }

    var updatedUser = foundUser with
    {
      FirstName = firstName,
      LastName = lastName,
    };
    _users[index] = updatedUser;

    return updatedUser;
  }

  public void DeleteUser(Guid id)
  {
    var index = _users.FindIndex(v => v.Id == id);
    _users.RemoveAt(index);
  }
}
