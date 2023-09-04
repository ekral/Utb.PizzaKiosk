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
        public DbSet<PizzaOptionValue> PizzaOptionValues { get; set; } 
        public DbSet<PizzaOrder> PizzaOrder { get; set; } 
        public DbSet<PizzaOrderOption> PizzaOrderOptions { get; set; }

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
            PizzaOption pizzaOptionSize = new()
            {
                 Id = 1,
                 PizzaOptionType = PizzaOptionType.StringSelection,
                 PizzaOptionName = "Size",
                 PizzaOptionDescription = "Pizza size selection"  
            };

            PizzaOption pizzaOptionPfefferoni = new()
            {
                Id = 2,
                PizzaOptionType = PizzaOptionType.IntSelection,
                PizzaOptionName = "Pfefferoni",
                PizzaOptionDescription = "Number of Pfefferones"
            };

            PizzaOption pizzaOptionAdditionaCheese = new()
            {
                Id = 3,
                PizzaOptionType = PizzaOptionType.BooleanSection,
                PizzaOptionName = "Additional Cheese",
                PizzaOptionDescription = "Extra chease (Yes, No)"
            };

            // Save to the generic column PizzaOrderOptionAdditionalInfo
            PizzaOption pizzaOptionExactVolume = new()
            {
                Id = 4,
                PizzaOptionType = PizzaOptionType.IntValue,
                PizzaOptionName = "ketchup militers",
                PizzaOptionDescription = "Extract volume of ketchup"
            };

            modelBuilder.Entity<PizzaOption>().HasData(pizzaOptionSize, pizzaOptionPfefferoni, pizzaOptionAdditionaCheese, pizzaOptionExactVolume);


        }

    }
}
