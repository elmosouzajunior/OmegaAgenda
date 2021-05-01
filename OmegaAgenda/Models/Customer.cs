using System.Collections.Generic;

namespace OmegaAgenda.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Scheduling> Schedules { get; set; } = new List<Scheduling>();

        public Customer()
        {
        }

        public Customer(int id, string name, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;            
        }
    }
}
