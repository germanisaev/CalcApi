using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Models
{
    public class CalculateContext: DbContext
    {
        public CalculateContext(DbContextOptions<CalculateContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<MathOperators> MathOperators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[] {
                new User{id=1, firstName="Shalom", lastName="Israel", username="admin", password="nimda"}
            });

            modelBuilder.Entity<MathOperators>().HasData(new MathOperators[] {
                new MathOperators{Id=1, Operator='+'},
                new MathOperators{Id=2, Operator='-'},
                new MathOperators{Id=3, Operator='*'},
                new MathOperators{Id=4, Operator='/'},
            });
        }
    }
}
