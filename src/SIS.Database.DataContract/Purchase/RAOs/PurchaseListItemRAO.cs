using RedStarter.Database.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Purchase.RAOs
{
    public class PurchaseListItemRAO
    {
        public int PurchaseId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }

        public virtual PaintingCreateRAO Painting { get; set; }
    }
}
