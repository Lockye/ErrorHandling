using Microsoft.AspNetCore.Mvc;
using OOPApplicationCore.Model;
using OOPApplicationCore.Service;
using System;

namespace OOPTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Post(User userRequest)
        {
            var saveUserResult = _userService.SaveUser(userRequest);
            return saveUserResult switch
            {
                NameTaken nameTaken => BadRequest(nameTaken.Message),
                NameNotValid nameNotValid => BadRequest(nameNotValid.Message),
                CreateUserSuccess createUserSuccess => Ok(createUserSuccess.User),
                _ => throw new Exception("Invalid response type") // ili return status code 500, svj :)
            };
        }
    }
}
