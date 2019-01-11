using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Painting
{
    public class PaintingImageRequest
    {
        public IFormFile Image { get; set; }
        public int PaintingEntityId { get; set; }
    }
}
