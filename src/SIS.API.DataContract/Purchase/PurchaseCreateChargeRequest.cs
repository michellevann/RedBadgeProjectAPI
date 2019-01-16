using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Purchase
{
    public class PurchaseCreateChargeRequest
    {
        public string Token { get; set; }
        public int PaintingEntityId { get; set; }
    }
}
