using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Purchase;
using RedStarter.Business.DataContract.Purchase;
using RedStarter.Database.DataContract.Purchase;

namespace RedStarter.API.Controllers.Purchase
{
    [AllowAnonymous]
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

        [HttpPost]
        //[Authorize(Roles = "Admin")] //the only peoeple who can add a product are people that are authorized. THey have to match the SeedRepository
        public async Task<IActionResult> PostPurchase(PurchaseCreateRequest request)
        {

            if (!ModelState.IsValid) 
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value); //what this does: handy little tool to see who is associated with the incoming request. Takes token, goes into DB and checks it out

            var dto = _mapper.Map<PurchaseCreateDTO>(request);
            dto.PurchaseDate = DateTime.Now;
            dto.OwnerId = identityClaimNum;

            if (await _manager.CreatePurchase(dto))
                return StatusCode(201);

            throw new Exception(); 
        }

        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetPurchases()
        {
            if (!ModelState.IsValid) //want this to check 
            {
                return StatusCode(400);
            }

            //var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetPurchases();
            var response = _mapper.Map<IEnumerable<PurchaseListItemResponse>>(dto);

            return Ok(response); //TODO : Handle exceptions
        }

        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetPurchaseById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetPurchaseById();
            var response = _mapper.Map<PurchaseListItemResponse>(dto);

            return Ok(response); //TODO: Handle Exceptions
        }

    }

}


