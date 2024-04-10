using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class EmberContext : DbContext
    {

        public EmberContext() { }
        public DbSet<Ember> Emberek { get; set; }

        
        //string conn = "Server=127.0.0.1;Database=EmberekDB;User ID=root;Password=";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EmberekDB;Trusted_Connection=True");

            //optionsBuilder.UseSqlServer(conn);
        }
    }
}