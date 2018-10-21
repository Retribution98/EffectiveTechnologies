using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
using Serilog;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        readonly ILogger logger;

        public StringController()
        {
            logger = WebApplication1.Startup.logger;
        }

        // GET: api/string
        [HttpGet]
        public string Get()
        {
            return "Post string and will return MD5-hash code this string";
        }

        // POST: api/string
        [HttpPost]
        public JsonResult Post([FromBody] string value)
        {
            if (value == null) return null;
            logger.Information("request MD5-hash for string length: {length}", value.Length);
            return new JsonResult(HashCode.MD5hash(value));
            
        }
    }
}
