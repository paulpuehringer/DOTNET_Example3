using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DOTNET_Example.Models;
using Npgsql;

namespace DOTNET_Example.Models
{
    //class for entity framework postgres plugin
    public class PizzaService2 : DbContext
    {
        static string connectionString; 
        static SqlConnection conn;
        static SqlCommand command; 
        static SqlDataReader dataReader;
        static String sql = "";
        
        public PizzaService2(DbContextOptions<PizzaService2> options) : base (options) { }
        
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }
        
        public override int SaveChanges()  
        {  
            ChangeTracker.DetectChanges();  
            return base.SaveChanges();  
        } 
    }
    
}