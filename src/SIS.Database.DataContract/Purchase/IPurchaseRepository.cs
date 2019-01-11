using RedStarter.Database.DataContract.Purchase.RAOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Purchase
{
    public interface IPurchaseRepository
    {
        Task<bool> CreatePurchase(PurchaseCreateRAO rao);
        Task<IEnumerable<PurchaseListItemRAO>> GetPurchases();
        Task<PurchaseListItemRAO> GetPurchaseById(int id);
        Task<bool> DeletePurchaseById(int id);
    }


}
