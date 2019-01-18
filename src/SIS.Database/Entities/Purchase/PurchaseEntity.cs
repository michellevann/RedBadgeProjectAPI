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

        //public int PaintingEntityId { get; set; }

        [Required]
        public DateTimeOffset PurchaseDate { get; set; }

        [Required]
        public string BuyerName { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        public string AptNumber { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        public string BuyerEmail { get; set; }

        public long Price { get; set; }

        public string Title { get; set; }

        //public virtual PaintingEntity PaintingEntity { get; set; }

    }
}
