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
        SQLRepository<EmployeeDetail> context;

        public EmployeeManagerController()
        {
            context = new SQLRepository<EmployeeDetail>();
        }
        // GET: EmployeeManager
        public ActionResult Index()
        {
            return View();
        }
    }
}