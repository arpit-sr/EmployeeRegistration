using EmployeeRegistration.Core.Contracts;
using EmployeeRegistration.Core.Models;
using EmployeeRegistration.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeRegistration.WebUI.Controllers
{
    public class EmployeeManagerController : Controller
    {
        ISQLRepository<EmployeeDetail> context;

        public EmployeeManagerController(ISQLRepository<EmployeeDetail> EmpDetails)
        {
            context = EmpDetails;
        }
        // GET: EmployeeManager
        public ActionResult Index()
        {
            return View();
        }
    }
}