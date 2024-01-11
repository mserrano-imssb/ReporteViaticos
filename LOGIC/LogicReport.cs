using DATA;
using ENTITIES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class LogicReport
    {
        LogicEmployee logicEmployee = new LogicEmployee();

        public DataTable GetReport(int startYear, int endYear, int startMonth, int endMonth, int startWeek, int endWeek)
        {
            using (var db = new EFContextDB())
            {
                var weekEmployees = db.WeekEmployees
                    .Include(x => x.Employee)
                    .Include(x => x.Week)
                    .Where(x =>
                    x.Week.Year >= startYear && x.Week.Year <= endYear &&
                    x.Week.Month >= startMonth && x.Week.Month <= endMonth &&
                    x.Week.Number >= startWeek && x.Week.Number <= endWeek
                ).ToList();

                var weeks = db.Weeks.Where(x =>
                    x.Year >= startYear && x.Year <= endYear &&
                    x.Month >= startMonth && x.Month <= endMonth &&
                    x.Number >= startWeek && x.Number <= endWeek
                ).OrderBy(x => x.Number).ToList();

                List<Employee> employees = logicEmployee.GetActiveEmployees();

                DataTable dtReport = new DataTable();
                DataColumn column;
                DataRow row;

                // Columna IdEmpleado
                column = new DataColumn();
                column.DataType = typeof(int);
                column.ColumnName = "ID";
                column.ReadOnly = true;
                column.Unique = false;
                dtReport.Columns.Add(column);

                // Columna empleado
                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = "Empleado";
                column.ReadOnly = true;
                column.Unique = false;
                dtReport.Columns.Add(column);

                // Crear una columna por cada semana
                foreach (var week in weeks)
                {
                    column = new DataColumn();
                    column.DataType = typeof(string);
                    column.ColumnName = week.Description;
                    column.ReadOnly = false;
                    column.Unique = false;
                    dtReport.Columns.Add(column);
                }

                // Cargar empleados
                foreach (var employee in employees)
                {
                    row = dtReport.NewRow();
                    row["ID"] = employee.Id;
                    row["Empleado"] = $"{employee.Name} {employee.LastName}";
                    dtReport.Rows.Add(row);
                }

                foreach (DataRow dtRow in dtReport.Rows)
                {
                    foreach (Week week in weeks)
                    {
                        foreach (WeekEmployee weekEmployee in weekEmployees)
                        {
                            int employeeId = Convert.ToInt32(dtRow["ID"]);

                            if (weekEmployee.Week.Id == week.Id && weekEmployee.Employee.Id == employeeId)
                            {
                                dtRow[week.Description] = "Liquidado";
                            }
                        }
                    }
                }

                return dtReport;
            }
        }
    }
}
