using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Painting
{
    public class PaintingCreateRAO
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public int OwnerId { get; set; }
    }
}
