using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reserverio.DAL.Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace CommerceCore.DAL.Commerce
{
    public class Reserveriodb : AppDbContext
    {
        private string connection { get; }

        public Reserveriodb() { }

        public Reserveriodb(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public Reserveriodb(string connection)
        {
            this.connection = connection;
            Database.SetCommandTimeout(900000);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseNpgsql(this.connection);
        }
    }
}
