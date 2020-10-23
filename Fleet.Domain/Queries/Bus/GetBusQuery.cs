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
        public GetBusQuery(Guid id)
        {
            Id = id;
        }

        [JsonProperty("id")]
        [Required]
        public Guid Id { get; set; }
    }
}