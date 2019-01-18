using AutoMapper;
using RedStarter.Business.DataContract.Purchase;
using RedStarter.Business.DataContract.Purchase.DTOs;
using RedStarter.Database.DataContract.Purchase;
using RedStarter.Database.DataContract.Purchase.RAOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Purchase
{
    public class PurchaseManager : IPurchaseManager
    {
        private readonly IMapper _mapper;
        private readonly IPurchaseRepository _repository;
        private readonly IStripeEngine _stripe;

        public PurchaseManager(IMapper mapper, IPurchaseRepository repository, IStripeEngine stripe)
        {
            _mapper = mapper;
            _repository = repository;
           _stripe = stripe;
        }

        public async Task<bool> CreatePurchase(PurchaseCreateDTO dto)
        {
            var rao = _mapper.Map<PurchaseCreateRAO>(dto);

            if (await _repository.CreatePurchase(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<bool> CreateCharge(PurchaseCreateChargeDTO dtoToken)
        {
            var rao = _mapper.Map<PurchaseCreateChargeRAO>(dtoToken);
            var dto = _stripe.CreateCharge(dtoToken);

            if (await _repository.CreateCharge(rao))
                return true;

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PurchaseListItemDTO>> GetPurchases()
        {
            var rao = await _repository.GetPurchases();
            var dto = _mapper.Map<IEnumerable<PurchaseListItemDTO>>(rao);

            return dto;
        }

        public async Task<PurchaseListItemDTO> GetPurchaseById(int id)
        {
            var rao = await _repository.GetPurchaseById(id);
            var dto = _mapper.Map<PurchaseListItemDTO>(rao);

            return dto;
        }

        public async Task<bool> DeletePurchaseById(int id)
        {
            if (await _repository.DeletePurchaseById(id))
                return true;

            throw new Exception();
        }

    }
}

