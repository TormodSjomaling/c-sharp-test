using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSMediatR.Models;
using CQRSMediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatR.Controllers
{
    [Route("api/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMediator mediator;
        
        public CarController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()//[FromForm] GetAllCarsQuery query)
        {
            var query2 = new GetAllCarsQuery();
            var result = await mediator.Send(query2);

            return Ok(result);

            //return mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarByIdCars()//[FromForm] GetAllCarsQuery query)
        {
            var query2 = new GetCarByIdQuery();
            var result = await mediator.Send(query2);

            return Ok(result);

            //return mediator.Send(query);
        }

    }
}
