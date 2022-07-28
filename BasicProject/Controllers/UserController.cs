
using BasicProject.Interface;
using BasicProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BasicProject.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUser _IUser;

        public UserController(IUser User)
        {
            _IUser = User;

        }

        [HttpPost("Usercreate")]
        public async Task<string> Post([FromBody] UserModel user)
        {
            var result = await _IUser.createUser(user);
            return result;
        }

    }
}
