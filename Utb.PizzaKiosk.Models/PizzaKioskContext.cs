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
                     DefaultValue = "Medium"
                },
                new PizzaOption()
                {
                    Id = 2,
                    PizzaOptionType = PizzaOptionType.IntSelection,
                    PizzaOptionName = "Pfefferoni",
                    PizzaOptionDescription = "Number of Pfefferones"
                },
                new PizzaOption()
                {
                    Id = 3,
                    PizzaOptionType = PizzaOptionType.BooleanSection,
                    PizzaOptionName = "Additional Cheese",
                    PizzaOptionDescription = "Extra chease (Yes, No)"
                },
                new PizzaOption()
                {
                    Id = 4,
                    PizzaOptionType = PizzaOptionType.IntValue,
                    PizzaOptionName = "ketchup militers",
                    PizzaOptionDescription = "Extract volume of ketchup"
                }
            };

            var optionValues = new PizzaOptionValue[]
            {
                new PizzaOptionValue() { Id = 1, PizzaOptionId = 1, PizzaOptionValueName = "Small"},
                new PizzaOptionValue() { Id = 2, PizzaOptionId = 1, PizzaOptionValueName = "Medium"},
                new PizzaOptionValue() { Id = 3, PizzaOptionId = 1, PizzaOptionValueName = "Large"},
                new PizzaOptionValue() { Id = 4, PizzaOptionId = 2, PizzaOptionValueName = "1"},
                new PizzaOptionValue() { Id = 5, PizzaOptionId = 2, PizzaOptionValueName = "2"},
                new PizzaOptionValue() { Id = 6, PizzaOptionId = 2, PizzaOptionValueName = "3"},
                new PizzaOptionValue() { Id = 7, PizzaOptionId = 3, PizzaOptionValueName = "Yes"},
                new PizzaOptionValue() { Id = 8, PizzaOptionId = 3, PizzaOptionValueName = "No"},
                new PizzaOptionValue() { Id = 9, PizzaOptionId = 4, PizzaOptionValueName = "Volume"},
            };

            modelBuilder.Entity<PizzaOption>().HasData(options);
            modelBuilder.Entity<PizzaOptionValue>().HasData(optionValues);
        }

    }
}
