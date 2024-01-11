using DATA;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class Logic
    {
        public async void InitEF()
        {
            using (var db = new EFContextDB())
            {
                await db.Database.EnsureCreatedAsync();



                //for (int i = 0; i < 90000; i++)
                //{
                //    var employee = new Employee
                //    {
                //        Name = GenerateRandomString(5),
                //        LastName = GenerateRandomString(5),
                //        Active = true
                //    };
                //    db.Add(employee);
                //}

                //db.SaveChanges();
            }
        }

        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
