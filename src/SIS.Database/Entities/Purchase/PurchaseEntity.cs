using RedStarter.Database.Entities.Painting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Purchase
{
    public class PurchaseEntity
    {
        [Key]
        public int PurchaseId { get; set; }

        public int PaintingEntityId { get; set; }

        [Required]
        public DateTimeOffset PurchaseDate { get; set; }

        public virtual PaintingEntity PaintingEntity { get; set; }
    }
}
