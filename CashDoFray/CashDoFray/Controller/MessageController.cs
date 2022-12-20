using CashDoFray.Configuration;
using CashDoFray.Model;
using CashDoFray.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Http;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace CashDoFray.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        [Produces("application/json")]
        public async Task<IActionResult> Get(
            [FromServices]  ContextBase context)
        {
            var message = await context
                .Messages
                .AsNoTracking()
                .ToListAsync();
            return Ok(message);
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<IActionResult> PostAsync
            ([FromServices] ContextBase context, [FromBody] MessageView model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var message = new Message
            {
                Name = model.Name,
                Title = model.Title,
                Body = model.Body,
            };
            try
            {
                await context.Messages.AddAsync(message);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
