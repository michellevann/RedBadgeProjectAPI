using AutoMapper;
using RedStarter.API.DataContract.Purchase;
using RedStarter.Business.DataContract.Purchase;
using RedStarter.Business.DataContract.Purchase.DTOs;
using RedStarter.Database.DataContract.Purchase;
using RedStarter.Database.DataContract.Purchase.RAOs;
using RedStarter.Database.Entities.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class PurchaseMappingProfile : Profile
    {
        public PurchaseMappingProfile()
        {
            CreateMap<PurchaseCreateRequest, PurchaseCreateDTO>();
            CreateMap<PurchaseCreateDTO, PurchaseCreateRAO>();
            CreateMap<PurchaseCreateRAO, PurchaseEntity>();

            CreateMap<PurchaseEntity, PurchaseListItemRAO>();
            CreateMap<PurchaseListItemRAO, PurchaseListItemDTO>();
            CreateMap<PurchaseListItemDTO, PurchaseListItemResponse>();

            CreateMap<PurchaseCreateChargeRequest, PurchaseCreateChargeDTO>();
            CreateMap<PurchaseCreateChargeDTO, PurchaseCreateChargeRAO>();
            CreateMap<PurchaseCreateChargeRAO, PurchaseEntity>();
        }

    }
}
