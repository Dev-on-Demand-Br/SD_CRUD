using SD.Application.Interfaces;
using SD.Domain.Common;
using SD.Domain.Models;

namespace SD.Infrastructure.Repositories;
public class UserRepository : IUserRepository {



    public List<User> GetAllUsers() {
        return Global.Users;
    }

    public User Login(User oUser) {
        var user = Global.Users.SingleOrDefault(x => x.Username == oUser.Username);

        bool isValidPassword = BCrypt.Net.BCrypt.Verify(oUser.Password, user.Password);

        if (isValidPassword) {
            return user;
        }
        return null;
    }

    public User SignUp(User oUser) {
        oUser.Password = BCrypt.Net.BCrypt.HashPassword(oUser.Password);
        Global.Users.Add(oUser);
        return oUser;
    }
}
