using OmegaAgenda.Models.Enums;
using System;
using System.Collections.Generic;

namespace OmegaAgenda.Models
{
    public class Scheduling
    {
        public int Id { get; set; }
        public Professional Professional { get; set; }
        public int ProfessionalId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
        public SchedulingStatus Status { get; set; }

        public Scheduling()
        {
        }

        public Scheduling(int id, Professional professional, Customer customer, DateTime date ,DateTime startTime, DateTime endTime, SchedulingStatus status)
        {
            Id = id;
            Professional = professional;
            Customer = customer;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
        }
    }
}
