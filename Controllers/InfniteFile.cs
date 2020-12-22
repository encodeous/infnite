using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace infnite.Controllers
{
    [ApiController]
    public class Infinity : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Get()
        {
            return RedirectPermanent("/swagger/");
        }
    }
}