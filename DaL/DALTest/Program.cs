using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;
using DALTools;

namespace DALTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IUnitOfWork uow = new UnitOfWork(new AdventureWorks2012Entities());
                IEmployeeRepository repo = uow.EmployeeRepository;

                foreach (var emp in repo.GetAll())
                {
                    System.Diagnostics.Debug.WriteLine($"{emp.LoginID} {emp.Person.FirstName} {emp.Person.LastName} {emp.JobTitle}");
                }
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
