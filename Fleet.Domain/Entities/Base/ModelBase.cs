using System;

namespace Customer.Domain.Models
{
    public class ModelBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public ModelBase()
        {
            if (this.Id == new Guid())
            {
                this.Id = Guid.NewGuid();
            }
        }
    }
}