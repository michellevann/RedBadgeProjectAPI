using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Painting;
using RedStarter.Business.DataContract.Painting;

namespace RedStarter.API.Controllers.Painting
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class PaintingController : Controller
    {
        private readonly IMapper _mapper;

        public PaintingController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostPainting(PaintingCreateRequest request)
        {           
            var dto = _mapper.Map<PaintingCreateDTO>(request);
            dto.DateAdded = DateTime.Now;

            return Ok();
        }
    }
}