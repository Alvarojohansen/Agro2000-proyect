using Microsoft.AspNetCore.Mvc;

namespace AgroAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
