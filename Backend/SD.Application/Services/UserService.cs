using SD.Application.Contracts;
using SD.Application.Interfaces;
using SD.Domain.Models;

namespace SD.Application.Services;
public class UserService : IUserService {

    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository) {
        _userRepository = userRepository;
    }

    public List<User> GetAllUsers() {
        return _userRepository.GetAllUsers();
    }

    public User Login(User oUser) {
        return _userRepository.Login(oUser);
    }

    public User SignUp(User oUser) {
        return _userRepository.SignUp(oUser);
    }
}
