using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentMotobike.BAL.Interface;
using RentMotobike.Domain.Request.Motobike;
using RentMotobike.Domain.Respone.Motobike;

namespace RentMotobike.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotobikeController : ControllerBase
    {
        private readonly IMotobikeService motobikeService;

        public MotobikeController(IMotobikeService _motobikeService)
        {
            motobikeService = _motobikeService;
        }
        // GET api/values
        [HttpGet]
        [Route("ListMotobike")]
        public IEnumerable<MotobikeReq> ListMotobike()
        {
            return motobikeService.ListMotobike();
        }

        // GET api/values/5
        [HttpGet]
        [Route("GetMotobikeById/{id}")]
        public MotobikeReq GetMotobikeById(int id)
        {
            return motobikeService.GetMotobikeById(id);
        }

        // POST api/values
        [HttpPost]
        [Route("CreateMotobike")]
        public MotobikeRes CreateMotobike([FromBody] MotobikeReq request)
        {
            return motobikeService.CreateMotobike(request);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("UpdateMotobike/{id}")]
        public MotobikeRes UpdateMotobike(int id, [FromBody] MotobikeReq request)
        {
            return motobikeService.UpdateMotobike(id, request);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("DeleteMotobike/{id}")]
        public bool DeleteMotobike(int id)
        {
            return motobikeService.DeleteMotobike(id);
        }
    }
}
