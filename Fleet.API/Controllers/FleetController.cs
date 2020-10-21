using System;
using System.Threading.Tasks;
using Customer.Domain.Commands;
using Customer.Domain.Dtos;
using Customer.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{

    public class FleetController : ApiControllerBase

    {
        public FleetController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Get customer by id
        /// </summary>
        /// <param name="id">Id of customer</param>
        /// <returns>Customer information</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BusDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<BusDto>> GetCustomerAsync(Guid id)
        {
            return Single(await QueryAsync(new GetBusQuery(id)));
        }

        /// <summary>
        /// Create new customer
        /// </summary>
        /// <param name="command">Info of customer</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateCustomerAsync([FromBody] CreateBusCommand command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}