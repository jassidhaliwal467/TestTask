using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View(new Salary());
        }

        [HttpPost]
        public ActionResult Info(Salary s)
        {
            if (s.AnnualSalaryInUSD <= 18200)
            {
                s.Tax = 0;
            }
            else if(s.AnnualSalaryInUSD>=18201 && s.AnnualSalaryInUSD<=37000)
            {
                s.Tax = (int) Math.Round(((s.AnnualSalaryInUSD - 18200) * 0.19)/12);
            }
            else if(s.AnnualSalaryInUSD>=37001 && s.AnnualSalaryInUSD<=87000)
            {
                s.Tax = (int) Math.Round((((s.AnnualSalaryInUSD - 37000) * 0.325) + 3572)/12);
            }
            else if(s.AnnualSalaryInUSD >= 87001 && s.AnnualSalaryInUSD <= 180000)
            {
                s.Tax = (int) Math.Round((((s.AnnualSalaryInUSD - 87000) * 0.37) + 19822)/12);
            }
            else
            {
                s.Tax = (int) Math.Round((((s.AnnualSalaryInUSD - 180000) * 0.45) + 54232)/12);
            }
            s.GrossIncome = (int) Math.Round((double)s.AnnualSalaryInUSD  / 12 );
            s.NetIncome = (int) Math.Round((double)(s.GrossIncome - s.Tax));
            s.SuperAmount = (int) Math.Round((s.GrossIncome*s.SuperRateInPercentage)/100);

            return View(s);
        }
    }
}