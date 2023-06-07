using SD.Domain.Models;

namespace SD.Application.Contracts;
public interface IUserService {
    User SignUp(User oUser);
    User Login(User oUser);
    List<User> GetAllUsers();
}
