using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEntityQuete1
{
    class SaContext: DbContext
    {
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<SavingAccount> SavingAccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=EntityFrameworkQuete1;Integrated Security=True");
        }
    }
}
