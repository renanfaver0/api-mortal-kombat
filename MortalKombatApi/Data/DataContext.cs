using System;
using Microsoft.EntityFrameworkCore;

namespace MortalKombatApi.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433\\sqlexpress;Initial Catalog=CharactersDb; TrustServerCertificate=True");
        }

        public DbSet<Character> Characters { get; set; }
    }
}

