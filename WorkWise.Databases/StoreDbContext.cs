﻿

/*namespace WorkWise.Databases
{
    public class StoreDbContext
    {

    }
}*/
using System;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using WorkWise.Model.Databases;


namespace WorkWise.Databases
{

    // Оголошуємо клас контексту бази даних
    public class StoreDbContext : DbContext
    {
    
        public DbSet<Customer> Customers { get; set; }

        public StoreDbContext() { }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:workwiseserver.database.windows.net,1433;Initial Catalog=WorkWise_Database;Persist Security Info=False;User ID=workwise;Password=rT5665tyyt;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Server=tcp:workwiseserver.database.windows.net,1433;Initial Catalog=WorkWise_Database;Persist Security Info=False;User ID=workwise;Password=rT5665tyyt;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
