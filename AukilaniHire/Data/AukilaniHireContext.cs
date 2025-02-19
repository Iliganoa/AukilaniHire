﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AukilaniHire.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class AukilaniHireContext : IdentityDbContext
{
    public AukilaniHireContext(DbContextOptions<AukilaniHireContext> options)
        : base(options)
    {
    }

    public DbSet<AukilaniHire.Models.Member> Member { get; set; } = default!;


    public DbSet<AukilaniHire.Models.Booking> Booking { get; set; } = default!;

    public DbSet<AukilaniHire.Models.Room> Room { get; set; } = default!;
}
