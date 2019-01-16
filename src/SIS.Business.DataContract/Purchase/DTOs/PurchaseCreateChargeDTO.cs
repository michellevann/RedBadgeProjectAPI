using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Purchase.DTOs
{
    public class PurchaseCreateChargeDTO
    {
        public string Token { get; set; }
        public int PaintingEntityId { get; set; }
    }
}
