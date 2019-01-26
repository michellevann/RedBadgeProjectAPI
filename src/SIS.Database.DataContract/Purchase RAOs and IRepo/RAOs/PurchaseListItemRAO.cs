using RedStarter.Database.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Purchase.RAOs
{
    public class PurchaseListItemRAO
    {
        public int PaintingEntityId { get; set; }
        public int PurchaseEntityId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
        public string BuyerName { get; set; }
        public string StreetAddress { get; set; }
        public string AptNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string BuyerEmail { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
