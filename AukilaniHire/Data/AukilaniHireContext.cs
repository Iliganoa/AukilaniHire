using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AukilaniHire.Models;

    public class AukilaniHireContext : DbContext
    {
        public AukilaniHireContext (DbContextOptions<AukilaniHireContext> options)
            : base(options)
        {
        }

        public DbSet<AukilaniHire.Models.Member> Member { get; set; } = default!;
    }
