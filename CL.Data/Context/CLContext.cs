using CL.Core.Domain;
using CL.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CL.Data.Context
{
    public class CLContext : DbContext
    {
        public CLContext(DbContextOptions<CLContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        }

    }
}