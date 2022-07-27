using Microsoft.Graph;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCTLoadTracker.Models
{
    public class Person
    {


        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        //call is valid email and insert regex
        public string? CellPhone { get; set; }
        public string? HomePhone { get; set; }
        public string? AddressStreet { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressState { get; set; }
        public int? AddressZip { get; set; }

        public DateTime? BirthDate { get; set; } 
        public string? SSN { get; set; }

        internal class FirstName
        {
        }
    }




}




