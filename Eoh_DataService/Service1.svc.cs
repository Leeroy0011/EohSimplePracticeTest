using Eoh_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Eoh_DataService
{

    public class Service1 : IService1
    {

        private EohDbContext db = new EohDbContext();
        public List<Person> GetPersons()
        {
            var persons = db.Persons.ToList();
            return persons;
        }

        public List<Employee> GetEmployee()
        {
            var employee = db.Employees.ToList();
            return employee;
        }

        public void InsertEmployee(Employee pobj)
        {
            db.Employees.Add(pobj);
            db.SaveChanges();
        }

        public void InsertPerson(Person pobj)
        {
            db.Persons.Add(pobj);
            db.SaveChanges();
        }


        public void UpdateEmployee(Employee pobj)
        {
            var result = db.Employees.SingleOrDefault(b => b.EmployeeID == pobj.EmployeeID);
            if (result != null)
            {
                result.EmployeeNumber = pobj.EmployeeNumber;
                result.EmployedDate = pobj.EmployedDate;
                result.TerminatedDate = pobj.TerminatedDate;
                db.SaveChanges();
            }
        }

        public void UpdatePerson(Person pobj)
        {
            var result = db.Persons.SingleOrDefault(b => b.PersonID == pobj.PersonID);
            if (result != null)
            {
                result.FirstName = pobj.FirstName;
                result.LastName = pobj.LastName;
                result.BirthDate = pobj.BirthDate;
                db.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            var result = db.Employees.SingleOrDefault(b => b.EmployeeID == id);
            db.Employees.Remove(result);
            db.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            var result = db.Persons.SingleOrDefault(b => b.PersonID == id);
            db.Persons.Remove(result);
            db.SaveChanges();
        }

        public Person GetPersonsById(int id)
        {
            var persons = db.Persons.Where(x => x.PersonID == id).FirstOrDefault();
            return persons;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = db.Employees.Where(x => x.EmployeeID == id).FirstOrDefault();
            return employee;
        }
    }
}
