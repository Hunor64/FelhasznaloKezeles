using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FelhasznaloKezeles.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        [Authorize]
        [HttpGet]
        [Route("/valami")]
        public ActionResult<string> Index()
        {
            return Ok("Van valami.");
        }
    }
}
