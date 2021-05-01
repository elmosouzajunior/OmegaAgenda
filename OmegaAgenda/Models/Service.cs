using System.Collections.Generic;

namespace OmegaAgenda.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceDescription { get; set; }

        public Service()
        {
        }

        public Service(int id, string serviceDescription)
        {
            Id = id;
            ServiceDescription = serviceDescription;
        }
    }
}
