using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Painting
{
    public class PaintingImageDTO
    {
        public IFormFile Image { get; set; }
        public int PaintingEntityId { get; set; }
    }
}
