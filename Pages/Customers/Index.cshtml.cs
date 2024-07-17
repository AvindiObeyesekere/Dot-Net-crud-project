using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;
namespace projdotnet.Pages.Customers
{
    public class Index : PageModel
    {
        
        public List<CustomerInfo> CustomerList {get; set;} =[];
       
        public void OnGet()
        {
            try{
                string connectionString = "Server=.;Database=crmdb;Trusted_Connection=True;TrustServerCertificate=True; ";
                using (SqlConnection connection = new SqlConnection(connectionString)){
                    connection.Open();
                }
            }catch(Exception ex){
                Console.WriteLine("An error" + ex.Message);
            }
        }
    }

    public class CustomerInfo{
        public int Id{get;set;}
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public string Email { get; set; }= "";
        public string Phone { get; set; }= "";
        public string Address { get; set; }= "";
        public string Company { get; set; }= "";
        public string Notes { get; set; }= "";
        public string CreatedAt { get; set; }= "";


    }
}