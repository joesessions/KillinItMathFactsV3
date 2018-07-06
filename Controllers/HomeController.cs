using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillinItMathFactsV3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult PersonalMFAStore(string performanceMF1, string performanceMF2)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=KillinItMathFacts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            string queryString = "INSERT INTO personalMFA (performanceMF1, performanceMF2) VALUES (@performanceMF1, @performanceMF2)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@performanceMF1", SqlDbType.Decimal);
                command.Parameters.Add("@performanceMF2", SqlDbType.Decimal);
                command.Parameters["@performanceMF1"].Value = performanceMF1;
                command.Parameters["@performanceMF2"].Value = performanceMF2;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                
            }
            
                return null;
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TestLand()
        {

            return View();
        }

    }
}



