using DATA;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class LogicWeek
    {
        public void AddWeek(int year, int month, int number, string description)
        {
            Week newWeek = new Week
            {
                Year = year,
                Month = month,
                Number = number,
                Description = description
            };

            using (var db = new EFContextDB())
            {
                db.Weeks.Add(newWeek);
                db.SaveChanges();
            }
        }

        public bool Exists(int year, int month, int number)
        {
            using (var db = new EFContextDB())
            {
                var week = db.Weeks.FirstOrDefault(w =>
                        w.Year == year &&
                        w.Number == number);
                return week == null ? false : true;
            }
        }

        public Week GetWeek(int year, int month, int number)
        {
            using (EFContextDB db = new EFContextDB())
            {
                var dbWeek = db.Weeks.FirstOrDefault(x =>
                x.Year == year &&
                x.Month == month &&
                x.Number == number);

                return dbWeek;
            }
        }
    }
}
