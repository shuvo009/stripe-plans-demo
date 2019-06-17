using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StripePlanSubscriptions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StripeWebHooksController : ControllerBase
    {
        [HttpPost("Hook")]
        public async Task<IActionResult> Hook()
        {
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                var stripeResponse = await reader.ReadToEndAsync(); 
                //Do your business here base on type property
            }

            return Ok();
        }
    }
}