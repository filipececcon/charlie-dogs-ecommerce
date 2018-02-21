using System;

namespace ChalieDogs.Ecommerce.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Active = true;
        }

        public int Id { get; set; }

        //[JsonIgnore]
        public bool Active { get; set; }

        //[JsonIgnore]
        public DateTime DateUpdate { get; set; }

        //[JsonIgnore]
        public DateTime DateCreate { get; set; }

        public abstract void Validate();
    }
}
