using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.FluentAPI.Context
{
    class MarketContext: DbContext
    {
        public virtual DbSet<Market> Markets { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Market>().ToTable("MarketsTable");
            modelBuilder.Entity<Market>()
                .Map(m =>
                {
                    m.Properties(p => new { p.Id, p.Name });
                    m.ToTable("MarketsNames");
                })
                .Map(m =>
                {
                    m.Properties(p => new { p.Id, p.Location });
                    m.ToTable("MarketsLocProd");
                });
            
            modelBuilder.Entity<Product>().ToTable("ProductsTable");


            //modelBuilder.Entity<Market>().HasKey(m => m.Name);
            //modelBuilder.Entity<Product>().HasKey(p => new { p.Id, p.Name });

            modelBuilder.Entity<Market>().HasKey(m => m.Id);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);

            modelBuilder.Entity<Market>()
                .HasMany(m => m.Products)
                .WithMany(p => p.Markets)
                .Map(mp => {
                    mp.MapLeftKey("MarketID");
                    mp.MapRightKey("ProductID");
                    mp.ToTable("MarketProductTable");
                });

            modelBuilder.Entity<Market>().Property(m => m.Location).HasColumnName("Market Location");
        }
    }
}
