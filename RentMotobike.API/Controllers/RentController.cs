using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentMotobike.BAL.Interface;
using RentMotobike.Domain.Request.Rent;
using RentMotobike.Domain.Respone;

namespace RentMotobike.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly IRentService rentService;

        public RentController(IRentService _rentService)
        {
            rentService = _rentService;
        }

        // GET api/values
        [HttpGet]
        [Route("ListRent")]
        public IEnumerable<RentReq> ListRent()
        {
            return rentService.ListRent();
        }

        // GET api/values/5
        [HttpGet]
        [Route("GetRentById/{id}")]
        public RentReq GetRentById(int id)
        {
            return rentService.GetRentById(id);
        }

        // POST api/values
        [HttpPost]
        [Route("CreateRent")]
        public RentRes CreateRent([FromBody] RentReq request)
        {
            return rentService.CreateRent(request);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("UpdateRent/{id}")]
        public RentRes UpdateRent(int id, [FromBody] RentReq request)
        {
            return rentService.UpdateRent(id, request);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("DeleteRent/{id}")]
        public bool DeleteRent(int id)
        {
            return rentService.DeleteRent(id);
        }
    }
}