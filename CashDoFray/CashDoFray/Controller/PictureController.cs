using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CashDoFray.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        [HttpPost]
        public IActionResult Upload()
        {
            return Ok();
        }
    }
}
