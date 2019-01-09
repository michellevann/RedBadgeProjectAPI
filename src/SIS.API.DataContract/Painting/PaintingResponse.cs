using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Painting
{
    public class PaintingResponse
    {
        public int PaintingEntityId { get; set; }
        public string Artist { get; set; }
        public int OwnerId { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }
        public string PriceRange { get; set; }
    }
}
