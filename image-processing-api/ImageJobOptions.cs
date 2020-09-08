using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace image_processing_api
{
    public class ImageJobOptions
    {
        public string Format { get; set; }
        public string Size { get; set; }
        public string Quality { get; set; }
    }
}
