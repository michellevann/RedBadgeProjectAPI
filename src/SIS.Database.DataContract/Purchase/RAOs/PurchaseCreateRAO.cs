using RedStarter.Database.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Purchase
{
    public class PurchaseCreateRAO
    {
        public int PaintingEntityId { get; set; }
        public int PurchaseId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
    }
}
