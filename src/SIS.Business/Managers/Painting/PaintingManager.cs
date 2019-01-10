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

        public async Task<IEnumerable<PaintingGetListItemDTO>> GetPaintings()
        {
            var rao = await _repository.GetPaintings();
            var dto = _mapper.Map<IEnumerable<PaintingGetListItemDTO>>(rao);

            return dto;
        }

        public async Task<PaintingGetListItemDTO> GetPaintingById(int id)
        {
            var rao = await _repository.GetPaintingById(id);
            var dto = _mapper.Map<PaintingGetListItemDTO>(rao);

            return dto;
        }

        public async Task<bool> DeletePainting(int id)
        {
            if (await _repository.DeletePainting(id))
                return true;

            throw new Exception();
        }

        public async Task<bool> UpdatePainting(PaintingUpdateDTO dto)
        {
            var rao = _mapper.Map<PaintingUpdateRAO>(dto);

            if (await _repository.UpdatePainting(rao)) //postman problem
                return true;

            throw new Exception();
        }
    }
}
