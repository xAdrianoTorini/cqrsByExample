using System;
using Customer.Domain.Dtos;
using Fleet.Domain.Dtos.Bus;
using Newtonsoft.Json;

namespace Customer.Domain.Commands
{
    public class RemoveBusCommand : CommandBase<RemoveResult>
    {
        public Guid Id { get; set; }
        public RemoveBusCommand()
        {
        }

        [JsonConstructor]
        public RemoveBusCommand(Guid id)
        {
            this.Id = id;
        }
    }
}