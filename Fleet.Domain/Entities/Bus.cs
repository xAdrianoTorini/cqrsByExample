using System;

namespace Customer.Domain.Models
{
    public class Bus : ModelBase
    {
        public string License { get; set; }
        public string Assembler { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public Bus(string license, string assembler, int year, string model)
        {
            License = license;
            Assembler = assembler;
            Year = year;
            Model = model;
        }

        public Bus(Guid id, string license, string assembler, int year, string model)
        {
            License = license;
            Assembler = assembler;
            Year = year;
            Model = model;
            Id = id;
        }
    }
}