using RedStarter.Business.DataContract.Purchase.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Purchase
{
    public interface IStripeEngine
    {
        Task<bool> CreateCharge(PurchaseCreateChargeDTO dto);
    }
}
