using System;
using System.Threading;
using System.Threading.Tasks;
using Customer.Data.IRepositories;
using Customer.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Customer.Service.Subcribers
{
    public class CustomerCreatedHandler : INotificationHandler<CustomerCreatedEvent>
    {
        private readonly IBusRepository busRepository;
        private readonly ILogger _logger;

        public CustomerCreatedHandler(IBusRepository busRepository, ILogger<CustomerCreatedHandler> logger)
        {
            this.busRepository = busRepository;
            _logger = logger;
        }

        public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            return default;
        }
    }
}