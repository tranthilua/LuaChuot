using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LuaChuot.Models
{
    public partial class DemoDbContext : DbContext
    {
        public DemoDbContext()
            : base("name=DemoDbContext")
        {
        }

        public virtual DbSet<Account>Accounts { get; set; }
        public virtual DbSet<BeLua>BeLuas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
