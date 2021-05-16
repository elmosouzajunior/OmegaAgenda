using System.Collections.Generic;

namespace OmegaAgenda.Models.ViewModels
{
    public class SchedulingFormViewModel
    {
        public Scheduling Scheduling { get; set; }
        public ICollection<Professional> Professionals { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
