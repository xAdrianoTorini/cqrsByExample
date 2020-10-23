using System;
using Newtonsoft.Json;

namespace Customer.Domain.Dtos
{
    public class BusDto
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("License")]
        public string License { get; set; }
        [JsonProperty("Model")]
        public string Model { get; set; }

    }
}