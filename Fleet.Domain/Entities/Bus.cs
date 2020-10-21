using System;

namespace Customer.Domain.Models
{
    public class Bus : ModelBase
    {
        public Guid Id { get; set; }
        public string License { get; set; }
        public string Assembler { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public Bus(Guid id, string license, string assembler, int year, string model)
        {
            Id = id;
            License = license;
            Assembler = assembler;
            Year = year;
            Model = model;
        }
    }
}