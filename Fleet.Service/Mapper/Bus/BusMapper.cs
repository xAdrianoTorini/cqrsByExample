using AutoMapper;
using Customer.Domain.Dtos;

namespace Customer.Service.Dxos
{
    public class BusMapper : IBusMapper
    {
        private readonly IMapper _mapper;

        public BusMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Domain.Models.Bus, Domain.Dtos.BusDto>()
                    .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dst => dst.License, opt => opt.MapFrom(src => src.License))
                    .ForMember(dst => dst.Model, opt => opt.MapFrom(src => src.Model))
                    .ForMember(dst => dst.Year, opt => opt.MapFrom(src => src.Year));
            });

            _mapper = config.CreateMapper();
        }
        
        public BusDto MapCustomerDto(Domain.Models.Bus customer)
        {
            return _mapper.Map<Domain.Models.Bus, Domain.Dtos.BusDto>(customer);
        }
    }
}