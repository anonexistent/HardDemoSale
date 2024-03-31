using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSale.DataBaseCore
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Dealer> Dealer { get; set; }
        public DbSet<PositionType> PositionType { get; set; }

        public ApplicationContext()
        {
            //MigrationBuilder a = new MigrationBuilder("");
            //a.RenameTable("_dealer", null, "Dealer");
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlite("DataSource=autoservice.db");

        }
    }
}
