using OmegaAgenda.Models.Enums;
using System;
using System.Collections.Generic;

namespace OmegaAgenda.Models
{
    public class Scheduling
    {
        public int Id { get; set; }
        public Professional Professional { get; set; }
        public Customer CustomerName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
        public SchedulingStatus Status { get; set; }

        public Scheduling()
        {
        }

        public Scheduling(int id, Professional professional, Customer customerName, DateTime startTime, DateTime endTime, SchedulingStatus status)
        {
            Id = id;
            Professional = professional;
            CustomerName = customerName;
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
        }
    }
}
