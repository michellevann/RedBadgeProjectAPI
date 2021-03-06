﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Painting
{
    public class PaintingGetListItemDTO
    {
        public int PaintingEntityId { get; set; }
        public string Title { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }
    }
}
