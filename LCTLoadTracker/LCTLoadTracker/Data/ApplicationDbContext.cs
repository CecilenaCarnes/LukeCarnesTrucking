using LCTLoadTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LCTLoadTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Load> Loads { get; set; }  //How do I make this its own table.


        //using SamuraiApp.Domain;

        //    public class SamuraiContext : DbContext
        //{
        // public DbSet<Samurai> Samurais { get; set; }
        // public DbSet<Quote> Quotes { get; set; }

        //this worked protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //this worked    optionsBuilder.UseSqlServer(
        //this worked         "Data Source= (localdb)\\mssqllocaldb; Initial Catalog=aspnet-LCTLoadTracker-3525F435-0D41-4FC5-A863-B98D89B39220;"); 
        //(localdb)\\MSSQLLocalDB; Initial Catalog=SamuraiAppData");
        //"Server=(localdb)\\mssqllocaldb;Database=aspnet-LCTLoadTracker-3525F435-0D41-4FC5-A863-B98D89B39220;Trusted_Connection=True;MultipleActiveResultSets=true"

        //  }
        // }
        //}



        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Person>().HasData(new Person
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Davidson",
                Email = "jdavidson1110@gmail.com",
                CellPhone = "606.514.7884",
                AddressStreet = "1236 Hawk Creek Rd",
                AddressCity = "London",
                AddressState = "KY",
                AddressZip = 40741,
                BirthDate = DateTime.Parse("1963/01/06"),
                SSN = "785-78-4521"
            },
                      new Person
                      {
                          Id = Guid.NewGuid(),
                          FirstName = "Matt",
                          LastName = "Green",
                          Email = "Bulldog389pete1983@yahoo.com",
                          CellPhone = "859.408.3753",
                          AddressStreet = "214 Baker Bar Subdvs",
                          AddressCity = "Beattyville",
                          AddressState = "KY",
                          AddressZip = 41311,
                          BirthDate = DateTime.Parse("1983/12/12"),
                          SSN = "452-45-7845"
                      });



            modelBuilder.Entity<Load>().HasData(new Load
            {
                LoadID = Guid.NewGuid(),
                Driver = DriverList.Matt,
                Date = DateTime.Parse("2022-7-10"),
                LoadCount = 1,
                BOL = 895424,
                TerminalLoaded = TerminalList.KnoxvilleShell,
                CustomerUnloaded = CustomerList.DocsColumbia,
                Product1 = ProductList.Gas,
                Gallons1 = 8900,
                Split = "No",
                Pump = "No"
            });

            base.OnModelCreating(modelBuilder);
        }

  
   
        

}

    
}



