using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC
{
    public class LogicDate
    {
        public DateTime GetFirstDayOfWeek(DateTime selectedDate)
        {
            DayOfWeek firstDayOfWeek = DayOfWeek.Monday;
            DateTime currentDay = selectedDate;

            while (currentDay.DayOfWeek != firstDayOfWeek)
            {
                currentDay = currentDay.AddDays(-1);
            }

            return currentDay;
        }

        public DateTime GetLastDayOfWeek(DateTime firstDayOfWeek)
        {
            return firstDayOfWeek.AddDays(6);
        }

        public string GetFormatedDate(DateTime firstDayOfWeek, DateTime lastDayOfWeek, int year)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            string description = string.Format("Semana del {0} al {1} de {2}", firstDayOfWeek.ToString("d MMMM", cultureInfo), lastDayOfWeek.ToString("d MMMM", cultureInfo), year);
            return description;
        }

        public int GetWeekNumber(DateTime selectedDate)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            Calendar calendar = cultureInfo.Calendar;
            int weekNumber = calendar.GetWeekOfYear(selectedDate, cultureInfo.DateTimeFormat.CalendarWeekRule, cultureInfo.DateTimeFormat.FirstDayOfWeek);
            return weekNumber;
        }
    }
}
