using Microsoft.AspNetCore.Mvc;
using Shop.Database;
using Shop.Application.AdminProducts;
using System.Threading.Tasks;
using Shop.Application.AdminStock;
using Microsoft.AspNetCore.Authorization;
using Shop.Application.AdminUser;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Admin")]
    public class UsersController : Controller
    {
        private CreateUser _createUser;

        public UsersController(CreateUser createUser)
        {
            _createUser = createUser;
        }

        

        public async Task<IActionResult> Createuser([FromBody] CreateUser.Request request)
        {
            await _createUser.Do(request);

            return Ok();
        }


    }
}