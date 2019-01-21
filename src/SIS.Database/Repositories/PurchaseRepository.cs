using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Purchase;
using RedStarter.Database.DataContract.Purchase.RAOs;
using RedStarter.Database.Entities.Purchase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Purchase
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public PurchaseRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreatePurchase(PurchaseCreateChargeRAO rao)
        {
            var entity = _mapper.Map<PurchaseEntity>(rao);

            await _context.PurchaseTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<PurchaseListItemRAO>> GetPurchases()
        {
            var query = await _context.PurchaseTableAccess.ToArrayAsync();
            var rao = _mapper.Map<IEnumerable<PurchaseListItemRAO>>(query);

            return rao;
        }

        public async Task<PurchaseListItemRAO> GetPurchaseById(int id)
        {
            var query = await _context.PurchaseTableAccess.SingleAsync(e => e.PurchaseId == id);
            var rao = _mapper.Map<PurchaseListItemRAO>(query);

            return rao;
        }

        public async Task<bool> DeletePurchaseById(int id)
        {
            var entity = await _context.PurchaseTableAccess.SingleAsync(e => e.PurchaseId == id);
            _context.Remove(entity);

            return await _context.SaveChangesAsync() == 1;
        }

    }
}
