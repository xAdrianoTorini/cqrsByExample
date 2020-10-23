using System.ComponentModel.DataAnnotations;
using Customer.Domain.Dtos;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Customer.Domain.Commands
{
    public class CreateBusCommand : CommandBase<BusDto>
    {

        [JsonProperty("License")]
        [Required]
        [MaxLength(10)]
        public string License { get; set; }

        [JsonProperty("Assembler")]
        [Required]
        [MaxLength(255)]
        public string Assembler { get; set; }

        

        [JsonProperty("Model")]
        [Required]
        [MaxLength(255)]
        public string Model { get; set; }

        public CreateBusCommand()
        {
        }

        [JsonConstructor]
        public CreateBusCommand(string license, string assembler, string model)
        {
            License = license;
            Assembler = assembler;
            Model = model;
        }
    }
}