using System;
using System.ComponentModel.DataAnnotations;
using Fleet.Domain.Dtos.Bus;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Customer.Domain.Commands
{
    public class UpdateBusCommand : CommandBase<UpdateResult>
    {

        [JsonProperty("License")]
        [MaxLength(10)]
        public string License { get; set; }

        [JsonProperty("Assembler")]
        [MaxLength(255)]
        public string Assembler { get; set; }
        
        [JsonProperty("Model")]
        public string Model { get; set; }
        
        [JsonProperty("Id")]
        [MaxLength(255)]
        public string Id { get; set; }

        public UpdateBusCommand()
        {
        }

        [JsonConstructor]
        public UpdateBusCommand(string id, string license, string assembler, string model)
        {
            License = license;
            Assembler = assembler;
            Model = model;
            Id = id;
           
        }
    }
}