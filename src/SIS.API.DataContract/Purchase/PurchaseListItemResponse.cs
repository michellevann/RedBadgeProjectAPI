using RedStarter.API.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Purchase
{
    public class PurchaseListItemResponse
    {
        public int PurchaseId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }

        public virtual PaintingResponse Painting { get; set; }
    }
}
