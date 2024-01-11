using DATA;
using ENTITIES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class LogicWeekEmployee
    {
        /*
            Obtener la lista de empleados activos 
            marcando los empleados que tienen un registro
            es decir que estar marcados como check
         */
        public List<Register> Get(int idWeek)
        {
            using (EFContextDB db = new EFContextDB())
            {
                // Obtener datos
                List<Employee> allEmployees = db.Employees.Where(x => x.Active == true).OrderBy(x => x.LastName).ToList();
                List<WeekEmployee> relations = db.WeekEmployees
                    .Include(x => x.Week)
                    .Include(x => x.Employee)
                    .Where(x => x.Week.Id == idWeek).ToList();

                // Crear el registro
                List<Register> regs = new List<Register>();

                foreach (Employee employee in allEmployees)
                {
                    bool founded = false;

                    Register reg = new Register();
                    reg.Id = employee.Id;
                    reg.Name = employee.Name + " " + employee.LastName;

                    foreach (WeekEmployee weekEmployee in relations)
                    {
                        if (employee.Id == weekEmployee.Employee.Id)
                        {
                            reg.Registered = true;
                            founded = true;
                        }
                    }

                    if (!founded)
                        reg.Registered = false;

                    regs.Add(reg);
                }

                return regs;
            }
        }

        public void Do(int idEmployee, Week weekx, bool state)
        {
            using (EFContextDB db = new EFContextDB())
            {
                // Buscar el registro
                var register = db.WeekEmployees.FirstOrDefault(
                        x =>
                            x.Employee.Id == idEmployee &&
                            x.Week.Id == weekx.Id
                    );

                // Buscar el empleado
                var employee = db.Employees.FirstOrDefault(x => x.Id == idEmployee);

                // Busca la semana
                var week = db.Weeks.FirstOrDefault(x => x.Id == weekx.Id);

                if (register == null && state == true)
                {
                    // Crear el registro
                    WeekEmployee weekEmployee = new WeekEmployee();
                    weekEmployee.Employee = employee;
                    weekEmployee.Week = week;

                    db.WeekEmployees.Add(weekEmployee);
                }

                if (register != null && state == false)
                {
                    // Eliminar el registro
                    db.WeekEmployees.Remove(register);
                }

                db.SaveChanges();
            }
        }
    }
}
