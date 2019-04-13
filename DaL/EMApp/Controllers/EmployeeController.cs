using DALTools;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository employRepository;
        private IUnitOfWork uow;

        public EmployeeController(IUnitOfWork unitOfWork) {
            uow = unitOfWork;
            employRepository = uow.EmployeeRepository;
        }

        // GET: Employee
        public ActionResult Index(int currentPage = 1)
        {
            int itemsPerPage = 15;            
            IEnumerable<Employee> employees = employRepository.GetAll();
            int totalPages = (int)Math.Ceiling(employees.Count() / (itemsPerPage * 1.0));

            //make sure current page in correct range
            int theCurrentPage = currentPage < 0 ? 1 : currentPage;
            theCurrentPage = theCurrentPage > totalPages ? totalPages : theCurrentPage;

            IEnumerable<Employee> currentEmployees = employees.Skip(itemsPerPage * (theCurrentPage - 1)).Take(itemsPerPage);

            ViewBag.CurrentPage = theCurrentPage;
            ViewBag.ItemsPerPage = itemsPerPage;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalNumberOfEmployees = employees.Count();

            return View(currentEmployees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.EMPID = id;
            Employee emp = employRepository.GetByID(id);

            return View(emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
