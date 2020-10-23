using System;
using System.ComponentModel.DataAnnotations;
using Customer.Domain.Dtos;
using Fleet.Domain.Dtos.Bus;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Customer.Domain.Commands
{
    public class UpdateBusCommand : CommandBase<UpdateResult>
    {

        [JsonProperty("License")]
        [Required]
        [MaxLength(10)]
        public string License { get; set; }

        [JsonProperty("Assembler")]
        [Required]
        [MaxLength(255)]
        public string Assembler { get; set; }

        [JsonProperty("Year")]
        [Required]
        [MaxLength(4)]
        public int Year { get; set; }

        [JsonProperty("Model")]
        [Required]
        [MaxLength(255)]
        public string Model { get; set; }
        [JsonProperty("Id")]
        [Required]
        [MaxLength(255)]
        public Guid Id { get; set; }

        public UpdateBusCommand()
        {
        }

        [JsonConstructor]
        public UpdateBusCommand(Guid id, string license, string assembler, int year, string model)
        {
            License = license;
            Assembler = assembler;
            Year = year;
            Model = model;
            Id = id;
           
        }
    }
}