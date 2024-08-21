using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ControleDeEstoqueProauto.Models
{
    internal class ContextControl : DbContext
    {
        private readonly string _connectionString;
        private readonly string _databaseProvider;

        #region DbSets
        public DbSet<Produtos> produtos {  get; set; }

        #endregion

        public ContextControl()
        {
            _databaseProvider = ConfigurationManager.AppSettings["DatabaseProvider"];
            _connectionString = ConfigurationManager.ConnectionStrings[_databaseProvider + "Connection"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_databaseProvider == "SQLite")
            {
                optionsBuilder.UseSqlite(_connectionString).UseLazyLoadingProxies();
            }
            else if (_databaseProvider == "PostgreSQL")
            {
                optionsBuilder.UseNpgsql(_connectionString).UseLazyLoadingProxies();
            }
            else
            {
                throw new InvalidOperationException("Database provider not supported.");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produtos>().HasKey(c => c.IDSistema);
            base.OnModelCreating(modelBuilder);
        }


    }
}
