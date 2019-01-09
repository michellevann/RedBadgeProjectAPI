using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Painting;
using RedStarter.Database.Entities.Painting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Painting
{
    public class PaintingRepository : IPaintingRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public PaintingRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreatePainting(PaintingCreateRAO rao)
        {
            var entity = _mapper.Map<PaintingEntity>(rao);

            await _context.PaintingTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<IEnumerable<PaintingGetListItemRAO>> GetPaintings()
        {
            var query = await _context.PaintingTableAccess.ToArrayAsync();
            var array = _mapper.Map<IEnumerable<PaintingGetListItemRAO>>(query);

            return array;
        }

        public async Task<PaintingGetListItemRAO> GetPaintingById(int id)
        {
            var query = await _context.PaintingTableAccess.SingleAsync(e => e.PaintingEntityId == id);
            var rao = _mapper.Map<PaintingGetListItemRAO>(query);

            return rao;
        }
    }
}
