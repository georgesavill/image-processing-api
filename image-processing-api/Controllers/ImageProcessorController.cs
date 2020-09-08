using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
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
        public async Task<byte[]> UploadImage()
        {
            using (MemoryStream memoryStream = new MemoryStream(2048))
            {
                await Request.Body.CopyToAsync(memoryStream);
                byte[] uploadedImage = memoryStream.ToArray();
                using (MagickImage image = new MagickImage(uploadedImage))
                {
                    image.Write("test.jpg");
                    return image.ToByteArray();
                }
            }
        }
    }
}
