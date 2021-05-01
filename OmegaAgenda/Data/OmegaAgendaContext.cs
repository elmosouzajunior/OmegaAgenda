using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OmegaAgenda.Models;

namespace OmegaAgenda.Data
{
    public class OmegaAgendaContext : DbContext
    {
        public OmegaAgendaContext (DbContextOptions<OmegaAgendaContext> options)
            : base(options)
        {
        }

        public DbSet<OmegaAgenda.Models.Professional> Professional { get; set; }
    }
}
