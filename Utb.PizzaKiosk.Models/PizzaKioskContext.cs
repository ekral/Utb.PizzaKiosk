using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utb.PizzaKiosk.Models
{
    public class PizzaKioskContext : DbContext
    {
        public DbSet<PizzaOption> PizzaOptions { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var folderPath = Environment.GetFolderPath(folder);
            string filePath = Path.Join(folderPath, "pizzaKiosk.db");

            SqliteConnectionStringBuilder stringBuilder = new()
            {
                DataSource = filePath
            };
        
            optionsBuilder.UseSqlite(stringBuilder.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var options = new PizzaOption[]
            {
                new StringOptions()
                {
                     Id = 1,
                     Description = "Pizza size",
                     Options = new List<string>() { "Small", "Medium", "Large"},
                     DefaultValueIndex = 1
                },
                new BooleanOption()
                {
                     Id = 2,
                     Description = "Garling",
                     DefaultValue = true
                },
                new QuantityOption()
                {
                    Id = 3,
                    Description = "Number of pfeferoni",
                    MinimalValue = 0,
                    MaximalValue = 10,
                    DefaultValue = 1
                }
            };

            
        }

    }
}
