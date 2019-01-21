using RedStarter.Business.DataContract.Purchase;
using RedStarter.Business.DataContract.Purchase.DTOs;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Engines
{
    public class StripeEngine : IStripeEngine
    {
        public async Task<bool> CreateCharge(PurchaseCreateChargeDTO dto)
        {
            StripeConfiguration.SetApiKey("sk_test_gzQ0Q1iwmIIX4VqafJj9rcZe");
            var token = dto.Token;
            var options = new ChargeCreateOptions
            {
                Amount = dto.Price,
                Currency = "usd",
                Description = dto.Title,
                SourceId = token,
            };
            var service = new ChargeService();
            Charge charge = service.Create(options);

            //return true;
            if (charge.Status == "succeeded")
                return true;
            throw new NotImplementedException();
        }
    }
}
