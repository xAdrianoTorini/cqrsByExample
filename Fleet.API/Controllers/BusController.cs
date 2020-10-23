using System;
using System.Threading.Tasks;
using Customer.Domain.Commands;
using Customer.Domain.Dtos;
using Customer.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{

    public class BusController : ApiControllerBase

    {
        public BusController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Get bus by id
        /// </summary>
        /// <param name="id">Id of the bus</param>
        /// <returns>Customer information</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BusDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<BusDto>> GetBusAsync(Guid id)
        {
            return Single(await QueryAsync(new GetBusQuery(id)));
        }

        /// <summary>
        /// Create new bus
        /// </summary>
        /// <param name="command">Info of the Bus</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateBusAsync(CreateBusCommand command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}