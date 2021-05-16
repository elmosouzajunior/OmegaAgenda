using Microsoft.EntityFrameworkCore;
using OmegaAgenda.Data;
using OmegaAgenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmegaAgenda.InternalServices
{
    public class CustomerServices
    {
        private readonly OmegaAgendaContext _context;

        public CustomerServices(OmegaAgendaContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> FindAllAsync()
        {
            return await _context.Customer.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Customer> FindByIdAsync(int id)
        {
            return await _context.Customer.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(Customer obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
