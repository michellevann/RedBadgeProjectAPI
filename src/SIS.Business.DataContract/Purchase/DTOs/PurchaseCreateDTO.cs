using RedStarter.Business.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Purchase
{
    public class PurchaseCreateDTO
    {
        public int PaintingEntityId { get; set; }
        public int OwnerId { get; set; }
        public int PurchaseId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
    }
}
