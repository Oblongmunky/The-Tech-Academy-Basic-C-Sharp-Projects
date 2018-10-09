using InsuranceQuoteExercise.Models;
using InsuranceQuoteExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuoteExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuoteInfo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult QuoteInfo(string firstName, string lastName, string emailAddress, DateTime DateOfBirth, string CarYear,
            string CarMake, string CarModel, bool DUI, string Tickets, bool Full)
        {
            InsuranceQuote insuranceQuote = new InsuranceQuote();
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                
                DateTime dob = new DateTime();
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age)) --age;
                insuranceQuote.StartingTotal = 50;
                if (age <= 18) insuranceQuote.StartingTotal = insuranceQuote.StartingTotal + 100;
                if (age <= 25 || age >= 19) insuranceQuote.StartingTotal = insuranceQuote.StartingTotal + 25;
                if (age >= 100) insuranceQuote.StartingTotal = insuranceQuote.StartingTotal + 25;
                int carYear = Convert.ToInt32(CarYear);
                if (carYear <= 1999) insuranceQuote.StartingTotal = insuranceQuote.StartingTotal + 25;
                if (carYear >= 2015) insuranceQuote.StartingTotal = insuranceQuote.StartingTotal + 25;
                if (CarMake == "Porsche") insuranceQuote.StartingTotal = insuranceQuote.StartingTotal + 25;
                if (CarMake == "Porsche" && CarModel == "911 Carrera") insuranceQuote.StartingTotal = insuranceQuote.StartingTotal + 25;
                int tickets = Convert.ToInt32(Tickets);
                tickets = tickets * 10;
                insuranceQuote.FinalQuote = insuranceQuote.StartingTotal + tickets;
                if (DUI == true) insuranceQuote.FinalQuote = insuranceQuote.FinalQuote * 1.25;
                if (Full == true) insuranceQuote.FinalQuote = insuranceQuote.FinalQuote * 1.50;
                ViewBag.finalQuote = insuranceQuote.FinalQuote;
                double FinalQuote = insuranceQuote.FinalQuote;



                string queryString = @"INSERT INTO QuoteInfo (FirstName, LastName, EmailAddress, Quote) VALUES
                                        (@FirstName, @LastName, @EmailAddress, @Quote)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    {
                        command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                        command.Parameters.Add("@LastName", SqlDbType.VarChar);
                        command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                        command.Parameters.Add("@Quote", SqlDbType.Money);

                        command.Parameters["@FirstName"].Value = firstName;
                        command.Parameters["@LastName"].Value = lastName;
                        command.Parameters["@EmailAddress"].Value = emailAddress;
                        command.Parameters["@Quote"].Value = ViewBag.finalQuote;


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                return View("Index");
            }
            
        }



        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, Quote from QuoteInfo";
            List<InsuranceQuote> quotes = new List<InsuranceQuote>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var quote = new InsuranceQuote();
                    quote.FirstName = reader["FirstName"].ToString();
                    quote.LastName = reader["LastName"].ToString();
                    quote.EmailAddress = reader["EmailAddress"].ToString();
                    quote.FinalQuote = Convert.ToDouble(reader["Quote"]);

                    quotes.Add(quote);
                }

            }
            var quoteVms = new List<QuoteVm>();
            foreach (var quote in quotes)
            {
                var quoteVm = new QuoteVm();
                quoteVm.FirstName = quote.FirstName;
                quoteVm.LastName = quote.LastName;
                quoteVm.EmailAddress = quote.EmailAddress;
                quoteVm.FinalQuote = quote.FinalQuote;
                quoteVms.Add(quoteVm);
            }

            return View(quoteVms);
        }
    }
}