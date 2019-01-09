using RedStarter.API.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Purchase
{
    public class PurchaseDeleteRequest
    {
        public int PurchaseId { get; set; }

        public virtual PaintingDeleteRequest Painting { get; set; }
    }
}
