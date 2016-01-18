using EL.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.DAL
{
    public class EntryContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }

        public DbSet<ELEntry> ELEntries { get; set; }
        public DbSet<EntryUpdate> Updates { get; set; }

    }
}
