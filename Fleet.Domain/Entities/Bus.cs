using System;

namespace Customer.Domain.Models
{
    public class Bus : ModelBase
    {
        public string License { get; set; }
        public string Assembler { get; set; }
        public string Model { get; set; }

        public Bus()
        {

        }
        public Bus(string license, string assembler, string model)
        {
            License = license;
            Assembler = assembler;
            Model = model;
        }

        public Bus(Guid id, string license, string assembler, string model)
        {
            License = license;
            Assembler = assembler;
            Model = model;
            Id = id;
        }
    }
}