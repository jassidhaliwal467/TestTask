using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestTask.Models
{
    public class Salary
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AnnualSalaryInUSD { get; set; }
        public double Tax { get; set; }
        public double NetIncome { get; set; }
        public double GrossIncome { get; set; }
        public double SuperRateInPercentage { get; set; }
        public double SuperAmount { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}