using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuoteExercise.Models
{
    public class InsuranceQuote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int StartingTotal;
        public string Tickets { get; set; }
        public bool DUI;
        public bool Full;
        public double FinalQuote { get; set; }
    }
}