using RedStarter.Business.DataContract.Purchase.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Purchase
{
    public interface IPurchaseManager
    {
        Task<bool> CreatePurchase(PurchaseCreateChargeDTO dto);
        Task<IEnumerable<PurchaseListItemDTO>> GetPurchases();
        Task<PurchaseListItemDTO> GetPurchaseById(int id);
        Task<bool> DeletePurchaseById(int id);
        Task<bool> CreateCharge(PurchaseCreateChargeDTO dtoToken);
    }
}
