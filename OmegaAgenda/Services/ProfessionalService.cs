using Microsoft.EntityFrameworkCore;
using OmegaAgenda.Data;
using OmegaAgenda.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaAgenda.Services
{
    public class ProfessionalService
    {
        private readonly OmegaAgendaContext _context;

        public ProfessionalService(OmegaAgendaContext context)
        {
            _context = context;
        }

        public async Task<List<Professional>> FindAllAsync()
        {
            return await _context.Professional.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task InsertAsync(Professional obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
