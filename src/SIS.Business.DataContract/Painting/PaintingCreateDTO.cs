using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Painting
{
    public class PaintingCreateDTO
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public int OwnerId { get; set; }
    }
}
