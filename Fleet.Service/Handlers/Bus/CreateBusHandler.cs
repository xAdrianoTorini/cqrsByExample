using System;
using System.Threading;
using System.Threading.Tasks;
using Customer.Data.IRepositories;
using Customer.Domain.Commands;
using Customer.Domain.Dtos;
using Customer.Service.Dxos;
using MediatR;

namespace Customer.Service.Services
{
    public class CreateBusHandler : IRequestHandler<CreateBusCommand, BusDto>
    {
        private readonly IBusMapper _customerDxos;
        private readonly IBusRepository _busRepository;
        private readonly IMediator _mediator;

        public CreateBusHandler(IBusRepository busRepository, IMediator mediator, IBusMapper customerDxos)
        {
            this._busRepository = busRepository;
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _customerDxos = customerDxos ?? throw new ArgumentNullException(nameof(customerDxos));
        }


        public async  Task<BusDto> Handle(CreateBusCommand request, CancellationToken cancellationToken)
        {
            
            return default;
        }
    }
}