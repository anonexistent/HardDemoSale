using DemoSale.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoSale.DataBaseCore
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pkt> Pkt { get; set; }
        public DbSet<Dealer> Dealer { get; set; }
        public DbSet<PositionType> PositionType { get; set; }
        public DbSet<WarrantySubject> WarrantySubject { get; set; }
        public DbSet<WarrantyContract> WarrantyContract { get; set; }
        public DbSet<WarrantyRecord> WarrantyRecord { get; set; }
        public DbSet<TatarstanAnnualReport> TatarstanReport { get; set; }

        public ApplicationContext()
        {
            //MigrationBuilder pktList = new MigrationBuilder("");
            //pktList.RenameTable("_dealer", null, "Dealer");
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlite("DataSource=autocenter.db");

        }
    }
}
