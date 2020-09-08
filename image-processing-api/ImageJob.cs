using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace image_processing_api
{
    public class ImageJob
    {
        public byte[] ImageBytes { get; set; }
        public ImageJobOptions Options { get; set; }
    }
}
