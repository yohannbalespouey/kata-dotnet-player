using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUser(string id)
        {
            // TODO: Implement
            await Task.Delay(100);

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(string name)
        {
            // TODO: Implement
            await Task.Delay(100);
            throw new NotImplementedException();
        }

        [HttpPut("{user_id}")]
        public async Task<IActionResult> DeleteUser([FromRoute(Name = "user_id")] string userId)
        {
            // TODO: Implement
            await Task.Delay(100);
            throw new NotImplementedException();
        }
    }
}