using GEZ.Core.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZ.Persistence
{
    public class GezDatabaseContext: DbContext
    {
        public GezDatabaseContext(DbContextOptions<GezDatabaseContext> options) : base(options)
        {
        }


        public DbSet<Customer> Customers { get;set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
