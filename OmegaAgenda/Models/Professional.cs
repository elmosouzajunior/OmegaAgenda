using System.Collections.Generic;

namespace OmegaAgenda.Models
{
    public class Professional
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Scheduling> Schedules { get; set; } = new List<Scheduling>();

        public Professional()
        {            
        }

        public Professional(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
