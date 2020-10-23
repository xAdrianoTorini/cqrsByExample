using System;
using System.Threading;
using System.Threading.Tasks;
using Customer.Data.IRepositories;
using Customer.Domain.Commands;
using Customer.Service.Dxos;
using Fleet.Domain.Dtos.Bus;
using MediatR;

namespace Customer.Service.Services
{
    public class RemoveBusHandler : IRequestHandler<RemoveBusCommand, RemoveResult>
    {
        private readonly IBusRepository _busRepository;
        private readonly IBusMapper _customerDxos;

        public RemoveBusHandler(IBusRepository busRepository, IBusMapper customerDxos)
        {
            this._busRepository = busRepository;
            _customerDxos = customerDxos ?? throw new ArgumentNullException(nameof(customerDxos));
        }

        public async Task<RemoveResult> Handle(RemoveBusCommand request, CancellationToken cancellationToken)
        {
            return new RemoveResult(this._busRepository.Remove(request.Id));
        }
    }
}