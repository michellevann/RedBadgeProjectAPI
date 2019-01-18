using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Purchase.DTOs
{
    public class PurchaseCreateChargeDTO
    {
        public string Token { get; set; }
        public string Title { get; set; }
        public long Price { get; set; }
        public string BuyerEmail { get; set; }
        public string BuyerName { get; set; }
        public string StreetAddress { get; set; }
        public string AptNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
    }
}
