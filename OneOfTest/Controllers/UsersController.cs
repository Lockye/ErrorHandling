using Microsoft.AspNetCore.Mvc;
using OneOfApplicationCore.Model;
using OneOfApplicationCore.Service;

namespace OneOfTest.Controllers
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
            var userOneOf = _userService.SaveUser(userRequest);
            return userOneOf.Match<IActionResult>(
                                user => Ok(user),
                                nameTaken => BadRequest(nameTaken.Message),
                                nameNotValid => BadRequest(nameNotValid.Message)
                                );
        }
    }
}
