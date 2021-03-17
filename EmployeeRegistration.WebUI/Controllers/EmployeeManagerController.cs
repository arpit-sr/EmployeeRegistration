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
            List<EmployeeDetail> products = context.Collection().ToList();
            return View(products);
        }

        public ActionResult Create()
        {
            EmployeeDetail product = new EmployeeDetail();
            return View(product);
        }

        [HttpPost]
        public ActionResult Create(EmployeeDetail product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            else
            {
                context.Insert(product);
                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(String Id)
        {
            EmployeeDetail product = context.Find(Id);
            if (product == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(product);
            }
        }

        [HttpPost]
        public ActionResult Edit(EmployeeDetail product, String Id)
        {
            EmployeeDetail productToEdit = context.Find(Id);

            if (productToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(product);
                }

                productToEdit.FirstName = product.FirstName;
                productToEdit.LastName = product.LastName;
                productToEdit.EmailID = product.EmailID;
                productToEdit.EmployeeID = product.EmployeeID;
                productToEdit.EmployeeLocation = product.EmployeeLocation;
                productToEdit.Image = product.Image;

                context.Commit();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(String Id)
        {
            EmployeeDetail productToDelete = context.Find(Id);

            if (productToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(productToDelete);
            }
        }

        [HttpPost]
        [ActionName("DELETE")]
        public ActionResult ConfirmDelete(String Id)
        {
            EmployeeDetail productToDelete = context.Find(Id);

            if (productToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");
            }
        }
    }
}