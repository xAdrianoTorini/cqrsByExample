using System;
using System.Threading;
using System.Threading.Tasks;
using Customer.Data.IRepositories;
using Customer.Domain.Commands;
using Customer.Domain.Dtos;
using Customer.Service.Dxos;
using Fleet.Domain.Dtos.Bus;
using MediatR;

namespace Customer.Service.Services
{
    public class UpdateBusHandler : IRequestHandler<UpdateBusCommand, UpdateResult>
    {
        private readonly IBusRepository _busRepository;
        private readonly IMediator _mediator;

        public UpdateBusHandler(IBusRepository busRepository, IMediator mediator, IBusMapper customerDxos)
        {
            this._busRepository = busRepository;
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async  Task<UpdateResult> Handle(UpdateBusCommand request, CancellationToken cancellationToken)
        {
            var result = _busRepository.Update(new Domain.Models.Bus(request.Id, request.License, request.Assembler, request.Year, request.Model));
            return new UpdateResult(result) ;
        }
    }
}