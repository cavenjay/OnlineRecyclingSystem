using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineRecyclingSystem.Models;

namespace OnlineRecyclingSystem.Data
{
    public class OnlineRecyclingSystemOrder : DbContext
    {
        public OnlineRecyclingSystemOrder (DbContextOptions<OnlineRecyclingSystemOrder> options)
            : base(options)
        {
        }

        public DbSet<OnlineRecyclingSystem.Models.Order> Order { get; set; }
    }
}
