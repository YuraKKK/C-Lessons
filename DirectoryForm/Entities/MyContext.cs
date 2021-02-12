using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryForm.Entities
{
    public class MyContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Girl> Girls { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=DbGirls.sqlite");
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=girlsdb;Username=yurauser;Password=Wds543ie73d@sdf88U^ew!");
        }
    }
}
