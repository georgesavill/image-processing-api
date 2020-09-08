using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

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
        public async Task<byte[]> UploadImage()
        {
            using (MemoryStream memoryStream = new MemoryStream(2048))
            {
                await Request.Body.CopyToAsync(memoryStream);

                return processImage(new ImageJob
                {
                    ImageBytes = memoryStream.ToArray(),
                    Options = new ImageJobOptions{
                        Format  = Request.Headers["format"],
                        Size    = Request.Headers["size"],
                        Quality = Request.Headers["quality"]
                    }
                });
            }
        }

        private byte[] processImage(ImageJob imageJob)
        {
            throw new NotImplementedException();
        }
    }
}
