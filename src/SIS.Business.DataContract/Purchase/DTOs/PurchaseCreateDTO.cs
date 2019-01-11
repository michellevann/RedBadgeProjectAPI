using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Purchase
{
    public class PurchaseCreateDTO
    {
        public int OwnerId { get; set; }
        public int PurchaseId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
    }
}
