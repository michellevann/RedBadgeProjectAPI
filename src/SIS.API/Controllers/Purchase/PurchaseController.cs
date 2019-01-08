using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedStarter.Business.DataContract.Purchase;
using RedStarter.Database.DataContract.Purchase;

namespace RedStarter.API.Controllers.Purchase
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPurchaseManager _manager;

        public PurchaseController(IMapper mapper, IPurchaseManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

    }

}
