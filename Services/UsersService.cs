using Microsoft.EntityFrameworkCore;

namespace Winter.Services;

public interface IUsersService
{
  public User CreateUser(
    string email,
    string firstName,
    string lastName,
    string phone
  );
  public IEnumerable<User> GetAll();
  public IEnumerable<User> GetAllWithBooks();
  public User UpdateUser(
    int id,
    string firstName,
    string lastName,
    string phone
  );
  public void DeleteUser(int id);
  public User GetById(int id);
  public User GetByIdLibraries(int id);
}

public class UsersService : IUsersService
{
  private readonly ApplicationDbContext _dbContext;

  public UsersService(ApplicationDbContext context)
  {
    _dbContext = context;
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

  public User GetByIdLibraries(int id)
  {
    var foundUser = _dbContext.Users
      .Include(v => v.Libraries)
      .FirstOrDefault(p => p.Id == id);
    if (foundUser is null)
    {
      throw new NotFoundException("User was not found");
    }
    return foundUser;
  }

  public User CreateUser(
    string email,
    string firstName,
    string lastName,
    string phone
  )
  {
    var newUser = new User()
    {
      Id = 0,
      Email = email,
      FirstName = firstName,
      LastName = lastName,
      Phone = phone,
    };
    _dbContext.Users.Add(newUser);
    _dbContext.SaveChanges();
    return newUser;
  }

  public IEnumerable<User> GetAll()
  {
    return _dbContext.Users;
  }

  public IEnumerable<User> GetAllWithBooks()
  {
    return _dbContext.Users.Include(v => v.Books);
  }

  public User UpdateUser(
    int id,
    string firstName,
    string lastName,
    string phone
  )
  {
    var user = _dbContext.Users.FirstOrDefault(
      v => v.Id == id
    );
    if (user is null)
    {
      throw new NotFoundException("User was not found");
    }

    user.FirstName = firstName;
    user.LastName = lastName;
    user.Phone = phone;

    _dbContext.SaveChanges();

    return user;
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
