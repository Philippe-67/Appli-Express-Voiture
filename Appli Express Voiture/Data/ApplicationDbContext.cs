﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Appli_Express_Voiture.Models;

namespace Appli_Express_Voiture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Appli_Express_Voiture.Models.Voiture> Voiture { get; set; } = default!;
        public DbSet<Appli_Express_Voiture.Models.Reparation> Reparation { get; set; } = default!;
    }
}