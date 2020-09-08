using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace image_processing_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageProcessorController : ControllerBase
    {
        private readonly ILogger<ImageProcessorController> _logger;

        public ImageProcessorController(ILogger<ImageProcessorController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string Post()
        {
            return "hello world";
        }
    }
}
