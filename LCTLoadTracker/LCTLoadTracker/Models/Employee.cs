using LCTLoadTracker.Data;
namespace LCTLoadTracker.Models
{

    public class Employee : Person
    {


        public DateOnly? HireDate { get; set; }

        public DateOnly? ExitDate { get; set; }

        public string? GoodStandOnExit { get; set; }


        public string FirstName { get; set; }   
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string CellPhone { get; set; }


    }
    
}
