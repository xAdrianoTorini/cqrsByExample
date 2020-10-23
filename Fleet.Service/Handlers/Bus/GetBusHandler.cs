using System;
using System.Threading;
using System.Threading.Tasks;
using Customer.Data.IRepositories;
using Customer.Domain.Dtos;
using Customer.Domain.Queries;
using Customer.Service.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Customer.Service.Services
{
    public class GetBusHandler : IRequestHandler<GetBusQuery, BusDto>
    {
        private readonly IBusRepository _busRepository;
        private readonly IBusMapper _customerDxos;

        public GetBusHandler(IBusRepository busRepository, IBusMapper customerDxos)
        {
            this._busRepository = busRepository;
            _customerDxos = customerDxos ?? throw new ArgumentNullException(nameof(customerDxos));
        }

        public async Task<BusDto> Handle(GetBusQuery request, CancellationToken cancellationToken)
        {
            return _customerDxos.MapCustomerDto(_busRepository.Get(request.Id));
        }
    }
}