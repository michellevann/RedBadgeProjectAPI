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

        [Required]
        public string Title { get; set; }

        public string Artist { get; set; }

        [Required]
        public DateTimeOffset DateAdded { get; set; }
    }
}
