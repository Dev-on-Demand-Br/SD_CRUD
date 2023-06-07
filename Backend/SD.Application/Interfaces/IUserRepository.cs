using SD.Domain.Models;

namespace SD.Application.Interfaces;
public interface IUserRepository {
    User SignUp(User oUser);
    User Login(User oUser);
    List<User> GetAllUsers();
}
