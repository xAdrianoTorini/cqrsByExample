using System;
using System.Threading;
using System.Threading.Tasks;
using Customer.Data.IRepositories;
using Customer.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Customer.Service.Subcribers
{
    public class BusCreatedHandler : INotificationHandler<BusCreatedEvent>
    {
        private readonly IBusRepository busRepository;
        private readonly ILogger _logger;

        public BusCreatedHandler(IBusRepository busRepository, ILogger<BusCreatedHandler> logger)
        {
            this.busRepository = busRepository;
            _logger = logger;
        }

        public Task Handle(BusCreatedEvent notification, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}