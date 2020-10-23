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
        /// <param name="command">Create a new Bus</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateBusAsync([FromBody]CreateBusCommand command)
        {
            return Ok(await CommandAsync(command));
        }

        /// <summary>
        /// Remove Bus 
        /// </summary>
        /// <param name="command">Remove a Bus</param>
        /// <returns></returns>
        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Delete(Guid guid)
        {
            return Ok(await CommandAsync(new RemoveBusCommand(guid)));
        }
        /// <summary>
        /// Updated Bus 
        /// </summary>
        /// <param name="command">Update a Bus</param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Put([FromBody]UpdateBusCommand command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}