using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OmegaAgenda.Models;

namespace OmegaAgenda.Data
{
    public class SeedingService
    {
        private OmegaAgendaContext _context;

        public SeedingService(OmegaAgendaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Professional.Any() || 
                _context.Customer.Any() || 
                _context.Scheduling.Any() ||
                _context.Service.Any())
            {
                return; // DB has been seeded
            }

            Professional p1 = new Professional(1, "Patyanne Carvalho");
            Professional p2 = new Professional(2, "Pammela Carvalho");

            Customer c1 = new Customer(1, "Elmo Junior", "elmojunior@gmail.com", "83981143844");
            Customer c2 = new Customer(2, "Antonio Ernesto", "antonio@gmail.com", "38981143844");
            Customer c3 = new Customer(3, "Gustavo Henrique", "gs@gmail.com", "61981143844");

            Service s1 = new Service(1, "Capilar", "");
            Service s2 = new Service(2, "Limpeza de Pele", "");
            Service s3 = new Service(3, "Enzimas", "");

            _context.Professional.AddRange(p1, p2);
            _context.Customer.AddRange(c1, c2, c3);
            _context.Service.AddRange(s1, s2, s3);

            _context.SaveChanges();
        }
    }
}
