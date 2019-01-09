using RedStarter.API.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Purchase
{
    public class PurchaseListItemRequest
    {
        public int PurchaseId { get; set; }

        public virtual PaintingGetByIdRequest Painting { get; set; }
    }
}
