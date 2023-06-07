using Microsoft.AspNetCore.Mvc;
using SD.Application.Contracts;
using SD.Domain.Models;

namespace SD.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase {
    IUserService _userService = null;

    public UserController(IUserService userService) {
        _userService = userService;
    }

    [HttpGet]
    public List<User> Get() {
        return _userService.GetAllUsers();
    }

    [HttpGet("Login")]
    public User Login([FromBody] User oUser) {
        return _userService.Login(oUser);
    }

    [HttpPost]
    public User SignUp([FromBody] User oUser) {
        return _userService.SignUp(oUser);
    }
}
