using System;
using Microsoft.EntityFrameworkCore;
using Domain;
using Persistence;
namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Values> Values{get;set;}        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Values>()
            .HasData(
                new Values{Id=1, Name="Value 201"},
                new Values{Id=2, Name="Value 300"},
                new Values{Id=3, Name="Value 500"}
            );
        }    
    }
}
