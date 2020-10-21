using System;
using System.ComponentModel.DataAnnotations;
using Customer.Domain.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Customer.Domain.Queries
{
    public class GetBusQuery : QueryBase<BusDto>
    {
        public GetBusQuery()
        {
        }

        [JsonConstructor]
        public GetBusQuery(Guid customerId)
        {
            CustomerId = customerId;
        }

        [JsonProperty("id")]
        [Required]
        public Guid CustomerId { get; set; }
    }
}