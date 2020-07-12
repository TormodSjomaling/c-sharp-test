using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSMediatR.DBContext;
using CQRSMediatR.Models;
using CQRSMediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neo4j.Driver;

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
            //Neo4jDriverClient driver = new Neo4jDriverClient("bolt://localhost:7687", "Neo4j", "test");
            Neo4jDriverClient.Register();
            var driver = Neo4jDriverClient.Neo4jDriver;
            var session = driver.AsyncSession();

            try
            {
                var greeting = await session.WriteTransactionAsync(async tx =>
                {
                    //var result = await tx.RunAsync("CREATE (ee: Car { brand: 'Audi', price: '200K' })");
                    var result = await tx.RunAsync("MATCH (a: Car), (b: Car) WHERE a.brand = 'Audi' AND b.brand = 'Volvo' CREATE(a) -[r: TEST { test: 'jadu' }]->(b)");
                    return Ok("test");

                });
            }
            finally
            {
                await session.CloseAsync();
            }
            //var query2 = new GetCarByIdQuery();
            //var result = await mediator.Send(query2);

            return Ok("test");

            //return mediator.Send(query);
        }

    }
}
