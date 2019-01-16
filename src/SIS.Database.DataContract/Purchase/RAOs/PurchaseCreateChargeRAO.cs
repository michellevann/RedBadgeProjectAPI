using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Purchase.RAOs
{
    public class PurchaseCreateChargeRAO
    {
        public string Token { get; set; }
        public int PaintingEntityId { get; set; }
    }
}
