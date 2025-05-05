﻿using Microsoft.EntityFrameworkCore;

namespace AplicationClick.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Imovel> Imoveis { get; set; }  

    }
}
    