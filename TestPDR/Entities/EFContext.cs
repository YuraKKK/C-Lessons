using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPDR.Entities
{
   public class EFContext: DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=DbGirls.sqlite");
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=girlsdb;Username=yurauser;Password=Wds543ie73d@sdf88U^ew!");
        }
    }
}
