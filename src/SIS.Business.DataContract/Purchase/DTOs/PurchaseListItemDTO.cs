using RedStarter.Business.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.DataContract.Purchase.DTOs
{
    public class PurchaseListItemDTO
    {
        public int PaintingEntityId { get; set; }
        public int PurchaseId { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
    }
}
