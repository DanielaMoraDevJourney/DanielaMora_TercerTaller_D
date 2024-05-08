using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DanielaMoraTercerTaller.Models;

    public class DanielaMoraTercerTallerContext : DbContext
    {
        public DanielaMoraTercerTallerContext (DbContextOptions<DanielaMoraTercerTallerContext> options)
            : base(options)
        {
        }

        public DbSet<DanielaMoraTercerTaller.Models.Burger> Burger { get; set; } = default!;

public DbSet<DanielaMoraTercerTaller.Models.Promo> Promo { get; set; } = default!;
    }
