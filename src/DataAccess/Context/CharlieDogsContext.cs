using ChalieDogs.Ecommerce.DataAccess.Configs;
using ChalieDogs.Ecommerce.Domain.Entities;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ChalieDogs.Ecommerce.DataAccess.Context
{
    public class CharlieDogsContext : DbContext
    {
        public CharlieDogsContext() : base(ConfigurationManager.AppSettings["DatabaseName"])
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new CharlieDogsContextInitializer());
            Database.Initialize(true);
        }

        #region DbSets

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalSize> AnimalSizes { get; set; }
        public DbSet<Person> Persons { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Properties<DateTime>()
                .Configure(p => p.HasColumnType("datetime2"));

            #region Custom Entity Configurations

            modelBuilder.Configurations.Add(new AccountConfiguration());
            modelBuilder.Configurations.Add(new AnimalConfiguration());
            modelBuilder.Configurations.Add(new AnimalSizeConfiguration());
            modelBuilder.Configurations.Add(new PersonConfguration());

            #endregion

        }

        public override int SaveChanges()
        {
            const string propDateCreate = "DateCreate";
            const string propDateUpdate = "DateUpdate";

            var entries = ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty(propDateCreate) != null);

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(propDateCreate).CurrentValue = DateTime.Now;
                }

                if (entry.State != EntityState.Modified) continue;

                entry.Property(propDateUpdate).CurrentValue = DateTime.Now;
                entry.Property(propDateCreate).IsModified = false;
            }
            return base.SaveChanges();
        }
    }
}
