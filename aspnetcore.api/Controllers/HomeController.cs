using System.Threading.Tasks;
using aspnetcore.messages.Commands;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.api.Controllers
{
    [Route("[controller]")]
    public class RecordsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecord command)
        {
            return Accepted();
        }

    }
}
