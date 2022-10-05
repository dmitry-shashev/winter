namespace Winter.Services;

public interface IUsersService
{
  public User CreateUser(string firstName, string lastName);
  public IEnumerable<User> GetAll();
  public User UpdateUser(
    int id,
    string firstName,
    string lastName
  );
  public void DeleteUser(int id);
  public User GetById(int id);
}

public class UsersService : IUsersService
{
  private readonly ApplicationDbContext _appDbContext;

  public UsersService(ApplicationDbContext context)
  {
    _appDbContext = context;
  }

  private readonly List<User> _users =
    new()
    {
      new User(1, "Dimon", "Coder", DateTime.Now),
      new User(2, "White", "Snow", DateTime.Now),
    };

  public User GetById(int id)
  {
    var foundUser = _users.SingleOrDefault(p => p.Id == id);
    if (foundUser is null)
    {
      throw new NotFoundException("User was not found");
    }
    return foundUser;
  }

  public User CreateUser(string firstName, string lastName)
  {
    var newUser = new User(
      DateTime.Now.Second,
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
    int id,
    string firstName,
    string lastName
  )
  {
    var index = this._users.FindIndex(v => v.Id == id);
    var foundUser = _users[index];
    if (foundUser is null)
    {
      throw new NotFoundException("User was not found");
    }

    var updatedUser = foundUser with
    {
      FirstName = firstName,
      LastName = lastName,
    };
    _users[index] = updatedUser;

    return updatedUser;
  }

  public void DeleteUser(int id)
  {
    var index = _users.FindIndex(v => v.Id == id);
    var foundUser = _users[index];
    if (foundUser is null)
    {
      throw new NotFoundException("User was not found");
    }
    _users.RemoveAt(index);
  }
}
