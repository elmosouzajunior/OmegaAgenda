using Microsoft.EntityFrameworkCore;
using OmegaAgenda.Data;
using OmegaAgenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaAgenda.InternalServices
{
    public class ServiceServices
    {
        private readonly OmegaAgendaContext _context;

        public ServiceServices(OmegaAgendaContext context)
        {
            _context = context;
        }

        public async Task<List<Service>> FindAllAsync()
        {
            return await _context.Service.OrderBy(x => x.ServiceName).ToListAsync();
        }
    }
}
