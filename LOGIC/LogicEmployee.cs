using DATA;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class LogicEmployee
    {
        public bool AddEmployee(Employee employee)
        {
            using (EFContextDB db = new EFContextDB())
            {
                try
                {
                    employee.Active = true;
                    db.Employees.Add(employee);
                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<Employee> GetEmployees()
        {
            using (EFContextDB db = new EFContextDB())
            {
                try
                {
                    return db.Employees.OrderBy(x => x.LastName).ToList();
                }
                catch
                {
                    return new List<Employee>();
                }
            }
        }

        public List<Employee> GetActiveEmployees() 
        {
            using (EFContextDB db = new EFContextDB())
            {
                try
                {
                    return db.Employees.Where(employee => employee.Active == true).OrderBy(x => x.LastName).ToList();
                }
                catch
                {
                    return new List<Employee>();
                }
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            using (EFContextDB db = new EFContextDB())
            {
                var dbEmployee = db.Employees.FirstOrDefault(x => x.Id == employee.Id);

                if (dbEmployee == null)
                    return false;

                dbEmployee.Name = employee.Name;
                dbEmployee.LastName = employee.LastName;

                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateEmployeeEstate(int id, bool value)
        {
            using (EFContextDB db = new EFContextDB())
            {
                var dbEmployee = db.Employees.FirstOrDefault(x => x.Id == id);

                if (dbEmployee == null)
                    return false;

                dbEmployee.Active = value;

                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (EFContextDB db = new EFContextDB())
            {
                try
                {
                    var dbEmployee = db.Employees.FirstOrDefault(x => x.Id == id);
                    dbEmployee.Active = false;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool ActiveEmployee(int id)
        {
            using (EFContextDB db = new EFContextDB())
            {
                try
                {
                    var dbEmployee = db.Employees.FirstOrDefault(x => x.Id == id);
                    dbEmployee.Active = true;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
