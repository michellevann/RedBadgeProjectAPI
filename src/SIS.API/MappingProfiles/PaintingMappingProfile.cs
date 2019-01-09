using AutoMapper;
using RedStarter.API.DataContract.Painting;
using RedStarter.Business.DataContract.Painting;
using RedStarter.Database.DataContract.Painting;
using RedStarter.Database.Entities.Painting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class PaintingMappingProfile : Profile
    {
        public PaintingMappingProfile()
        {
            CreateMap<PaintingCreateRequest, PaintingCreateDTO>();
            CreateMap<PaintingCreateDTO, PaintingCreateRAO>();
            CreateMap<PaintingCreateRAO, PaintingEntity>();

            CreateMap<PaintingEntity, PaintingGetListItemRAO>();
            CreateMap<PaintingGetListItemRAO, PaintingGetListItemDTO>();
            CreateMap<PaintingGetListItemDTO, PaintingResponse>();
        }
    }
}
