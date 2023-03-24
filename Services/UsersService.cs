using Microsoft.EntityFrameworkCore;

namespace Winter.Services;

public class UsersService
{
  private readonly ApplicationDbContext _dbContext;

  public UsersService(ApplicationDbContext context)
  {
    _dbContext = context;
  }

  public User GetById(
    int id,
    bool withBooks = false,
    bool withLibraries = false
  )
  {
    var query = _dbContext.Users.AsQueryable();
    if (withBooks)
    {
      query = query.Include(v => v.Books);
    }
    if (withLibraries)
    {
      query = query.Include(v => v.Libraries);
    }
    var foundUser = query.FirstOrDefault(p => p.Id == id);
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

  public IEnumerable<User> GetAll(
    bool withBooks = false,
    bool withLibraries = false
  )
  {
    var query = _dbContext.Users.AsQueryable();
    if (withBooks)
    {
      query = query.Include(v => v.Books);
    }

    if (withLibraries)
    {
      query = query.Include(v => v.Libraries);
    }
    return query.ToList();
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
