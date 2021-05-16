using Microsoft.EntityFrameworkCore;
using OmegaAgenda.Data;
using OmegaAgenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaAgenda.InternalServices
{
    public class SchedulingServices
    {
        private readonly OmegaAgendaContext _context;

        public SchedulingServices(OmegaAgendaContext context)
        {
            _context = context;
        }

        public async Task<List<Scheduling>> FindAllAsync()
        {
            return await _context.Scheduling.ToListAsync();
        }

        public async Task InsertAsync(Scheduling obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Scheduling> FindByIdAsync(int id)
        {
            return await _context.Scheduling
                .Include(obj => obj.Customer)
                .Include(obj => obj.Professional)
                .FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Scheduling.Find(id);
            _context.Scheduling.Remove(obj);
            _context.SaveChanges();
        }
    }
}
