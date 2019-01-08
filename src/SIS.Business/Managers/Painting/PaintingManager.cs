using AutoMapper;
using RedStarter.Business.DataContract.Painting;
using RedStarter.Database.DataContract.Painting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Painting
{
    public class PaintingManager : IPaintingManager
    {
        private readonly IMapper _mapper;
        private readonly IPaintingRepository _repository;

        public PaintingManager(IMapper mapper, IPaintingRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreatePainting(PaintingCreateDTO dto)
        {
            var rao = _mapper.Map<PaintingCreateRAO>(dto);

            if (await _repository.CreatePainting(rao))
                return true;

            throw new NotImplementedException();
        }
    }
}
