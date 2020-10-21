using Customer.Domain.Dtos;

namespace Customer.Service.Dxos
{
    public interface IBusMapper
    {
        BusDto MapCustomerDto(Domain.Models.Bus customer);
    }
}