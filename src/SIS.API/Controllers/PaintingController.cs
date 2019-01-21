using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        private readonly IPaintingManager _manager;

        public PaintingController(IMapper mapper, IPaintingManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> PostPainting([FromForm]PaintingCreateRequest request)
        {    
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            //var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var dto = _mapper.Map<PaintingCreateDTO>(request);
            dto.DateAdded = DateTime.Now;

            //var dtoImage = _mapper.Map<PaintingImageDTO>(image);
            //var success = await _manager.UploadPaintingImage(dtoImage);

            if (await _manager.CreatePainting(dto))
                return StatusCode(201);

            throw new Exception();
        }

        [HttpPut("{id}")]
        //[Authorize]
        public async Task<IActionResult> UpdatePainting([FromForm]PaintingUpdateRequest request, int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<PaintingUpdateDTO>(request);
            dto.PaintingEntityId = id;

            if (await _manager.UpdatePainting(dto))
                return StatusCode(202);

            throw new Exception();
        }

        [HttpGet]
        //[Authorize]
        public async Task<IActionResult> GetPaintings()
        {
           if (!ModelState.IsValid)
           {
                return StatusCode(400);
           }

            var dto = await _manager.GetPaintings();
            var response = _mapper.Map<IEnumerable<PaintingResponse>>(dto);

            return Ok(response);
                //.OrderByDescending(d => d.DateAdded);
        }

        [HttpGet("{id}")]
        //[Authorize]
        public async Task<IActionResult> GetPaintingById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = await _manager.GetPaintingById(id);
            var response = _mapper.Map<PaintingGetByIdRequest>(dto);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        //[Authorize]
        public async Task<IActionResult> DeletePainting(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            if (await _manager.DeletePainting(id))
                return StatusCode(217);

            throw new Exception();
        }

        //[HttpPost("UploadPaintingImage")]
        //public async Task<IActionResult> UploadPaintingImage([FromForm]PaintingImageRequest image)
        //{
        //    var dtoImage = _mapper.Map<PaintingImageDTO>(image);
        //    var success = await _manager.UploadPaintingImage(dtoImage);
        //    return Ok(); //TODO: make statuscode 201?
        //}
    }
}