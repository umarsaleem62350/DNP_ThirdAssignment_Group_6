
using Entities.Models;

namespace Application;

public interface IUserDAO {
    Task createUserAsync(User user);

    //   Task<bool>
    Task<bool> doesUsernameExist(string username);  
    Task<User> GetUserAsync(string username);
}