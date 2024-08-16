using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeControler
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                // Obtiene los datos de la tabla y los convierte en una lista
                return View(context.Employee.ToList()); // Retorna la lista al View
            }
        }

        // GET: EmployeeControler/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                Employee employee = context.Employee.Where(x => x.id == id).FirstOrDefault();
                return View(employee); // Retorna la lista al View
            }
        }

        // GET: EmployeeControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeControler/Create
        [HttpPost]
        public ActionResult Create(Models.Employee employee)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Employee.Add(employee);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeControler/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {

                return View(context.Employee.Where(x => x.id == id).FirstOrDefault()); // Retorna la lista al View
            }
        }

        // POST: EmployeeControler/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Models.Employee employee)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(employee).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeControler/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {

                return View(context.Employee.Where(x => x.id == id).FirstOrDefault()); // Retorna la lista al View
            }
        }

        // POST: EmployeeControler/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Employee employee = context.Employee.Where(x => x.id == id).FirstOrDefault();
                    context.Employee.Remove(employee);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
