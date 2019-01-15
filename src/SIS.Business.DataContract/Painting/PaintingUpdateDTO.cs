using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Painting
{
    public class PaintingUpdateDTO
    {
        public int PaintingEntityId { get; set; }
        public string Title { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public IFormFile Image { get; set; }
    }
}
