﻿using CL.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CL.Data.Context
{
    public class CLContext : DbContext
    {
        public CLContext(DbContextOptions<CLContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        
    }
}