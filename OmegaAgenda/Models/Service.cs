using System.Collections.Generic;

namespace OmegaAgenda.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }


        public Service()
        {
        }

        public Service(int id, string serviceName, string serviceDescription)
        {
            Id = id;
            ServiceName = serviceName;
            ServiceDescription = serviceDescription;
        }
    }
}
