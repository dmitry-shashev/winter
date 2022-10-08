namespace Winter.Services;

public interface IUsersService
{
  public User CreateUser(
    string email,
    string firstName,
    string lastName
  );
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
  private readonly ApplicationDbContext _dbContext;

  public UsersService(ApplicationDbContext context)
  {
    this._dbContext = context;
  }

  public User GetById(int id)
  {
    var foundUser = _dbContext.Users.FirstOrDefault(
      p => p.Id == id
    );
    if (foundUser is null)
    {
      throw new NotFoundException("User was not found");
    }
    return foundUser;
  }

  public User CreateUser(
    string email,
    string firstName,
    string lastName
  )
  {
    var newUser = new User(
      0,
      email,
      firstName,
      lastName,
      DateTime.Now
    );
    _dbContext.Users.Add(newUser);
    _dbContext.SaveChanges();
    return newUser;
  }

  public IEnumerable<User> GetAll()
  {
    return this._dbContext.Users;
  }

  public User UpdateUser(
    int id,
    string firstName,
    string lastName
  )
  {
    var user = _dbContext.Users.FirstOrDefault(
      v => v.Id == id
    );
    if (user is null)
    {
      throw new NotFoundException("User was not found");
    }

    var updatedUser = user with
    {
      FirstName = firstName,
      LastName = lastName,
    };
    _dbContext.Users.Update(updatedUser);
    _dbContext.SaveChanges();

    return updatedUser;
  }

  public void DeleteUser(int id)
  {
    var user = _dbContext.Users.FirstOrDefault(
      v => v.Id == id
    );
    if (user is null)
    {
      throw new NotFoundException("User was not found");
    }

    _dbContext.Users.Remove(user);
  }
}
