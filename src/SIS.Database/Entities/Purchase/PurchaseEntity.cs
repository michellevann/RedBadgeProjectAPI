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

        [Required]
        public DateTime PurchaseDate { get; set; }
    }
}
