using RedStarter.Database.Entities.Painting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Painting
{
    public class PaintingEntity
    {
        [Key]
        public int PaintingEntityId { get; set; }

        public string Artist { get; set; }
        public string Title { get; set; }

        [Required]
        public int OwnerId { get; set; }

        [Required]
        public DateTimeOffset DateAdded { get; set; }


        public string Size { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }
    }
}
