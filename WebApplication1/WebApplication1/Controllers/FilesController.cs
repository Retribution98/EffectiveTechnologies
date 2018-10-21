using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        readonly ILogger logger;

        public FilesController()
        {
            logger = WebApplication1.Startup.logger;
        }
        // GET: api/string
        [HttpGet]
        public string Get()
        {
            return "Post file and will return MD5-hash code this file";
        }

        // POST: api/string
        [HttpPost]
        public string Post([FromBody] IFormFile file)
        {
            if (file != null)
            {

                logger.Information("request MD5-hash for file length: {length}", file.Length);
                string path = "/Files/" + file.FileName;
                Stream fileStream = file.OpenReadStream();
                return HashCode.MD5hash(fileStream);
            }
            return null;
        }
    }
}
