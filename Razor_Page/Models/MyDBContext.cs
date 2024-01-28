using Microsoft.EntityFrameworkCore;

namespace Razor_Page.Models
{

    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        { }
        #region DbSet
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Interior> Interiors { get; set; }
        public DbSet<InteriorDetail> InteriorDetails { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Quotation> Quotations { get; set; }
        public DbSet<QuotationDetail> QuotationDetails { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<InteriorDetail>().HasNoKey();
            modelBuilder.Entity<QuotationDetail>().HasNoKey();

            modelBuilder.Entity<InteriorDetail>()
                .HasKey(t => new { t.InteriorID, t.MaterialID });
            modelBuilder.Entity<InteriorDetail>()
                .Property(t => t.TotalPrice);

            modelBuilder.Entity<InteriorDetail>()
                .HasOne(t => t.Interior)
                .WithMany(t => t.InteriorDetails)
                .HasForeignKey(t => t.InteriorID);

            modelBuilder.Entity<InteriorDetail>()
                .HasOne(t => t.Material)
                .WithMany(t => t.InteriorDetails)
                .HasForeignKey(t => t.MaterialID);

            modelBuilder.Entity<QuotationDetail>()
           .HasKey(t => new { t.InteriorID, t.QuotationID });

            modelBuilder.Entity<QuotationDetail>()
                .HasOne(t => t.Interior)
                .WithMany(t => t.QuotationDetails)
                .HasForeignKey(t => t.InteriorID);

            modelBuilder.Entity<QuotationDetail>()
                .HasOne(t => t.Quotation)
                .WithMany(t => t.QuotationDetails)
                .HasForeignKey(t => t.QuotationID);
        }
    }
}
