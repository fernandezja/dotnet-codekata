
using App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Data
{
    internal class MailsContext: DbContext
    {
        public DbSet<Mail> Mails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                "Persist Security Info=True;Initial Catalog=Movies;Data Source=.; Integrated Security=True;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
