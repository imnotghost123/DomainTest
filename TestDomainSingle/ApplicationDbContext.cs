using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestDomainSingle.V3;
using static System.Net.Mime.MediaTypeNames;

namespace TestDomainSingle
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Order> Order { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this command will auto load Configurations file
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            // call configuration
            //modelBuilder.ApplyConfiguration(new UserConfiguration());

            // example Seed database. Step1 model get creating . Step 2 checkany configuration in assembly. Step3
            //modelBuilder.Entity<User>().HasData(new User
            //{
            //    Id = 16,
            //    UserName = "Admin",
            //    Password = "123411",
            //    CreatedDateTime = DateTime.Now,
            //    ModifiedDateTime = DateTime.Now,
            //});

            //modelBuilder.Entity<User>().HasData(new User[]
            //{
            //    new User
            //    {
            //    Id = 3,
            //    UserName = "Admin1",
            //    Password = "12345",
            //    CreatedDateTime = DateTime.Now,
            //    ModifiedDateTime = DateTime.Now,
            //    },
            //    new User
            //    {
            //    Id = 4,
            //    UserName = "Admin2",
            //    Password = "12345",
            //    CreatedDateTime = DateTime.Now,
            //    ModifiedDateTime = DateTime.Now,
            //    }
            //});


            base.OnModelCreating(modelBuilder);
        }

    }
}
