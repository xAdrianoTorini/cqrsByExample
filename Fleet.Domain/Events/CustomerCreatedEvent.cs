using System;
using MediatR;

namespace Customer.Domain.Events
{
    public class BusCreatedEvent : INotification
    {
        public Guid Id { get; }

        public BusCreatedEvent(Guid id)
        {
            this.Id = id;
        }
    }
}