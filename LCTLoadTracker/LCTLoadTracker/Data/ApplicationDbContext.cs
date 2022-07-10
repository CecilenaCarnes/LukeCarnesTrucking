using LCTLoadTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LCTLoadTracker.Data;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Person>().HasData(new Person
            { 
                Id = Guid.NewGuid(), FirstName = "John", LastName = "Davidson", Email = "jdavidson1110@gmail.com", CellPhone = "606.514.7884", AddressStreet = "1236 Hawk Creek Rd",
                    AddressCity = "London", AddressState = "KY", AddressZip = 40741, BirthDate = DateTime.Parse ("1963/01/06"), SSN = "785-78-4521" },
                new Person { Id = Guid.NewGuid(), FirstName = "Matt", LastName = "Green", Email = "Bulldog389pete1983@yahoo.com", CellPhone = "859.408.3753", AddressStreet = "214 Baker Bar Subdvs",
                    AddressCity = "Beattyville", AddressState = "KY", AddressZip = 41311, BirthDate = DateTime.Parse ("1983/12/12"), SSN = "452-45-7845" }
                );

         base.OnModelCreating(modelBuilder);

    }


}
