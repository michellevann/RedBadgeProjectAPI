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
        public Task<bool> CreateCharge(PurchaseCreateChargeDTO dto)
        {
            StripeConfiguration.SetApiKey("sk_test_WGWk6z9utu4sWhJDm52sS0yr");
            var token = dto.Token;
            var options = new ChargeCreateOptions
            {
                Amount = 1099,
                Currency = "usd",
                Description = "example charge",
                SourceId = token,
            };
            var service = new ChargeService();
            Charge charge = service.Create(options);

            throw new NotImplementedException();
        }
    }
}
