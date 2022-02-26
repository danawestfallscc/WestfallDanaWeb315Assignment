using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InBloom.Models;

    public class FlowerContext : DbContext
    {
        public FlowerContext (DbContextOptions<FlowerContext> options)
            : base(options)
        {
        }

        public DbSet<InBloom.Models.Flower> Flower { get; set; }
    }
